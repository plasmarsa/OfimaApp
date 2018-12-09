using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Dataccess;
using System.IO.Ports;
using System.Globalization;
using System.Drawing.Printing;
using FastReport;


namespace IngresoMatPrima
{
    public partial class ctrolEntrada : UserControl
    {
        protected OfimaticaDBContext _dbConn;
        public decimal _pesoEstiba;
        public decimal _pesoBruto;
        public decimal _pesoNeto;
        public decimal _pesoNeto2=0;
        public List<Proveedor> Proveedores;
        public List<MateriaPrima> MateriasPrimas;
        public Thread th;
        Properties.Settings config = new Properties.Settings();
        //string _windowString;
        public decimal _descontar;
        public ctrolEntrada()
        {
            InitializeComponent();




        }

        public ctrolEntrada(ref OfimaticaDBContext dbConexion)
        {
            _dbConn = dbConexion;
            InitializeComponent();
        }

        private void ListarMateriasPrimas()
        {
            MateriasPrimas = new List<MateriaPrima>();
            MateriasPrimas = _dbConn.MTMERCIA.Where(x => x.TIPOINV == "mp" && x.HABILITADO == true).
                Select(s => new MateriaPrima() { Codigo = s.CODIGO.TrimEnd(), Descripcion = string.Format("{0} - {1}", s.CODIGO.TrimEnd(), s.DESCRIPCIO.TrimEnd()) }).ToList();
        }

        private void ListarProveedores()
        {
            Proveedores = new List<Proveedor>();
            Proveedores = _dbConn.MTPROCLI.Where(x => x.ESPROVEE.ToString().ToLower() == "s").
                Select(s => new Proveedor() { Nit = s.NIT.Trim(), Nombre = string.Format("{0} - {1}", s.NIT.Trim(), s.NOMBRE.TrimEnd()) }).ToList();
        }

        private void cmbProveedor_TextUpdate(object sender, EventArgs e)
        {
            string parametro_filtro = cmbProveedor.Text; ;
            List<string> elementos_filtrados = Proveedores.Where(x => x.Nombre.ToLower().Contains(parametro_filtro)).Select(x => x.Nombre.ToString()).ToList();
            cmbProveedor.Items.Clear();

            if (string.IsNullOrWhiteSpace(parametro_filtro))
            {
                cmbProveedor.Items.AddRange(Proveedores.Select(x => x.Nombre.ToString()).ToArray());
            }
            else
            {
                cmbProveedor.Items.AddRange(elementos_filtrados.ToArray());
            }
            cmbProveedor.SelectedIndex = -1;
            cmbProveedor.DroppedDown = true;
            Cursor.Current = Cursors.Default;
            cmbProveedor.Text = parametro_filtro;
            cmbProveedor.SelectionLength = parametro_filtro.Length;
            cmbProveedor.Select(parametro_filtro.Length, 0);

        }

        private void ctrolEntrada_Load(object sender, EventArgs e)
        {
            rbMadera.Text = string.Format("Madera {0} KG", FormatearDecimal(config.pesoEstibaMadera).ToString());
            rbPlastico.Text = string.Format("Plástico {0} KG", FormatearDecimal(config.pesoEstibaPlastica).ToString() );
            rbNoEstiba.Checked = true;
            ListarMateriasPrimas();
            ListarProveedores();

            try
            {
                serial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                serial.Open();
                cmbProveedor.Focus();

            }catch(Exception ex)
            {
                MessageBox.Show("Error abriendo el puerto.\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Modificar cadena de conexion
        private String BuildConnectionString(String DataSource, String Database)
        {
            //Data Source=hestia;Initial Catalog=PLASMARSA;Persist Security Info=True;User ID=ofimatica;Password=ofimatica
            String connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID=ofimatica;Password=ofimatica", DataSource, Database);
            return connString;
        }
        #endregion

        private void cmbProducto_TextUpdate(object sender, EventArgs e)
        {
            string parametro_filtro = cmbProducto.Text; ;
            List<string> elementos_filtrados = MateriasPrimas.Where(x => x.Descripcion.ToLower().Contains(parametro_filtro)).Select(x => x.Descripcion.ToString()).ToList();
            cmbProducto.Items.Clear();

            if (string.IsNullOrWhiteSpace(parametro_filtro))
            {
                cmbProducto.Items.AddRange(MateriasPrimas.Select(x => x.Descripcion.ToString()).ToArray());
            }
            else
            {
                cmbProducto.Items.AddRange(elementos_filtrados.ToArray());
            }

            cmbProducto.SelectedIndex = -1;
            cmbProducto.DroppedDown = true;
            Cursor.Current = Cursors.Default;
            cmbProducto.Text = parametro_filtro;
            cmbProducto.SelectionLength = parametro_filtro.Length;
            cmbProducto.Select(parametro_filtro.Length, 0);
        }

        private void cmbProducto2_TextUpdate(object sender, EventArgs e)
        {
            string parametro_filtro = cmbProducto2.Text; ;
            List<string> elementos_filtrados = MateriasPrimas.Where(x => x.Descripcion.ToLower().Contains(parametro_filtro)).Select(x => x.Descripcion.ToString()).ToList();
            cmbProducto2.Items.Clear();

            if (string.IsNullOrWhiteSpace(parametro_filtro))
            {
                cmbProducto2.Items.AddRange(MateriasPrimas.Select(x => x.Descripcion.ToString()).ToArray());
            }
            else
            {
                cmbProducto2.Items.AddRange(elementos_filtrados.ToArray());
            }
            cmbProducto2.SelectedIndex = -1;
            cmbProducto2.DroppedDown = true;
            Cursor.Current = Cursors.Default;
            cmbProducto2.Text = parametro_filtro;
            cmbProducto2.SelectionLength = parametro_filtro.Length;
            cmbProducto2.Select(parametro_filtro.Length, 0);
        }

        private void chkDosProductosEstiba_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDosProductosEstiba.Checked)
            {
                lblProducto2.Visible = true;
                cmbProducto2.Visible = true;
                lblSegundoPeso.Visible = true;
                txtPesoN2.Visible = true;
                txtPesoN2.Text = "0";

            }
            else
            {
                lblProducto2.Visible = false;
                cmbProducto2.Visible = false;
                lblSegundoPeso.Visible = false;
                txtPesoN2.Visible = false;
                cmbProducto2.Items.Clear();
                cmbProducto2.Text = "";
                txtPesoN2.Text = "";
            }
        }
        private void PruebaCalculo()
        {
            string value;
            try
            {

                value = txtFactura.Text;

                if (chkDosProductosEstiba.Checked)
                {
                    CalcularPesaje(value, txtPesoN2.Text, chkDosProductosEstiba.Checked);
                }

                else
                {
                    CalcularPesaje(txtFactura.Text);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al leer el puerto: " + ex.Message, "Error de la aplicación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string value;
            try
            {
                SerialPort p = (SerialPort)sender;
                string indata = p.ReadExisting();
                value = indata.Replace(" ", "").Replace("=", "").Replace("-","");

                txtPesoActual.Text = string.Format("{0}-{1}", value, DateTime.Now.ToString("fff"));


                if (chkDosProductosEstiba.Checked)
                {
                    CalcularPesaje(value, txtPesoN2.Text, chkDosProductosEstiba.Checked);
                }

                else
                {
                    CalcularPesaje(value);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al leer el puerto: " + ex.Message, "Error de la aplicación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CalcularPesaje(string PesajeBascula)
        {
            _pesoBruto = 0;
            _pesoNeto = 0;
            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (a != ',')
                PesajeBascula = PesajeBascula.Replace(',', a);

            if (a!='.')
                PesajeBascula = PesajeBascula.Replace('.', a);


            if (decimal.TryParse(PesajeBascula, out _pesoBruto))
            {

                    _pesoNeto = _pesoBruto - _pesoEstiba;
                    txtPesoB.Text = _pesoBruto.ToString();
                    txtPesoN.Text = _pesoNeto.ToString();
            }

            txtPesoB.Text = string.Format("{0:0.##}", _pesoBruto);
            txtPesoN.Text = string.Format("{0:0.##}", _pesoNeto);


        }
        private void CalcularPesaje(string PesajeBascula,string PesoNeto2, bool masDeUnProducto)
        {
            _pesoBruto = 0;
            _pesoNeto = 0;
            _pesoNeto2 = 0;

            _pesoNeto2 = Convert.ToDecimal(PesoNeto2);

            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (a != ',')
                PesajeBascula = PesajeBascula.Replace(',', a);
            if (a != '.')
                PesajeBascula = PesajeBascula.Replace('.', a);

            if (decimal.TryParse(PesajeBascula, out _pesoBruto))
            {
                if (masDeUnProducto)
                {
                    _pesoNeto = _pesoBruto - _pesoNeto2 - _pesoEstiba;
                    txtPesoB.Text = _pesoBruto.ToString();
                    txtPesoN.Text = _pesoNeto.ToString();

                }
                else
                {
                    _pesoNeto = _pesoBruto - _pesoEstiba;
                    txtPesoB.Text = _pesoBruto.ToString();
                    txtPesoN.Text = _pesoNeto.ToString();
                }
            }
            txtPesoB.Text = string.Format("{0:0.##}", _pesoBruto);
            txtPesoN.Text = string.Format("{0:0.##}", _pesoNeto);
            txtPesoN2.Text = string.Format("{0:0.##}", _pesoNeto2);


        }

        private void cmbProveedor_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarCampoRequeridoCadena(cmbProveedor.Text, out errorMsg))
            {
                e.Cancel = true;
                cmbProveedor.Select(0, cmbProveedor.Text.Length);
                this.errorProvider1.SetError(cmbProveedor, errorMsg);
            }
        }



        public bool ValidarCampoRequeridoCadena(string strCadena, out string errorMessage)
        {
            if (strCadena.Trim() == "")
            {
                errorMessage = "Este campo es requerido.\n Seleccione un valor de la lista.";
                return false;
            }

            errorMessage = "Campo válidado";
            return true;
        }

        public bool ValidarCampoRequeridoNumero(string strValor, out string errorMessage)
        {
            
            if (decimal.TryParse(strValor, out _pesoEstiba) == false)
            {
                errorMessage = "Ingrese un valor númerico válido";
                return false;
            }
            if(decimal.TryParse(strValor, out _pesoEstiba) && _pesoEstiba==0 )
            {
                errorMessage = "El peso de la estiba debe ser mayo de zero";
                return false;
            }
            errorMessage = "Campo válidado";
            return true;
        }

        private void cmbProducto_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbProducto, "");
        }

        private void cmbProducto_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarCampoRequeridoCadena(cmbProducto.Text, out errorMsg))
            {
                e.Cancel = true;
                cmbProducto.Select(0, cmbProducto.Text.Length);
                this.errorProvider1.SetError(cmbProducto, errorMsg);
            }
        }

        private void cmbProducto2_Validated(object sender, EventArgs e)
        {
            
                this.errorProvider1.SetError(cmbProducto2, "");
        }

        private void cmbProducto2_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (config.validarSegundoproducto)
            {
                if (!ValidarCampoRequeridoCadena(cmbProducto2.Text, out errorMsg))
                {
                    e.Cancel = true;
                    cmbProducto2.Select(0, cmbProducto2.Text.Length);
                    this.errorProvider1.SetError(cmbProducto2, errorMsg);
                }

            }
        }


        private void txtOtraEstiba_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtOtraEstiba, "");
               
        }

        private void txtOtraEstiba_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if(rbOtro.Checked)
            {
                if (!ValidarCampoRequeridoNumero(txtOtraEstiba.Text, out errorMsg))
                {
                    e.Cancel = true;
                    txtOtraEstiba.Select(0, txtOtraEstiba.Text.Length);
                    this.errorProvider1.SetError(txtOtraEstiba, errorMsg);
                }
                _pesoEstiba = decimal.Parse(txtOtraEstiba.Text);

            }
        }

        private void cmbProveedor_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbProveedor, "");
        }


        private void rbNoEstiba_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoEstiba.Checked)
            {
                _pesoEstiba = 0;
                txtOtraEstiba.Text = "";
                txtOtraEstiba.Enabled = false;

            }
        }

        private void rbMadera_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMadera.Checked)
            {
                _pesoEstiba = decimal.Parse(FormatearDecimal( config.pesoEstibaMadera));
                txtOtraEstiba.Text = "";
                txtOtraEstiba.Enabled = false;
            }
        }

        private void rbPlastico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPlastico.Checked)
            {
                _pesoEstiba = decimal.Parse(FormatearDecimal(config.pesoEstibaPlastica));
                txtOtraEstiba.Text = "";
                txtOtraEstiba.Enabled = false;
            }
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked)
            {
                txtOtraEstiba.Enabled = true;
                txtOtraEstiba.Text = "0";
                txtOtraEstiba.Focus();
                _pesoEstiba = 0;

            }
        }

        private string FormatearDecimal(string valor)
        {
            string stringFormateado=valor;
            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if(valor.IndexOf(a)==-1)
            {
                if (a != '.')
                    stringFormateado = valor.Replace('.', a);
                if (a != ',')
                    stringFormateado = valor.Replace(',', a);
            }
            return stringFormateado;
        }

        private void txtOtraEstiba_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarDecimal((TextBox)sender);
        }
        public static bool ValidarDecimal(TextBox control)
        {
            try
            {
                decimal valor = Convert.ToDecimal(control.Text);
                return true;
            }
            catch (Exception ex)
            {
                //control.Text = "0";
                return false;
            }
        }

        private void txtOtraEstiba_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == a || e.KeyChar==(char)Keys.Enter))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtPesoN2_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (rbOtro.Checked)
            {
                if (!ValidarCampoRequeridoNumero(txtPesoN2.Text, out errorMsg))
                {
                    e.Cancel = true;
                    txtPesoN2.Select(0, txtPesoN2.Text.Length);
                    this.errorProvider1.SetError(txtPesoN2, errorMsg);
                }

            }
        }

        private void txtPesoN2_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtPesoN2, "");
            if (string.IsNullOrWhiteSpace(txtPesoN2.Text))
                _pesoNeto2 = decimal.Parse(txtPesoN2.Text);
        }
        private void RefrescarVariablesPeso()
        {
            _pesoBruto = decimal.Parse(txtPesoB.Text);
            if (rbMadera.Checked)
                _pesoEstiba = decimal.Parse(config.pesoEstibaMadera);
            if (rbPlastico.Checked)
                _pesoEstiba = decimal.Parse(config.pesoEstibaPlastica);
            if (rbNoEstiba.Checked)
                _pesoEstiba = 0;
            if (rbOtro.Checked)
            {
                _pesoEstiba = decimal.Parse(txtOtraEstiba.Text);
            }
            if(chkDosProductosEstiba.Checked)
            {
                _pesoNeto2 = decimal.Parse(txtPesoN2.Text);
                _pesoNeto = decimal.Parse(txtPesoB.Text) - _pesoEstiba - decimal.Parse(txtPesoN2.Text);
            }
            else
            {
                _pesoNeto2 = 0;
                _pesoNeto = _pesoBruto - _pesoEstiba;
            }


                
        }
        private void btnPeso_Click(object sender, EventArgs e)
        {
            tblInvMovProducto registroPeso = new tblInvMovProducto();
            RefrescarVariablesPeso();

                if (_pesoBruto > 0)
                {
                    try
                    {
                        registroPeso.CantidadBruta = _pesoBruto-_pesoNeto2;
                        registroPeso.CantidadNeta = _pesoNeto;
                        registroPeso.CantNetaPendiente = _pesoNeto;
                        registroPeso.Estiba = _pesoEstiba;
                        registroPeso.FacturaProveedor = txtFactura.Text;
                        registroPeso.OrdenCompra = txtOrden.Text;
                        registroPeso.Producto = BuscarProducto(cmbProducto.Text);
                        registroPeso.Proveedor = BuscarNitProveedor(cmbProveedor.Text);
                        registroPeso.Observacion = txtObservacion.Text;
                        registroPeso.Tipo = 'E';
                        registroPeso.Fecha_Hora = DateTime.Now;
                        registroPeso.IdPesaje = registroPeso.Fecha_Hora.ToString("yyMMddhhmmssfff");
                        _dbConn.tblInvMovProducto.InsertOnSubmit(registroPeso);
                        _dbConn.SubmitChanges();
                        lblUltEtiqueta.Text = "";

                        for (int i = 1; i <= config.VecesImprimeEtiqueta; i++)
                        {
                            ImprimirEtiqueta(registroPeso.IdMov);
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar pesaje.\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (chkDosProductosEstiba.Checked)
                    {
                        try
                        {
                            tblInvMovProducto registroPeso2 = new tblInvMovProducto();
                            registroPeso2.CantidadBruta = _pesoNeto2 + _pesoEstiba;
                            registroPeso2.CantidadNeta = _pesoNeto2;
                            registroPeso2.CantNetaPendiente = _pesoNeto2;
                            registroPeso2.Estiba = _pesoEstiba;
                            registroPeso2.FacturaProveedor = txtFactura.Text;
                            registroPeso2.OrdenCompra = txtOrden.Text;
                            registroPeso2.Producto = BuscarProducto(cmbProducto2.Text);
                            registroPeso2.Proveedor = BuscarNitProveedor(cmbProveedor.Text);
                            registroPeso2.Observacion = txtObservacion.Text;
                            registroPeso2.Tipo = 'E';
                            registroPeso2.Fecha_Hora = DateTime.Now;
                            registroPeso2.IdPesaje = registroPeso2.Fecha_Hora.ToString("yyMMddhhmmssfff");
                            _dbConn.tblInvMovProducto.InsertOnSubmit(registroPeso2);
                            _dbConn.SubmitChanges();
                            lblUltEtiqueta.Text = "";

                            for (int i = 1; i <= config.VecesImprimeEtiqueta; i++)
                            {
                                ImprimirEtiqueta(registroPeso2.IdMov);
                            }
                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al registrar peso segundo producto.\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    lblUltEtiqueta.Text = "Ultima etiqueta generada: " + registroPeso.IdPesaje;
                    MessageBox.Show("Registro de producto exitoso.", "Ingreso de materia prima.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            txtPesoN2.Text = "0";
            chkDosProductosEstiba.Checked = false;
            txtPesoB.Text = "0";
            txtPesoN.Text = "0";
            
        }

        private string BuscarNitProveedor(string NombreProveedor)
        {
            string _nit ;
            _nit = Proveedores.Where(x => x.Nombre == NombreProveedor).Select(s => s.Nit).SingleOrDefault();
            if (string.IsNullOrEmpty(_nit))
                _nit = "ND";
            return _nit;
        }
        private string BuscarProducto(string DescripcionProducto)
        {
            string _codigo;
            _codigo = MateriasPrimas.Where(x => x.Descripcion == DescripcionProducto).Select(s => s.Codigo).SingleOrDefault();
            if (string.IsNullOrEmpty(_codigo))
                _codigo = "ND";
            return _codigo;
        }
        private void ImprimirEtiqueta(Int32 IdMov)
        {
            try
            {
                //accion.Text = "generando etiqueta idetiqueta: " + IdMov.ToString();
                Report report1 = new Report();
                report1.Load(Application.StartupPath + @"\" + config.Etiqueta);
                report1.SetParameterValue("IdMov", IdMov);
                report1.Prepare(true);
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings.PrinterName = ObtenerImpresoraPorDefecto();
                System.Drawing.Printing.PrinterSettings pg = new PrinterSettings();
                pg.PrinterName = ObtenerImpresoraPorDefecto();
                report1.PrintPrepared(pg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible imprimir la etiqueta.\n"+ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            PruebaCalculo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serial.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ImprimirEtiqueta(1);
        }
    }


}
