using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FastReport;
using System.Drawing.Printing;
using Microsoft.VisualBasic;
using Dataccess;
namespace RegistroRetal
{
    public partial class frMain : Form
    {
        OfimaticaDBContext db;
        List<OPERARIO> Lista_Operarios;
        List<tblProd_Impresores> Lista_Operarios_Impresion;
        Properties.Settings _configuracion = new Properties.Settings();
        string strMensaje;
        string strCodCC,strPrefijo;
        decimal decPesoBruto;

        public frMain()
        {
            InitializeComponent();
        }

        private void frMain_Load(object sender, EventArgs e)
        {

            

            string[] Argumentos = Environment.GetCommandLineArgs();
            ActivarGuardar(false);
            if (Argumentos.Length > 1)
            {
                db = new OfimaticaDBContext();
                db = new OfimaticaDBContext(ModificarDBConexion(_configuracion.Servidor, Argumentos[2], _configuracion.Usuario, _configuracion.Password));
                lblUsuario.Text = Argumentos[3].ToUpper();
                lblUsuario.Text = Argumentos[3];
                lblDB.Text = Argumentos[2].ToUpper();
            }
            else
            {
                db = new OfimaticaDBContext(ModificarDBConexion(_configuracion.Servidor, _configuracion.DB, _configuracion.Usuario, _configuracion.Password));
                lblUsuario.Text = _configuracion.Usuario;
                lblDB.Text = _configuracion.DB.ToUpper();
            }

            string[] maquinas;

            //MessageBox.Show("Argumento 3: " + Argumentos[3].Substring(0, Argumentos[3].IndexOf('-')).ToLower().Trim());
            string usuario;
            if (Argumentos[3].IndexOf('-') > 0)
                usuario = Argumentos[3].Substring(0, Argumentos[3].IndexOf('-')).ToLower().Trim();
            else
                usuario = Argumentos[3];

            switch (usuario)
            {
                case "extrusion":
                    causaExtrusion.Visible = true;
                    rbExt.Checked = true;
                    rbImp.Enabled = false;
                    rbSell.Enabled = false;
                    rbRefil.Enabled = false;
                    rbLam.Enabled = false;
                    maquinas = _configuracion.maqExt.Split(',');
                    break;
                case "impresion":
                    causasImpresion.Visible = true;
                    rbImp.Checked = true;
                    rbExt.Enabled = false;
                    rbSell.Enabled = false;
                    rbRefil.Enabled = false;
                    maquinas = _configuracion.maqImp.Split(',');
                    break;
                case "refilado":
                    causaRefilado.Visible = true;
                    rbRefil.Checked = true;
                    rbImp.Enabled = false;
                    rbSell.Enabled = false;
                    rbExt.Enabled = false;
                    rbLam.Enabled = false;
                    maquinas = _configuracion.maqRef.Split(',');
                    break;
                case "sellado":
                    causaSellado.Visible = true;
                    rbSell.Checked = true;
                    rbImp.Enabled = false;
                    rbExt.Enabled = false;
                    rbRefil.Enabled = false;
                    rbLam.Enabled = false;
                    maquinas = _configuracion.maqSell.Split(',');
                    break;
                default:
                    maquinas = new string[] { "1" ,"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };
                    break;
            }

            ctxtMaquina.Items.AddRange(maquinas);

            Lista_Operarios = db.OPERARIOs.ToList();
            Lista_Operarios_Impresion = db.tblProd_Impresores.ToList();

            /*causaExtrusion.Visible = false;
            causaRefilado.Visible = false;
            causaSellado.Visible = false;
            causasImpresion.Visible = false;
            causasLaminacion.Visible = false;*/

        }

        #region Modificar cadena de conexion
        private String ModificarDBConexion(String Servidor, String Database, string DBUser, string DBPassword)
        {
            //Data Source=hestia;Initial Catalog=PLASMARSA;Persist Security Info=True;User ID=ofimatica;Password=ofimatica
            String connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", Servidor, Database, DBUser, DBPassword);
            return connString;
        }
        #endregion

       private void SetearControles()
        {
            txtCliente.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPedido.Text = string.Empty;
            txtPeso.Text = string.Empty;
            cmbResponsable.Text = string.Empty;
            txtMaquinaOld.Text = string.Empty;
            lblNombreResponsable.Text = string.Empty;
            txtObservacion.Text = string.Empty;
            
            ActivarGuardar(false);

        }
        private void ActivarGuardar(Boolean activar)
        {
            btnGuardar.Enabled = activar;
        }



        private void txtPedido_Validating(object sender, CancelEventArgs e)
        {
            string strPedido;
            strPedido = txtPedido.Text;
            //Buscar historial de pedidos
            VFACTURACION_PEDIDO objPedido;
            objPedido = null;
            objPedido = db.VFACTURACION_PEDIDOs.Where(x => x.PEDIDO == txtPedido.Text.Trim()).Take(1).SingleOrDefault();

            if (objPedido == null)
            {
                strMensaje = string.Format("Pedido {0} no existe.\n Por favor Verifique el numero de pedido!", strPedido.Trim());
                MessageBox.Show(strMensaje, "Validación de pedido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Validar produccion
            if(db.MTLOTE.Where(x=>x.CODLOTE==strPedido).Count()==0)
            {
                strMensaje = string.Format("Pedido {0} no esta programado para producción.\n Por favor Verifique el numero de pedido!", strPedido.Trim());
                MessageBox.Show(strMensaje, "Validación de pedido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ////Validar proceso
            //string proceso="";
            //if(rbImp.Checked)
            //{
            //    proceso = "0202";
            //}
            //if (rbRefil.Checked)
            //{
            //    proceso = "0203";
            //}


            txtCliente.Text = objPedido.NOMBRECLI.TrimEnd();
                txtCodigo.Text = objPedido.CODIGO.TrimEnd();
                txtDescripcion.Text = objPedido.NOMBRE.TrimEnd();
            

        }

        private void cmbResponsable_TextUpdate(object sender, EventArgs e)
        {
            cmbResponsable.DataSource = null;
            string filter_param = cmbResponsable.Text;
            if(rbImp.Checked)
            {
                List<tblProd_Impresores> filteredItemsImpresion = Lista_Operarios_Impresion.FindAll(x =>  x.Nombre.ToLower().Contains(filter_param.ToLower()));
                cmbResponsable.DataSource = filteredItemsImpresion;
                Cursor.Current = Cursors.Default;
                cmbResponsable.DisplayMember = "Nombre";
                cmbResponsable.ValueMember = "Cedula";
            }
            else
            {
                List<OPERARIO> filteredItems = Lista_Operarios.FindAll(x => x.OPERARIO1.ToLower().Contains(filter_param.ToLower()));
                cmbResponsable.DataSource = filteredItems;

                //if (String.IsNullOrWhiteSpace(filter_param))
                //{
                //    cmbResponsable.DataSource = Lista_Operarios;
                //}
                Cursor.Current = Cursors.Default;
                cmbResponsable.DisplayMember = "Operario1";
                cmbResponsable.ValueMember = "Operario1";

            }



            //cmbResponsable.SelectedIndex = -1;
            cmbResponsable.DroppedDown = true;
            cmbResponsable.Text = filter_param;
            cmbResponsable.SelectionLength = filter_param.Length;
            cmbResponsable.Select(filter_param.Length, 0);



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            short idCausa_retal=0;
            
            if (rbExt.Checked)
            {
                idCausa_retal = causaExtrusion.opcion_seleccionada;
            }
            if (rbImp.Checked)
            {
                idCausa_retal = causasImpresion.opcion_seleccionada;
            }
            if (rbLam.Checked)
            {
                idCausa_retal = causasLaminacion.opcion_seleccionada;
            }
            if (rbRefil.Checked)
            {
                idCausa_retal = causaRefilado.opcion_seleccionada;
            }
            if (rbSell.Checked)
            {
                idCausa_retal = causaSellado.opcion_seleccionada;
            }

            if (ctxtMaquina.Text==string.Empty)
            {
                MessageBox.Show("Debe seleccionar una maquina de la lista.", "Error al registrar retal.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                



            long p = DateTime.Now.Ticks;

            if (!ValidarProceso())
                return;
            if (!ValidarResponsable())
                return;

            if (!ValidarCausaRetal())
            {
                MessageBox.Show("Debe seleccionar una causa de retal.", "Error al registrar retal.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if(decPesoBruto<=0)
            {
                MessageBox.Show("La cantidad de retal debe ser mayor a cero (0).", "Error al registrar retal.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            tblRetalRegistro retal;
            DateTime fechaHora = DateTime.Now;
            retal = new tblRetalRegistro();
            retal.Idresponsable = cmbResponsable.SelectedValue.ToString();
            retal.Pedido = txtPedido.Text;
            retal.Codcc = strCodCC;
            retal.FechaHora_Pesaje = DateTime.Now;
            retal.IdPesaje = string.Format("{0}{1}-{2}",
                    strPrefijo, retal.Pedido.Trim(), 
                    fechaHora.Ticks.ToString().Substring(fechaHora.Ticks.ToString().Length-6,6)
                    /*Math.Round(retal.FechaHora_Pesaje.Subtract(new DateTime(retal.FechaHora_Pesaje.Year, 
                        retal.FechaHora_Pesaje.Month, retal.FechaHora_Pesaje.Day)).TotalSeconds) .ToString().PadRight(5,'0')*/
                    
                    );
            //SELECT 'E'+'112897'+'-'+RIGHT('00000'+CAST(DATEDIFF(s,'20180809','20180809 00:05:29.007') AS VARCHAR),5),GETDATE()
            retal.IdMaquina = ctxtMaquina.Text;
            retal.PesoBruto = decPesoBruto;
            retal.Retal = true;
            retal.FechaHora_Descarte = retal.FechaHora_Pesaje;
            retal.Descartado = false;
            retal.IdCausa=idCausa_retal;
            retal.Observacion = txtObservacion.Text.TrimEnd();
            if (lblUsuario.Text.IndexOf('-') > 0)
                retal.UserIng = lblUsuario.Text.Substring(0, lblUsuario.Text.IndexOf('-'));
            else
                retal.UserIng = lblUsuario.Text;
            retal.UserMod = "";

            try
            {
                db.tblRetalRegistro.InsertOnSubmit(retal);
                db.SubmitChanges();
                ImprimirEtiqueta(retal.IdReg);
                SetearControles();
                causaExtrusion.Resetear_Controles();
                causasImpresion.Resetear_Controles();
                causasLaminacion.Resetear_Controles();
                causaRefilado.Resetear_Controles();
                causaSellado.Resetear_Controles();
            }catch(Exception ex)
            {
                strMensaje = ex.Message;
                MessageBox.Show(strMensaje, "Error al registrar retal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ImprimirEtiqueta(Int32 IdMov)
        {
            try
            {
                //accion.Text = "generando etiqueta idetiqueta: " + IdMov.ToString();
                Report report1 = new Report();
                report1.Load(Application.StartupPath + @"\" + _configuracion.Etiqueta);
                report1.SetParameterValue("pIdReg", IdMov);
                report1.Prepare(true);
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings.PrinterName = ObtenerImpresoraPorDefecto();
                System.Drawing.Printing.PrinterSettings pg = new PrinterSettings();
                pg.PrinterName = ObtenerImpresoraPorDefecto();
                report1.PrintPrepared(pg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible imprimir la etiqueta.\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string ObtenerImpresoraPorDefecto()
        {
            PrinterSettings impresora = new PrinterSettings();
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                impresora.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                if (impresora.IsDefaultPrinter)
                    return PrinterSettings.InstalledPrinters[i].ToString();
            }
            return String.Empty;
        }


        private void groupBox3_Validated(object sender, EventArgs e)
        {
            if (rbExt.Checked)
            { strCodCC = "0201"; strPrefijo = "E"; }
            if (rbImp.Checked)
            { strCodCC = "0202"; strPrefijo = "I"; }
            if (rbLam.Checked)
            { strCodCC = "0209"; strPrefijo = "L"; }
            if (rbRefil.Checked)
            { strCodCC = "0203"; strPrefijo = "R"; }
            if (rbSell.Checked)
            { strCodCC = "0204"; strPrefijo = "S"; }
                
        }

        private Boolean ValidarCausaRetal()
        {
            short idcausa=0;
            if (rbExt.Checked)
                idcausa = causaExtrusion.opcion_seleccionada;
            if (rbImp.Checked)
                idcausa = causasImpresion.opcion_seleccionada;
            if (rbLam.Checked)
                idcausa = causasLaminacion.opcion_seleccionada;
            if (rbRefil.Checked)
                idcausa = causaRefilado.opcion_seleccionada;
            if (rbSell.Checked)
                idcausa = causaSellado.opcion_seleccionada;

            if (idcausa == 0)
                return false;
            else
                return true;

        }

        private Boolean ValidarProceso()
        {
            if (rbExt.Checked==false && rbImp.Checked==false && rbLam.Checked==false && rbRefil.Checked==false && rbSell.Checked==false)
            {
                strMensaje = "Debe selecionar un proceso.";
                MessageBox.Show(strMensaje, "Validando proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private Boolean ValidarResponsable()
        {
            if (cmbResponsable.SelectedValue == null || cmbResponsable.SelectedValue.ToString() == "")
            {
                strMensaje = "Debe selecionar un responsable de la lista.";
                MessageBox.Show(strMensaje, "Validando responsable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        public bool ValidarPeso(string strPeso, out string errorMessage)
        {
            if (strPeso.Trim() == "")
            {
                errorMessage = "El valor del pesaje es invalido.";
                return false;
            }

            decimal decVar;
            if (decimal.TryParse(strPeso,out decVar))
            {
                if (decVar == 0  || decVar>500)
                {
                    errorMessage = "El valor del pesaje es inválido";
                    return false;
                }

                    
            }

            errorMessage = "Valor del pesaje es correcto.";
            return true;
        }


        private void txtPeso_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarPeso(txtPeso.Text, out errorMsg))
            {
                e.Cancel = true;
                txtPeso.Select(0, txtPeso.Text.Length);
                this.errorProvider1.SetError(txtPeso, errorMsg);
                ActivarGuardar(false);
            }

            ActivarGuardar(true);
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == a || e.KeyChar == (char)Keys.Enter))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtPeso.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void causaExtrusion1_Load(object sender, EventArgs e)
        {

        }

        private void rbExt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExt.Checked)
            {
                causaExtrusion.Visible = true;
                causaRefilado.Visible = false;
                causaSellado.Visible = false;
                causasImpresion.Visible = false;
                causasLaminacion.Visible = false;

            }
        }

        private void rbImp_CheckedChanged(object sender, EventArgs e)
        {
            ctxtMaquina.Items.Clear();
            if (rbImp.Checked)
            {
                causaExtrusion.Visible = false;
                causaRefilado.Visible = false;
                causaSellado.Visible = false;
                causasImpresion.Visible = true;
                causasLaminacion.Visible = false;

            }
            string[] maquinas;
            maquinas = _configuracion.maqImp.Split(',');
            ctxtMaquina.Items.AddRange(maquinas);
        }

        private void rbLam_CheckedChanged(object sender, EventArgs e)
        {
            ctxtMaquina.Items.Clear();
            if (rbLam.Checked)
            {
                causaExtrusion.Visible = false;
                causaRefilado.Visible = false;
                causaSellado.Visible = false;
                causasImpresion.Visible = false;
                causasLaminacion.Visible = true;

            }
            string[] maquinas;
            maquinas = _configuracion.maqLam.Split(',');
            ctxtMaquina.Items.AddRange(maquinas);
        }

        private void rbRefil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRefil.Checked)
            {
                causaExtrusion.Visible = false;
                causaRefilado.Visible = true;
                causaSellado.Visible = false;
                causasImpresion.Visible = false;
                causasLaminacion.Visible = false;

            }
        }

        private void rbSell_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSell.Checked)
            {
                causaExtrusion.Visible = false;
                causaRefilado.Visible = false;
                causaSellado.Visible = true;
                causasImpresion.Visible = false;
                causasLaminacion.Visible = false;

            }
        }

        private void cmbResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbImp.Checked)
                lblNombreResponsable.Text = string.Empty;
            else
                    if (cmbResponsable.SelectedValue != null)
                lblNombreResponsable.Text = db.OPERARIOs.Where(x => x.OPERARIO1 == cmbResponsable.SelectedValue.ToString()).Select(x => x.NOMBRE).SingleOrDefault();

        }

        private void cmbResponsable_TextChanged(object sender, EventArgs e)
        {
            if (cmbResponsable.Text == "")
                lblNombreResponsable.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime o = DateTime.Now;
            MessageBox.Show(string.Format("{0}-{1}",o.Ticks.ToString().Substring(o.Ticks.ToString().Length-6,6) , o.Ticks.ToString()));
        }

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            bool result = decimal.TryParse(txtPeso.Text, out decPesoBruto);

            if (result == false)
            {
                strMensaje = string.Format("El valor de pesaje ingresado no es valido!.\nPor favor verifique el peso.");
                MessageBox.Show(strMensaje, "Validando valor del peso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(rbRefil.Checked)
                if(decPesoBruto>25)
                {
                    strMensaje = string.Format("El peso de retal de Refilado no debe ser mayor a  25 Kg");
                    MessageBox.Show(strMensaje, "Validando valor del peso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
                ActivarGuardar(true);
        }
    }
}
