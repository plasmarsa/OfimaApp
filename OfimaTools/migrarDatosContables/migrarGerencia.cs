using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace migrarDatosContables
{
    public partial class migrarGerencia : UserControl
    {

        public dbOfimaticaDataContext dbConexion = new dbOfimaticaDataContext();
        public string Opcion_Seleccionada { get; set; }
        public string RutaArchivoIntegracion { get; set; }
        public bool integrar { get; set; }
        public int varAuxInt;
        string mensaje;
        public migrarGerencia()
        {

            InitializeComponent();
            //dbConexion = new dbOfimaticaDataContext();
            CargarGruposCompensacion();
            CargarTiposCausacion();
            btnMigrarDctoContable.Enabled = false;
            fecha.Value = DateTime.Now;

        }
        public void CargarComprobantes()
        {
            //cmbComprobante.DataSource = dbConexion.vUsrGosem_rh_co_comprobantes_encabezados.Where(x => x.id_grupo_compensacion == (Int32)cmbGrCompensacion.SelectedValue && x.id_tipo_causacion == (Int32)cmbTipoCausacion.SelectedValue);
            string sqlQuery;
            sqlQuery = "SELECT * FROM dbo.vUsrGosem_rh_co_comprobantes_encabezados v WHERE v.id_comprobante_encabezado NOT IN ";
            sqlQuery += "(SELECT t.IdComprobanteEncabezado FROM dbo.tblGosemIntegracionesContabilidad t)";
            sqlQuery += string.Format(" AND v.id_grupo_compensacion ={0} AND v.id_tipo_causacion ={1}", cmbGrCompensacion.SelectedValue, cmbTipoCausacion.SelectedValue);


            cmbComprobante.DataSource = dbConexion.ExecuteQuery<vUsrGosem_rh_co_comprobantes_encabezados>(sqlQuery).ToList();

            cmbComprobante.DisplayMember = "descripcion";
            cmbComprobante.ValueMember = "id_comprobante_encabezado";
            cmbComprobante.SelectedIndex = -1;
        }
        public void CargarTiposCausacion()
        {
            cmbTipoCausacion.DataSource = dbConexion.vUsrGosem_rh_co_tipos_causaciones;
            cmbTipoCausacion.DisplayMember = "des_tipo_causacion";
            cmbTipoCausacion.ValueMember = "id_tipo_causacion";
            cmbTipoCausacion.SelectedIndex = -1;
        }
        public void CargarGruposCompensacion()
        {
            cmbGrCompensacion.DataSource = dbConexion.vUsrGosem_rh_co_grupos_compensaciones.Select(x => new { x.des_grupo_compensacion, x.id_grupo_compensacion });
            cmbGrCompensacion.DisplayMember = "des_grupo_compensacion";
            cmbGrCompensacion.ValueMember = "id_grupo_compensacion";
            cmbGrCompensacion.SelectedIndex = -1;
        }
        public void Borrargrid()
        {
            grid.DataSource = null;
        }

        private void cmbTipoCausacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrCompensacion.Text != "" && cmbTipoCausacion.Text != "")
            {
                CargarComprobantes();

            }
            lblTipo.Text = cmbTipoCausacion.SelectedValue == null ? "" : cmbTipoCausacion.SelectedValue.ToString();


        }

        private void FormatearCeldasGrid()
        {
            //CultureInfo.GetCultureInfo("en-GB");
            this.grid.Columns["Debito"].DefaultCellStyle.Format = "c";
            this.grid.Columns["Debito"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.grid.Columns["Debito"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("es-CO");
            this.grid.Columns["Credito"].DefaultCellStyle.Format = "c";
            this.grid.Columns["Credito"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("es-CO");
            this.grid.Columns["Credito"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            decimal totalDebito = 0;
            decimal totalCredito = 0;
            Vaciargrid();

            if (cmbGrCompensacion.Text != "" && cmbTipoCausacion.Text != "" && cmbComprobante.Text != "")
            {
                var p = dbConexion.uspGosem_ConsultaDocumento((Int32)cmbTipoCausacion.SelectedValue, (Int32)cmbGrCompensacion.SelectedValue, (Int32)cmbComprobante.SelectedValue).ToList();
                grid.DataSource = p;
                FormatearCeldasGrid();
            }

            foreach (DataGridViewRow registro in grid.Rows)
            {
                totalDebito += (decimal)registro.Cells["Debito"].Value;
                totalCredito += (decimal)registro.Cells["Credito"].Value;
            }
            lblMensaje.Text = string.Format("Total documento. [Debito : {0}  Crédito : {1}]", totalDebito.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-CO")), totalCredito.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-CO")));

            if (grid.Rows.Count > 0)
            { btnMigrarDctoContable.Enabled = true; }

        }


        private void OrganizarDocumentoCausacionNomina(List<vUsrGosem_DocumentoNomina> pListadocumentos)
        {
            foreach (vUsrGosem_DocumentoNomina registro in pListadocumentos)
            {

            }
        }
        private void Vaciargrid()
        {
            grid.DataSource = null;
            btnMigrarDctoContable.Enabled = false;

        }
        private void cmbComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vaciargrid();
            lblMensaje.Text = "";
            lblDoc.Text = cmbComprobante.SelectedValue == null ? "" : cmbComprobante.SelectedValue.ToString();

        }

        private void cmbGrCompensacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vaciargrid();
            this.lblMensaje.Text = "";
            varAuxInt = -1;

            lblGrupo.Text = cmbGrCompensacion.SelectedValue == null ? "" : cmbGrCompensacion.SelectedValue.ToString();

            if (cmbGrCompensacion.SelectedValue != null && cmbTipoCausacion.SelectedValue != null)
            {
                CargarComprobantes();
            }
        }

        
        private void btnMigrarDctoContable_Click(object sender, EventArgs e)
        {
            
            try
            {
                tblGosemIntegracionesContabilidad integrado = new tblGosemIntegracionesContabilidad();
                integrado = dbConexion.tblGosemIntegracionesContabilidad.Where(x => x.IdComprobanteEncabezado ==
                    (Int32)cmbComprobante.SelectedValue && x.IdGrupoCompensacion ==
                    (Int32)cmbGrCompensacion.SelectedValue && x.IdTipoCausacion ==
                    (Int32)cmbTipoCausacion.SelectedValue).SingleOrDefault();
                if(integrado==null)
                {
                    foreach (DataGridViewRow linea in grid.Rows)
                    {
                        string dcto = linea.Cells[0].Value.ToString();
                        string comprobante = linea.Cells[1].Value.ToString();
                        string tercero = linea.Cells[3].Value.ToString();
                        string cuenta = linea.Cells[2].Value.ToString();
                        string codcc = linea.Cells[8].Value.ToString();
                        string detalle = linea.Cells[7].Value.ToString();
                        string descripcion = linea.Cells[9].Value.ToString();
                        decimal debito = (decimal)linea.Cells[5].Value;
                        decimal credito = (decimal)linea.Cells[6].Value;
                        string _fecha = this.fecha.Value.ToString("yyyyMMdd");
                        string nota = string.Format("[Grupo:{0}-Dcto:{1}] ", cmbGrCompensacion.SelectedValue.ToString(), cmbComprobante.SelectedValue.ToString());



                        if (integrar)
                        {
                            if( (credito+debito)>0 )
                            {
                                dbConexion.uspNominaContabilizarDetalleDocumentoGOSEM(dcto, _fecha, comprobante, tercero, codcc, cuenta, credito, debito, descripcion, detalle, nota);
                                linea.DefaultCellStyle.BackColor = Color.Beige;
                                dbConexion.ExecuteCommand(string.Format("UPDATE c SET c.CONSECUT={0} FROM dbo.CONSECUT c WHERE c.CODIGOCONS='CON09' and c.CONSECUT<{1} ", dcto.Trim(), dcto.Trim()));
                            }
                            
                            
                            
                        }
                    }
                    mensaje = string.Format("Integración documento [{0}] para el grupo de compensación [{1}] ha sido exitosa.",cmbComprobante.Text,cmbGrCompensacion.Text);
                    MessageBox.Show(mensaje, "Integración Contable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //PlanoIntegracion(string.Format("{0}_{1}_{2}.csv", cmbGrCompensacion.Text.TrimEnd(), cmbComprobante.Text, fecha.Value.ToString("yyyyMMdd")));
                    PlanoIntegracion(string.Format("{0}{1}_{2}_{3}.csv",RutaArchivoIntegracion, cmbGrCompensacion.Text.TrimEnd(), cmbComprobante.Text, fecha.Value.ToString("yyyyMMdd")));
                    integrado = new tblGosemIntegracionesContabilidad();
                    integrado.IdComprobanteEncabezado = (Int32)cmbComprobante.SelectedValue;
                    integrado.IdGrupoCompensacion = (Int32)cmbGrCompensacion.SelectedValue;
                    integrado.IdTipoCausacion = (Int32)cmbTipoCausacion.SelectedValue;
                    dbConexion.tblGosemIntegracionesContabilidad.InsertOnSubmit(integrado);
                    dbConexion.SubmitChanges();
                    

                }
                else
                {
                    mensaje = string.Format("El documento [{0}] del grupo de compensacion [{1}] ya se encuentra integrado en Ofimatica. Desea generar documento de integracion?",cmbComprobante.Text,cmbGrCompensacion.Text);
                    if(MessageBox.Show(mensaje, "Integración Contable", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)== DialogResult.Yes)
                    {
                            PlanoIntegracion(string.Format("{0}{1}_{2}_{3}.csv", RutaArchivoIntegracion, cmbGrCompensacion.Text.TrimEnd(), cmbComprobante.Text, fecha.Value.ToString("yyyyMMdd")));
                    }
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Integración Contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





            
            
        }
        private void ActualizarProgresoProceso()
        {

        }


        private void PlanoIntegracion( string NombreArchivo)
        {
            string _rutaPreintegracion="";
            string _linea="";
            char separadorLista = Convert.ToChar(Thread.CurrentThread.CurrentCulture.TextInfo.ListSeparator);

            //_rutaPreintegracion= RutaArchivoIntegracion + string.Format("{0}_{1}_{2}.csv",cmbGrCompensacion.Text.TrimEnd(),cmbComprobante.Text,fecha.Value.ToString("yyyyMMdd"));
            //_rutaPreintegracion = RutaArchivoIntegracion + NombreArchivo;
            _rutaPreintegracion = NombreArchivo;

            try
            {

                using (System.IO.StreamWriter w = System.IO.File.AppendText(_rutaPreintegracion))
                {
                    Log(cmbTipoCausacion.Text.TrimEnd(), w);
                    Log(string.Format("Nrodcto{0}Comprobante{0}Cuenta_Contable{0}Tercero{0}Nombre{0}Debito{0}Credito{0}Detalle{0}CodCC{0}Descripcion", separadorLista), w);
                    xpProgreso.Enabled = true;
                    xpProgreso.PositionMax = grid.Rows.Count;
                    xpProgreso.PositionMin = 0;
                    xpProgreso.Text = "";
                    

                    foreach (DataGridViewRow linea in grid.Rows)
                    {
                        
                        xpProgreso.PositionMin += 1;
                       

                        xpProgreso.Text = string.Format("Procesando...Cuenta {0}", linea.Cells[2].Value);

                        string dcto = linea.Cells[0].Value.ToString();
                        string comprobante = linea.Cells[1].Value.ToString();
                        string cuenta = linea.Cells[2].Value.ToString();
                        string tercero = linea.Cells[3].Value.ToString();
                        string Nombre = linea.Cells[4].Value.ToString();
                        string debito = linea.Cells[5].Value.ToString();
                        string credito = linea.Cells[6].Value.ToString();
                        string detalle = linea.Cells[7].Value.ToString();
                        string codcc = linea.Cells[8].Value.ToString();
                        string descripcion = linea.Cells[9].Value.ToString();
                        //_linea = string.Format("{0};_{1};{2};{3};{4};{5};{6};{7};_{8};{9}", dcto, comprobante, cuenta, tercero, Nombre, debito, credito, detalle, codcc, descripcion);
                        _linea = string.Format("{0}{10}_{1}{10}{2}{10}{3}{10}{4}{10}{5}{10}{6}{10}{7}{10}_{8}{10}{9}", dcto, comprobante, cuenta, tercero, Nombre, debito, credito, detalle, codcc, descripcion,separadorLista);
                        if( (decimal.Parse(debito)+ decimal.Parse(credito))>0)
                        { 
                            Log(_linea, w);
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Integración Contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(string.Format("Documento de preintegración generado: {0}.",_rutaPreintegracion), "Integración Contable", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void ResetearBarraProgreso(int valorMaximo,string mensaje)
        {
            xpProgreso.PositionMin = 0;
            xpProgreso.PositionMax = valorMaximo;
            xpProgreso.Text = mensaje;
        }
        private void DesactivarBarraProgreso()
        {
            xpProgreso.Text = "";
            xpProgreso.PositionMax = 0;
            xpProgreso.PositionMin = 0;
        }
        private void ActualizarBarraProgreso(int aumento,string mensaje)
        {
            xpProgreso.PositionMin += 1;
            xpProgreso.Text = mensaje;
        }
        public static void Log(string logMessage,System.IO.TextWriter w)
        {
            w.WriteLine(logMessage);

            //w.Write("\r\nLog Entry : ");
            //w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            //    DateTime.Now.ToLongDateString());
            //w.WriteLine("  :");
            //w.WriteLine("  :{0}", logMessage);
            //w.WriteLine("-------------------------------");
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "csv FlatFile|*.csv";
            guardarArchivo.Title = "Guardar un archivo plano tipo .CSV";
            guardarArchivo.ShowDialog();
            PlanoIntegracion(guardarArchivo.FileName);
        }
        
    }
}
