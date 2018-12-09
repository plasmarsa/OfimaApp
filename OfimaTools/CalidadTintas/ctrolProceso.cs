using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dataccess;
namespace CalidadTintas
{
    public partial class ctrolProceso : UserControl
    {
        private OfimaticaDBContext _dbconexion;
        private tblControlCalidadTintas _controlTinta;
        private tblControlCalidadTinteros _detalleTintero;
        public List<clsInsumoTinta> ListaTintas;
        public List<tblControlCalidadTintasStick> ListaStickers;
        public List<PersonalTintas> ListaEmpleados;
        private short _viscosidad = 0;
        private decimal _densidad = 0;
        private decimal _delta = 0;
        string _responsable = "";
        bool loteObligatorio;

        private MVPISO _lote;
        public ctrolProceso()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(groupBox1, 20);


        }
        public ctrolProceso(ref OfimaticaDBContext dbConexion, bool Lote_Obligatorio)
        {
            _dbconexion = dbConexion;
            InitializeComponent();
            CargarListaAniloxes();
            CargarListaStickers();
            //CargarListaEmpleados();
            CargarListaInsumoTintas();
            loteObligatorio = Lote_Obligatorio;
            ListaTintas = _dbconexion.MTMERCIA.Where(x => x.CODLINEA == "0102").Select(s => new clsInsumoTinta { Codigo = string.Format("{0} - {1}", s.CODIGO.TrimEnd(), s.DESCRIPCIO.TrimEnd()), Descripcion = s.CODIGO.TrimEnd() }).ToList();
            CargarListaEmpleadosTintas();
        }
        private void CargarListaEmpleadosTintas()
        {
            ListaEmpleados = _dbconexion.ExecuteQuery<PersonalTintas>("SELECT p.IdPersona as Cedula,ISNULL(e.Nombre_Completo ,p.OtroNombre) AS Nombre, ISNULL(p.OtroNombre,'Roll') AS Roll FROM dbo.tblControlCalidadPersonal p(NOLOCK) LEFT JOIN dbo.vUsrGosem_ghPlasmar_rhRecursos e ON p.IdPersona=e.cod_recurso  ORDER BY ISNULL(e.Nombre_Completo,p.OtroNombre)").ToList();
            cmbResponsable.DataSource = ListaEmpleados;
            cmbResponsable.DisplayMember = "Nombre";
            cmbResponsable.ValueMember = "Cedula";
            cmbResponsable.SelectedIndex = -1;
        }
        private void CargarListaInsumoTintas()
        {
            List<clsInsumoTinta> tintas = _dbconexion.MTMERCIA.Where(x => x.CODLINEA == "0102" && x.HABILITADO == true).Select(x => new clsInsumoTinta() { Codigo = string.Format("{0} - {1}", x.CODIGO.TrimEnd(), x.DESCRIPCIO.TrimEnd()), Descripcion = x.CODIGO }).ToList();
        }
        private void CargarListaAniloxes()
        {
            List<tblControlCalidadTintasAnilox> anilox1 = _dbconexion.tblControlCalidadTintasAnilox.ToList();
            List<tblControlCalidadTintasAnilox> anilox2 = anilox1.ToList();
            List<tblControlCalidadTintasAnilox> anilox3 = anilox1.ToList();
            List<tblControlCalidadTintasAnilox> anilox4 = anilox1.ToList();
            List<tblControlCalidadTintasAnilox> anilox5 = anilox1.ToList();
            List<tblControlCalidadTintasAnilox> anilox6 = anilox1.ToList();
            List<tblControlCalidadTintasAnilox> anilox7 = anilox1.ToList();
            List<tblControlCalidadTintasAnilox> anilox8 = anilox1.ToList();
            cmbAniloxT1.DataSource = anilox1;
            cmbAniloxT1.DisplayMember = "CodAnilox";
            cmbAniloxT1.ValueMember = "Descripcion";
            cmbAniloxT1.SelectedIndex = -1;
            cmbAniloxT2.DataSource = anilox2;
            cmbAniloxT2.DisplayMember = "CodAnilox";
            cmbAniloxT2.ValueMember = "Descripcion";
            cmbAniloxT2.SelectedIndex = -1;
            cmbAniloxT3.DataSource = anilox3;
            cmbAniloxT3.DisplayMember = "CodAnilox";
            cmbAniloxT3.ValueMember = "Descripcion";
            cmbAniloxT3.SelectedIndex = -1;
            cmbAniloxT4.DataSource = anilox4;
            cmbAniloxT4.DisplayMember = "CodAnilox";
            cmbAniloxT4.ValueMember = "Descripcion";
            cmbAniloxT4.SelectedIndex = -1;
            cmbAniloxT5.DataSource = anilox5;
            cmbAniloxT5.DisplayMember = "CodAnilox";
            cmbAniloxT5.ValueMember = "Descripcion";
            cmbAniloxT5.SelectedIndex = -1;
            cmbAniloxT6.DataSource = anilox6;
            cmbAniloxT6.DisplayMember = "CodAnilox";
            cmbAniloxT6.ValueMember = "Descripcion";
            cmbAniloxT6.SelectedIndex = -1;
            cmbAniloxT7.DataSource = anilox7;
            cmbAniloxT7.DisplayMember = "CodAnilox";
            cmbAniloxT7.ValueMember = "Descripcion";
            cmbAniloxT7.SelectedIndex = -1;
            cmbAniloxT8.DataSource = anilox8;
            cmbAniloxT8.DisplayMember = "CodAnilox";
            cmbAniloxT8.ValueMember = "Descripcion";
            cmbAniloxT8.SelectedIndex = -1;
        }
        private void CargarListaStickers()
        {
            List<tblControlCalidadTintasStick> sticker1 = _dbconexion.tblControlCalidadTintasStick.ToList();
            List<tblControlCalidadTintasStick> sticker2 = sticker1.ToList();
            List<tblControlCalidadTintasStick> sticker3 = sticker1.ToList();
            List<tblControlCalidadTintasStick> sticker4 = sticker1.ToList();
            List<tblControlCalidadTintasStick> sticker5 = sticker1.ToList();
            List<tblControlCalidadTintasStick> sticker6 = sticker1.ToList();
            List<tblControlCalidadTintasStick> sticker7 = sticker1.ToList();
            List<tblControlCalidadTintasStick> sticker8 = sticker1.ToList();

            cmbStickT1.DataSource = sticker1;
            cmbStickT1.DisplayMember = "Codstick";
            cmbStickT1.ValueMember = "Descripcion";
            cmbStickT1.SelectedIndex = -1;
            cmbStickT2.DataSource = sticker2;
            cmbStickT2.DisplayMember = "Codstick";
            cmbStickT2.ValueMember = "Descripcion";
            cmbStickT2.SelectedIndex = -1;
            cmbStickT3.DataSource = sticker3;
            cmbStickT3.DisplayMember = "Codstick";
            cmbStickT3.ValueMember = "Descripcion";
            cmbStickT3.SelectedIndex = -1;
            cmbStickT4.DataSource = sticker4;
            cmbStickT4.DisplayMember = "Codstick";
            cmbStickT4.ValueMember = "Descripcion";
            cmbStickT4.SelectedIndex = -1;
            cmbStickT5.DataSource = sticker5;
            cmbStickT5.DisplayMember = "Codstick";
            cmbStickT5.ValueMember = "Descripcion";
            cmbStickT5.SelectedIndex = -1;
            cmbStickT6.DataSource = sticker6;
            cmbStickT6.DisplayMember = "Codstick";
            cmbStickT6.ValueMember = "Descripcion";
            cmbStickT6.SelectedIndex = -1;
            cmbStickT7.DataSource = sticker7;
            cmbStickT7.DisplayMember = "Codstick";
            cmbStickT7.ValueMember = "Descripcion";
            cmbStickT7.SelectedIndex = -1;
            cmbStickT8.DataSource = sticker8;
            cmbStickT8.DisplayMember = "Codstick";
            cmbStickT8.ValueMember = "Descripcion";
            cmbStickT8.SelectedIndex = -1;
        }

        //private void CargarListaEmpleados()
        //{
        //    cmbResponsable.DataSource = _dbconexion.vUsrGosem_ghPlasmar_rhRecursos.OrderBy(x=>x.Nombre_Completo);
        //    cmbResponsable.DisplayMember = "Nombre_Completo";
        //    cmbResponsable.ValueMember = "cod_recurso";
        //    cmbResponsable.SelectedIndex = -1;
        //}
        private void LimpiarControles()
        {
            txtLoteT1.Text = "";
            txtLoteT2.Text = "";
            txtLoteT3.Text = "";
            txtLoteT4.Text = "";
            txtLoteT5.Text = "";
            txtLoteT6.Text = "";
            txtLoteT7.Text = "";
            txtLoteT8.Text = "";
            chkEquinox.Checked = false;
            lblMaquina.Text = "";
            txtViscosidadT1.Text = "";
            txtViscosidadT2.Text = "";
            txtViscosidadT3.Text = "";
            txtViscosidadT4.Text = "";
            txtViscosidadT5.Text = "";
            txtViscosidadT6.Text = "";
            txtViscosidadT7.Text = "";
            txtViscosidadT8.Text = "";
            txtDensidadT1.Text = "";
            txtDensidadT2.Text = "";
            txtDensidadT3.Text = "";
            txtDensidadT4.Text = "";
            txtDensidadT5.Text = "";
            txtDensidadT6.Text = "";
            txtDensidadT7.Text = "";
            txtDensidadT8.Text = "";
            txtDeltaT1.Text = "";
            txtDeltaT2.Text = "";
            txtDeltaT3.Text = "";
            txtDeltaT4.Text = "";
            txtDeltaT5.Text = "";
            txtDeltaT6.Text = "";
            txtDeltaT7.Text = "";
            txtDeltaT8.Text = "";
            txtPedido.Text = "";
            cmbColorT1.Text = "";
            cmbAniloxT1.Text = "";
            cmbStickT1.Text = "";
            lblColort1.Text = "";
            cmbColorT2.Text = "";
            cmbAniloxT2.Text = "";
            cmbStickT2.Text = "";
            lblColort2.Text = "";
            cmbColorT3.Text = "";
            cmbAniloxT3.Text = "";
            cmbStickT3.Text = "";
            lblColort3.Text = "";
            cmbColorT4.Text = "";
            cmbAniloxT4.Text = "";
            cmbStickT4.Text = "";
            lblColort4.Text = "";
            cmbColorT5.Text = "";
            cmbAniloxT5.Text = "";
            cmbStickT5.Text = "";
            lblColort5.Text = "";
            cmbColorT6.Text = "";
            cmbAniloxT6.Text = "";
            cmbStickT6.Text = "";
            lblColort6.Text = "";
            cmbColorT7.Text = "";
            cmbAniloxT7.Text = "";
            cmbStickT7.Text = "";
            lblColort7.Text = "";
            cmbColorT8.Text = "";
            cmbAniloxT8.Text = "";
            cmbStickT8.Text = "";
            lblColort8.Text = "";
            txtComentarios.Text = "";
            cmbResponsable.ResetText();
            cmbResponsable.SelectedIndex = -1;
            lblCliente.Text = "";
            lblMaquina.Text = "";
            errorProvider1.Clear();
            txtPedido.Focus();


        }

        private void txtPedido_Validated(object sender, EventArgs e)
        {
            string _pedido, _cantidad,_nit,_cliente,_descripcion,_undVenta,_codigo, _linea;
            
            this.errorProvider1.SetError(txtPedido, "");

            //Consulta de cantidades programadas de impresion
            _lote = new MVPISO();


            var _query = _dbconexion.TRADE.Join(_dbconexion.MTPROCLI, t => t.NIT, m => m.NIT, 
                (t, m) => new { t.NRODCTO, m.NIT, m.NOMBRE ,t.ORIGEN,t.TIPODCTO}).
                Where(x=>x.NRODCTO==txtPedido.Text.Trim() && x.TIPODCTO=="pd" && x.ORIGEN=="fac").SingleOrDefault();

            _pedido = _query.NRODCTO.Trim();
            _nit = _query.NIT.Trim();
            _cliente = _query.NOMBRE.TrimEnd();

            var _query1 = _dbconexion.MVTRADE.Join(_dbconexion.MTMERCIA, m => m.PRODUCTO, c => c.CODIGO, 
                (m, c) => new { m.NRODCTO,m.ORIGEN,m.TIPODCTO,c.CODIGO, c.DESCRIPCIO, m.CANTORIG, m.CANVENTA,
                    m.CANTIDAD, m.UNDVENTA}).
                    Where(x=> x.NRODCTO==txtPedido.Text.Trim() && x.ORIGEN=="fac" && x.TIPODCTO=="pd").SingleOrDefault();

            _cantidad = string.Format("{0:0.##}", _query1.CANVENTA);
            _descripcion = _query1.DESCRIPCIO.TrimEnd();
            _undVenta = _query1.UNDVENTA.Trim();
            _codigo = _query1.CODIGO.Trim();


            _linea = _dbconexion.ExecuteQuery<string>(string.Format("SELECT l.NOMBRE FROM dbo.MTMERCIA AS M(nolock) INNER JOIN dbo.MTLINEA AS l(nolock) ON l.CODLINEA = M.CODLINEA WHERE M.CODIGO='{0}'", _codigo)).SingleOrDefault();
            lblCliente.Text = "Cliente: " + _cliente;
            lblLinea.Text = _linea.TrimEnd();    

            _lote = _dbconexion.MVPISO.Where(m => m.LOTEOP == txtPedido.Text && m.CODCC == "0202").SingleOrDefault();
            if (_lote != null)
            {
                _cantidad = string.Format("{0:0.##}", _lote.CANTREQUE); 
            }
            else
            {
                _cantidad = _dbconexion.MVTRADE.Where(x => x.ORIGEN == "fac" && x.TIPODCTO == "pd" && x.NRODCTO == _pedido).Select(s => string.Format("{0:0.##}", s.CANTIDAD)).SingleOrDefault();
            }

            //Buscar control en proceso con el pedido actual
            _controlTinta = new tblControlCalidadTintas();
            _controlTinta = _dbconexion.tblControlCalidadTintas.Where(x => x.OrdenNro == _pedido).SingleOrDefault();

            if (_controlTinta == null)
            {
                txtCodigo.Text = _codigo;
                txtDescripcion.Text = _descripcion;
                txtCantidad.Text = string.Format("{0} {1}", _cantidad, _undVenta);
                lblCliente.Text = _cliente;
                CargarDatosCyrel(_pedido);

                tblProgImpresion programacion = new tblProgImpresion();
                programacion = _dbconexion.tblProgImpresion.Where(x => x.OrdenNro == _pedido).SingleOrDefault();
                if (programacion != null)
                {
                    lblMaquina.Text = "Imp " + programacion.Maquina;
                    lblFechaProg.Text = programacion.Fecha.ToString("dd/MM/yyyy");
                }
                else
                {
                    lblMaquina.Text = "ND";
                    lblFechaProg.Text = "ND";

                }
                    

                chkEquinox.Focus();


            }
            else
            {//Control ya esta creado y esta pendiente por aprobar
                if (_controlTinta.Aprobado)
                {
                    MessageBox.Show(string.Format("El control de tintas para el pedido: {0} ya fue aprobado.", _controlTinta.OrdenNro.Trim()), "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarControles();
                    return;
                }

                txtCodigo.Text = _codigo;
                txtDescripcion.Text = _descripcion;
                //txtCantidad.Text = string.Format("{0} {1}", _lote.CANTREQUE.ToString(), _codigo.UNIDADMED.Trim());
                txtCantidad.Text = _controlTinta.Cantidad;
                chkEquinox.Checked = _controlTinta.Equinox;
                lblMaquina.Text = _controlTinta.Impresora;
                txtComentarios.Text = _controlTinta.Comentarios;
                if(lblLinea.Text!= "CAPUCHON")
                {
                    ReevaluarDatosTinteros(_pedido);
                }
                
                CargarDatosTinteros(_controlTinta.OrdenNro);
            }



        }
        private string BuscarColor(string codigo)
        {
            return ListaTintas.Where(x => x.Descripcion == codigo).Select(s => s.Codigo).SingleOrDefault();
        }
        private void CargarDatosTinteros(string Pedido)
        {
            List<tblControlCalidadTinteros> _detalleTinteros = new List<tblControlCalidadTinteros>();
            _detalleTinteros = _dbconexion.tblControlCalidadTinteros.Where(d => d.OrdenNro == Pedido).ToList();
            if (_detalleTinteros == null)
            {
                MessageBox.Show(string.Format("No se encotro informacion de tinteros para el pedido {0}.", _controlTinta.OrdenNro.Trim()), "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Deshabilitar los tintero
            ptintero1.Enabled = false;
            ptintero2.Enabled = false;
            ptintero3.Enabled = false;
            ptintero4.Enabled = false;
            ptintero5.Enabled = false;
            ptintero6.Enabled = false;
            ptintero7.Enabled = false;
            ptintero8.Enabled = false;

            foreach (tblControlCalidadTinteros _detalleTintero in _detalleTinteros)
            {
                if (_detalleTintero.NroTintero == 1)
                {
                    ptintero1.Enabled = true;
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        cmbColorT1.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        cmbColorT1.Text = _detalleTintero.CodInsumo;

                    lblColort1.Text = _detalleTintero.CodInsumo;
                    txtLoteT1.Text = _detalleTintero.Lote_Insumo;
                    cmbStickT1.Text = _detalleTintero.CodStick.ToString();
                    cmbAniloxT1.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT1.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT1.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT1.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 2)
                {
                    ptintero2.Enabled = true;
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        cmbColorT2.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        cmbColorT2.Text = _detalleTintero.CodInsumo;

                    cmbColorT2.Text = _detalleTintero.CodInsumo;
                    lblColort2.Text = _detalleTintero.CodInsumo;
                    txtLoteT2.Text = _detalleTintero.Lote_Insumo;
                    cmbStickT2.Text = _detalleTintero.CodStick.ToString();
                    cmbAniloxT2.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT2.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT2.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT2.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 3)
                {
                    ptintero3.Enabled = true;
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        cmbColorT3.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        cmbColorT3.Text = _detalleTintero.CodInsumo;

                    lblColort3.Text = _detalleTintero.CodInsumo;
                    txtLoteT3.Text = _detalleTintero.Lote_Insumo;
                    cmbStickT3.Text = _detalleTintero.CodStick.ToString();
                    cmbAniloxT3.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT3.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT3.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT3.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 4)
                {
                    ptintero4.Enabled = true;
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        cmbColorT4.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        cmbColorT4.Text = _detalleTintero.CodInsumo;

                    lblColort4.Text = _detalleTintero.CodInsumo;
                    txtLoteT4.Text = _detalleTintero.Lote_Insumo;
                    cmbStickT4.Text = _detalleTintero.CodStick.ToString();
                    cmbAniloxT4.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT4.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT4.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT4.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 5)
                {
                    ptintero5.Enabled = true;
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        cmbColorT5.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        cmbColorT5.Text = _detalleTintero.CodInsumo;

                    lblColort5.Text = _detalleTintero.CodInsumo;
                    txtLoteT5.Text = _detalleTintero.Lote_Insumo;
                    cmbStickT5.Text = _detalleTintero.CodStick.ToString();
                    cmbAniloxT5.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT5.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT5.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT5.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 6)
                {
                    ptintero6.Enabled = true;
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        cmbColorT6.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        cmbColorT6.Text = _detalleTintero.CodInsumo;

                    lblColort6.Text = _detalleTintero.CodInsumo;
                    txtLoteT6.Text = _detalleTintero.Lote_Insumo;
                    cmbStickT6.Text = _detalleTintero.CodStick.ToString();
                    cmbAniloxT6.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT6.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT6.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT6.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 7)
                {
                    ptintero7.Enabled = true;
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        cmbColorT7.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        cmbColorT7.Text = _detalleTintero.CodInsumo;

                    lblColort7.Text = _detalleTintero.CodInsumo;
                    txtLoteT7.Text = _detalleTintero.Lote_Insumo;
                    cmbStickT7.Text = _detalleTintero.CodStick.ToString();
                    cmbAniloxT7.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT7.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT7.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT7.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 8)
                {
                    ptintero8.Enabled = true;
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        cmbColorT8.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        cmbColorT8.Text = _detalleTintero.CodInsumo;

                    lblColort8.Text = _detalleTintero.CodInsumo;
                    txtLoteT8.Text = _detalleTintero.Lote_Insumo;
                    cmbStickT8.Text = _detalleTintero.CodStick.ToString();
                    cmbAniloxT8.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT8.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT8.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT8.Text = _detalleTintero.Delta.ToString();
                }
            }


        }

        public void ReevaluarDatosTinteros(string pedido)
        {
            CYRELESMJ cyrel = new CYRELESMJ();
            List<short> nTinterosEvaluar=new List<short>();
            short ntintero = 0;
            List<tblControlCalidadTinteros> tinterosPedido = _dbconexion.tblControlCalidadTinteros.Where(x => x.OrdenNro == pedido).ToList();
            tblControlCalidadTinteros tintero=null;
            cyrel = _dbconexion.CYRELESMJ.Where(x => x.ORDENNRO == pedido).SingleOrDefault();

            for(short item=1;item<=8;item++)
            {
                ntintero = tinterosPedido.Where(x => x.NroTintero == item).Select(x=>x.NroTintero).SingleOrDefault();
                if(ntintero==0)
                {
                    nTinterosEvaluar.Add(item);
                }
            }

            foreach (short p in nTinterosEvaluar)
            {
                switch (p)
                {
                    case 1:
                        if (!string.IsNullOrWhiteSpace(cyrel.COLOR1))
                        {
                            tintero = new tblControlCalidadTinteros();
                            tintero.CodInsumo = cyrel.COLOR1;
                            tintero.CodStick = cyrel.RSTICK1;
                            tintero.CodAnilox = cyrel.LINEAT1;
                            tintero.NroTintero = 1;
                            tintero.OrdenNro = pedido;
                            tintero.Cantidad = 0;
                            tintero.Lote_Insumo = "";
                        }
                        break;
                    case 2:
                        if (!string.IsNullOrWhiteSpace(cyrel.COLOR2))
                        {
                            tintero = new tblControlCalidadTinteros();
                            tintero.CodInsumo = cyrel.COLOR2;
                            tintero.CodStick = cyrel.RSTICK2;
                            tintero.CodAnilox = cyrel.LINEAT2;
                            tintero.NroTintero = 2;
                            tintero.OrdenNro = pedido;
                            tintero.Cantidad = 0;
                            tintero.Lote_Insumo = "";
                        }
                        break;
                    case 3:
                        if(!string.IsNullOrWhiteSpace( cyrel.COLOR3))
                        {
                            tintero = new tblControlCalidadTinteros();
                            tintero.CodInsumo = cyrel.COLOR3;
                            tintero.CodStick = cyrel.RSTICK3;
                            tintero.CodAnilox = cyrel.LINEAT3;
                            tintero.NroTintero = 3;
                            tintero.OrdenNro = pedido;
                            tintero.Cantidad = 0;
                            tintero.Lote_Insumo = "";
                        }

                        break;
                    case 4:
                        if (!string.IsNullOrWhiteSpace(cyrel.COLOR4))
                        {
                            tintero = new tblControlCalidadTinteros();
                            tintero.CodInsumo = cyrel.COLOR4;
                            tintero.CodStick = cyrel.RSTICK4;
                            tintero.CodAnilox = cyrel.LINEAT4;
                            tintero.NroTintero = 4;
                            tintero.OrdenNro = pedido;
                            tintero.Cantidad = 0;
                            tintero.Lote_Insumo = "";
                        }
                        break;
                    case 5:
                        if (!string.IsNullOrWhiteSpace(cyrel.COLOR5))
                        {
                            tintero = new tblControlCalidadTinteros();
                            tintero.CodInsumo = cyrel.COLOR5;
                            tintero.CodStick = cyrel.RSTICK5;
                            tintero.CodAnilox = cyrel.LINEAT5;
                            tintero.NroTintero = 5;
                            tintero.OrdenNro = pedido;
                            tintero.Cantidad = 0;
                            tintero.Lote_Insumo = "";
                        }
                        break;
                    case 6:
                        if (!string.IsNullOrWhiteSpace(cyrel.COLOR6))
                        {
                            tintero = new tblControlCalidadTinteros();
                            tintero.CodInsumo = cyrel.COLOR6;
                            tintero.CodStick = cyrel.RSTICK6;
                            tintero.CodAnilox = cyrel.LINEAT6;
                            tintero.NroTintero = 6;
                            tintero.OrdenNro = pedido;
                            tintero.Cantidad = 0;
                            tintero.Lote_Insumo = "";
                        }
                        break;
                    case 7:
                        if (!string.IsNullOrWhiteSpace(cyrel.COLOR7))
                        {
                            tintero = new tblControlCalidadTinteros();
                            tintero.CodInsumo = cyrel.COLOR7;
                            tintero.CodStick = cyrel.RSTICK7;
                            tintero.CodAnilox = cyrel.LINEAT7;
                            tintero.NroTintero = 7;
                            tintero.OrdenNro = pedido;
                            tintero.Cantidad = 0;
                            tintero.Lote_Insumo = "";
                        }
                        break;
                    case 8:
                        if (!string.IsNullOrWhiteSpace(cyrel.COLOR8))
                        {
                            tintero = new tblControlCalidadTinteros();
                            tintero.CodInsumo = cyrel.COLOR8;
                            tintero.CodStick = cyrel.RSTICK8;
                            tintero.CodAnilox = cyrel.LINEAT8;
                            tintero.NroTintero = 8;
                            tintero.OrdenNro = pedido;
                            tintero.Cantidad = 0;
                            tintero.Lote_Insumo = "";
                        }
                        break;
                    default:
                        tintero = null;
                        break;
                }
                
                if(tintero != null)
                {
                    _dbconexion.tblControlCalidadTinteros.InsertOnSubmit(tintero);
                    _dbconexion.SubmitChanges();
                }
                    

            }



        }

        private void CargarDatosCyrel(string loteOp)
        {
            //Consulta anilox
            CYRELESMJ cyrel = new CYRELESMJ();
            cyrel = _dbconexion.CYRELESMJ.Where(x => x.ORDENNRO == loteOp).SingleOrDefault();
            if (cyrel == null)
            {
                MessageBox.Show(string.Format("No existe informacion de cyreles para la orden de producción Nro: {0}.", loteOp), "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //determinar # de colores
            if (!string.IsNullOrWhiteSpace(cyrel.COLOR1.Trim()))
            {
                cmbColorT1.Text = cyrel.COLOR1.Trim();
                lblColort1.Text = cyrel.COLOR1.Trim();
                cmbAniloxT1.Text = cyrel.LINEAT1.Trim();
                cmbStickT1.Text = cyrel.RSTICK1.Trim();
                lblColort1.Text = cyrel.COLOR1.Trim();
                txtViscosidadT1.Text = "0";
                txtDensidadT1.Text = "0";
                txtDeltaT1.Text = "0";

            }
            else
                ptintero1.Enabled = false;


            if (!string.IsNullOrWhiteSpace(cyrel.COLOR2.Trim()))
            {
                cmbColorT2.Text = cyrel.COLOR2.Trim();
                lblColort2.Text = cyrel.COLOR2.Trim();
                cmbAniloxT2.Text = cyrel.LINEAT2.Trim();
                cmbStickT2.Text = cyrel.RSTICK2.Trim();
                lblColort2.Text = cyrel.COLOR2.Trim();
                txtViscosidadT2.Text = "0";
                txtDensidadT2.Text = "0";
                txtDeltaT2.Text = "0";
            }
            else
                ptintero2.Enabled = false;
            if (!string.IsNullOrWhiteSpace(cyrel.COLOR3.Trim()))
            {
                cmbColorT3.Text = cyrel.COLOR3.Trim();
                lblColort3.Text = cyrel.COLOR3.Trim();
                cmbAniloxT3.Text = cyrel.LINEAT3.Trim();
                cmbStickT3.Text = cyrel.RSTICK3.Trim();
                lblColort3.Text = cyrel.COLOR3.Trim();
                txtViscosidadT3.Text = "0";
                txtDensidadT3.Text = "0";
                txtDeltaT3.Text = "0";
            }
            else
                ptintero3.Enabled = false;

            if (!string.IsNullOrWhiteSpace(cyrel.COLOR4.Trim()))
            {
                cmbColorT4.Text = cyrel.COLOR4.Trim();
                lblColort4.Text = cyrel.COLOR4.Trim();
                cmbAniloxT4.Text = cyrel.LINEAT4.Trim();
                cmbStickT4.Text = cyrel.RSTICK4.Trim();
                lblColort4.Text = cyrel.COLOR4.Trim();
                txtViscosidadT4.Text = "0";
                txtDensidadT4.Text = "0";
                txtDeltaT4.Text = "0";
            }
            else
                ptintero4.Enabled = false;

            if (!string.IsNullOrWhiteSpace(cyrel.COLOR5.Trim()))
            {
                cmbColorT5.Text = cyrel.COLOR5.Trim();
                lblColort5.Text = cyrel.COLOR5.Trim();
                cmbAniloxT5.Text = cyrel.LINEAT5.Trim();
                cmbStickT5.Text = cyrel.RSTICK5.Trim();
                lblColort5.Text = cyrel.COLOR5.Trim();
                txtViscosidadT5.Text = "0";
                txtDensidadT5.Text = "0";
                txtDeltaT5.Text = "0";
            }
            else
                ptintero5.Enabled = false;

            if (!string.IsNullOrWhiteSpace(cyrel.COLOR6.Trim()))
            {
                cmbColorT6.Text = cyrel.COLOR6.Trim();
                lblColort6.Text = cyrel.COLOR6.Trim();
                cmbAniloxT6.Text = cyrel.LINEAT6.Trim();
                cmbStickT6.Text = cyrel.RSTICK6.Trim();
                lblColort6.Text = cyrel.COLOR6.Trim();
                txtViscosidadT6.Text = "0";
                txtDensidadT6.Text = "0";
                txtDeltaT6.Text = "0";
            }
            else
                ptintero6.Enabled = false;

            if (!string.IsNullOrWhiteSpace(cyrel.COLOR7.Trim()))
            {
                cmbColorT7.Text = cyrel.COLOR7.Trim();
                lblColort7.Text = cyrel.COLOR7.Trim();
                cmbAniloxT7.Text = cyrel.LINEAT7.Trim();
                cmbStickT7.Text = cyrel.RSTICK7.Trim();
                lblColort7.Text = cyrel.COLOR7.Trim();
                txtViscosidadT7.Text = "0";
                txtDensidadT7.Text = "0";
                txtDeltaT7.Text = "0";
            }
            else
                ptintero7.Enabled = false;

            if (!string.IsNullOrWhiteSpace(cyrel.COLOR8.Trim()))
            {
                cmbColorT8.Text = cyrel.COLOR8.Trim();
                lblColort8.Text = cyrel.COLOR8.Trim();
                cmbAniloxT8.Text = cyrel.LINEAT8.Trim();
                cmbStickT8.Text = cyrel.RSTICK8.Trim();
                lblColort8.Text = cyrel.COLOR8.Trim();
                txtViscosidadT8.Text = "0";
                txtDensidadT8.Text = "0";
                txtDeltaT8.Text = "0";
            }
            else
                ptintero8.Enabled = false;
        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = ((e.KeyChar.GetHashCode() >= 48 && e.KeyChar.GetHashCode() <= 57));
            /* if (System.Text.RegularExpressions.Regex.IsMatch(e.Key.ToString(),"[0-9]"))
                e.Handled = false;
            else e.Handled = true;*/

            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == (int)Keys.Tab)
            {
                txtPedido_Validated(null, null);
            }
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.Image = CalidadTintas.Properties.Resources.Save_as_hover_50px;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.Image = CalidadTintas.Properties.Resources.Save_as_50px;
        }

        private void btnAprobar_MouseLeave(object sender, EventArgs e)
        {
            btnAprobar.Image = CalidadTintas.Properties.Resources.Approve_50px;
        }

        private void btnAprobar_MouseHover(object sender, EventArgs e)
        {
            btnAprobar.Image = CalidadTintas.Properties.Resources.Approve_hover_50px;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;


            if (_lote != null)
            {
                if (_controlTinta == null)
                {
                    //Crear nuevo el control
                    Crear_ControlTinta();
                    MessageBox.Show(string.Format("Control de tintas modificado exitosamente."), "Editando Control de Calidad Tinta...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();

                }
                else
                {
                    Modificar_ControlTinta(false);
                    MessageBox.Show(string.Format("Control de tintas modificado exitosamente."), "Editando Control de Calidad Tinta...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }


        private void Crear_ControlTinta()
        {

            _controlTinta = new tblControlCalidadTintas();
            _controlTinta.OrdenNro = _lote.LOTEOP;
            _controlTinta.Fecha_Hora = DateTime.Now;
            _controlTinta.IdResponsable = _responsable;
            _controlTinta.Comentarios = txtComentarios.Text;
            _controlTinta.Aprobado = false;
            _controlTinta.IdResponsable = lblResponsable.Text;
            _controlTinta.Impresora = lblMaquina.Text;
            _controlTinta.Cantidad = txtCantidad.Text;
            _controlTinta.Equinox = chkEquinox.Checked;
            _dbconexion.tblControlCalidadTintas.InsertOnSubmit(_controlTinta);
            _dbconexion.SubmitChanges();

            //agregar datos de tinteros
            if (cmbColorT1.Enabled)
            {
                _detalleTintero = new tblControlCalidadTinteros();
                _detalleTintero.NroTintero = 1;
                _detalleTintero.Lote_Insumo = txtLoteT1.Text;
                _detalleTintero.CodAnilox = cmbAniloxT1.Text;
                _detalleTintero.CodStick = cmbStickT1.Text;
                _detalleTintero.Viscosidad = short.Parse(txtViscosidadT1.Text);
                _detalleTintero.Densidad = decimal.Parse(txtDensidadT1.Text);
                _detalleTintero.Delta = decimal.Parse(txtDeltaT1.Text);
                _detalleTintero.OrdenNro = _controlTinta.OrdenNro;
                _detalleTintero.tblControlCalidadTintas = _controlTinta;
                _detalleTintero.CodInsumo = lblColort1.Text;
                _dbconexion.tblControlCalidadTinteros.InsertOnSubmit(_detalleTintero);
                _dbconexion.SubmitChanges();
            }
            if (cmbColorT2.Enabled)
            {
                _detalleTintero = new tblControlCalidadTinteros();
                _detalleTintero.NroTintero = 2;
                _detalleTintero.Lote_Insumo = txtLoteT2.Text;
                _detalleTintero.CodAnilox = cmbAniloxT2.Text;
                _detalleTintero.CodStick = cmbStickT2.Text;
                _detalleTintero.Viscosidad = short.Parse(txtViscosidadT2.Text);
                _detalleTintero.Densidad = decimal.Parse(txtDensidadT2.Text);
                _detalleTintero.Delta = decimal.Parse(txtDeltaT2.Text);
                _detalleTintero.OrdenNro = _controlTinta.OrdenNro;
                _detalleTintero.tblControlCalidadTintas = _controlTinta;
                _detalleTintero.CodInsumo = lblColort2.Text;
                _dbconexion.tblControlCalidadTinteros.InsertOnSubmit(_detalleTintero);
                _dbconexion.SubmitChanges();
            }

            if (cmbColorT3.Enabled)
            {
                _detalleTintero = new tblControlCalidadTinteros();
                _detalleTintero.NroTintero = 3;
                _detalleTintero.Lote_Insumo = txtLoteT3.Text;
                _detalleTintero.CodAnilox = cmbAniloxT3.Text;
                _detalleTintero.CodStick = cmbStickT3.Text;
                _detalleTintero.Viscosidad = short.Parse(txtViscosidadT3.Text);
                _detalleTintero.Densidad = decimal.Parse(txtDensidadT3.Text);
                _detalleTintero.Delta = decimal.Parse(txtDeltaT3.Text);
                _detalleTintero.OrdenNro = _controlTinta.OrdenNro;
                _detalleTintero.tblControlCalidadTintas = _controlTinta;
                _detalleTintero.CodInsumo = lblColort3.Text;
                _dbconexion.tblControlCalidadTinteros.InsertOnSubmit(_detalleTintero);
                _dbconexion.SubmitChanges();
            }

            if (cmbColorT4.Enabled)
            {
                _detalleTintero = new tblControlCalidadTinteros();
                _detalleTintero.NroTintero = 4;
                _detalleTintero.Lote_Insumo = txtLoteT4.Text;
                _detalleTintero.CodAnilox = cmbAniloxT4.Text;
                _detalleTintero.CodStick = cmbStickT4.Text;
                _detalleTintero.Viscosidad = short.Parse(txtViscosidadT4.Text);
                _detalleTintero.Densidad = decimal.Parse(txtDensidadT4.Text);
                _detalleTintero.Delta = decimal.Parse(txtDeltaT4.Text);
                _detalleTintero.OrdenNro = _controlTinta.OrdenNro;
                _detalleTintero.tblControlCalidadTintas = _controlTinta;
                _detalleTintero.CodInsumo = lblColort4.Text;
                _dbconexion.tblControlCalidadTinteros.InsertOnSubmit(_detalleTintero);
                _dbconexion.SubmitChanges();
            }
            if (cmbColorT5.Enabled)
            {
                _detalleTintero = new tblControlCalidadTinteros();
                _detalleTintero.NroTintero = 5;
                _detalleTintero.Lote_Insumo = txtLoteT5.Text;
                _detalleTintero.CodAnilox = cmbAniloxT5.Text;
                _detalleTintero.CodStick = cmbStickT5.Text;
                _detalleTintero.Viscosidad = short.Parse(txtViscosidadT5.Text);
                _detalleTintero.Densidad = decimal.Parse(txtDensidadT5.Text);
                _detalleTintero.Delta = decimal.Parse(txtDeltaT5.Text);
                _detalleTintero.OrdenNro = _controlTinta.OrdenNro;
                _detalleTintero.tblControlCalidadTintas = _controlTinta;
                _detalleTintero.CodInsumo = lblColort5.Text;
                _dbconexion.tblControlCalidadTinteros.InsertOnSubmit(_detalleTintero);
                _dbconexion.SubmitChanges();
            }
            if (cmbColorT6.Enabled)
            {
                _detalleTintero = new tblControlCalidadTinteros();
                _detalleTintero.NroTintero = 6;
                _detalleTintero.Lote_Insumo = txtLoteT6.Text;
                _detalleTintero.CodAnilox = cmbAniloxT6.Text;
                _detalleTintero.CodStick = cmbStickT6.Text;
                _detalleTintero.Viscosidad = short.Parse(txtViscosidadT6.Text);
                _detalleTintero.Densidad = decimal.Parse(txtDensidadT6.Text);
                _detalleTintero.Delta = decimal.Parse(txtDeltaT6.Text);
                _detalleTintero.OrdenNro = _controlTinta.OrdenNro;
                _detalleTintero.tblControlCalidadTintas = _controlTinta;
                _detalleTintero.CodInsumo = lblColort6.Text;
                _dbconexion.tblControlCalidadTinteros.InsertOnSubmit(_detalleTintero);
                _dbconexion.SubmitChanges();
            }
            if (cmbColorT7.Enabled)
            {
                _detalleTintero = new tblControlCalidadTinteros();
                _detalleTintero.NroTintero = 7;
                _detalleTintero.Lote_Insumo = txtLoteT7.Text;
                _detalleTintero.CodAnilox = cmbAniloxT7.Text;
                _detalleTintero.CodStick = cmbStickT7.Text;
                _detalleTintero.Viscosidad = short.Parse(txtViscosidadT7.Text);
                _detalleTintero.Densidad = decimal.Parse(txtDensidadT7.Text);
                _detalleTintero.Delta = decimal.Parse(txtDeltaT7.Text);
                _detalleTintero.OrdenNro = _controlTinta.OrdenNro;
                _detalleTintero.tblControlCalidadTintas = _controlTinta;
                _detalleTintero.CodInsumo = lblColort7.Text;
                _dbconexion.tblControlCalidadTinteros.InsertOnSubmit(_detalleTintero);
                _dbconexion.SubmitChanges();
            }
            if (cmbColorT8.Enabled)
            {
                _detalleTintero = new tblControlCalidadTinteros();
                _detalleTintero.NroTintero = 8;
                _detalleTintero.Lote_Insumo = txtLoteT8.Text;
                _detalleTintero.CodAnilox = cmbAniloxT8.Text;
                _detalleTintero.CodStick = cmbStickT8.Text;
                _detalleTintero.Viscosidad = short.Parse(txtViscosidadT8.Text);
                _detalleTintero.Densidad = decimal.Parse(txtDensidadT8.Text);
                _detalleTintero.Delta = decimal.Parse(txtDeltaT8.Text);
                _detalleTintero.OrdenNro = _controlTinta.OrdenNro;
                _detalleTintero.tblControlCalidadTintas = _controlTinta;
                _detalleTintero.CodInsumo = lblColort8.Text;
                _dbconexion.tblControlCalidadTinteros.InsertOnSubmit(_detalleTintero);
                _dbconexion.SubmitChanges();
            }

        }
        private void Modificar_ControlTinta(bool Aprobar)
        {
            _controlTinta.Fecha_Hora_Mod = DateTime.Now;
            _controlTinta.Comentarios = txtComentarios.Text;
            _controlTinta.IdResponsable_Mod = lblResponsable.Text;
            _controlTinta.Equinox = chkEquinox.Checked;
            
            if (Aprobar)
                _controlTinta.Aprobado = Aprobar;

            _dbconexion.SubmitChanges();

            //adicionar datos de tinteros
            List<tblControlCalidadTinteros> tinteros = new List<tblControlCalidadTinteros>();
            tinteros = _dbconexion.tblControlCalidadTinteros.Where(x => x.OrdenNro == _controlTinta.OrdenNro).ToList();

            foreach (tblControlCalidadTinteros tintero in tinteros)
            {
                if (tintero.NroTintero == 1)
                {
                    tintero.Lote_Insumo = txtLoteT1.Text;
                    tintero.CodInsumo = lblColort1.Text;
                    tintero.CodAnilox = cmbAniloxT1.Text;
                    tintero.CodStick = cmbStickT1.Text;
                    _dbconexion.SubmitChanges();
                }
                if (tintero.NroTintero == 2)
                {
                    tintero.Lote_Insumo = txtLoteT2.Text;
                    tintero.CodInsumo = lblColort2.Text;
                    tintero.CodAnilox = cmbAniloxT2.Text;
                    tintero.CodStick = cmbStickT2.Text;
                    _dbconexion.SubmitChanges();
                }
                if (tintero.NroTintero == 3)
                {
                    tintero.Lote_Insumo = txtLoteT3.Text;
                    tintero.CodInsumo = lblColort3.Text;
                    tintero.CodAnilox = cmbAniloxT3.Text;
                    tintero.CodStick = cmbStickT3.Text;
                    _dbconexion.SubmitChanges();
                }
                if (tintero.NroTintero == 4)
                {
                    tintero.Lote_Insumo = txtLoteT4.Text;
                    tintero.CodInsumo = lblColort4.Text;
                    tintero.CodAnilox = cmbAniloxT4.Text;
                    tintero.CodStick = cmbStickT4.Text;
                    _dbconexion.SubmitChanges();
                }
                if (tintero.NroTintero == 5)
                {
                    tintero.Lote_Insumo = txtLoteT5.Text;
                    tintero.CodInsumo = lblColort5.Text;
                    tintero.CodAnilox = cmbAniloxT5.Text;
                    tintero.CodStick = cmbStickT5.Text;
                    _dbconexion.SubmitChanges();
                }
                if (tintero.NroTintero == 6)
                {
                    tintero.Lote_Insumo = txtLoteT6.Text;
                    tintero.CodInsumo = lblColort6.Text;
                    tintero.CodAnilox = cmbAniloxT6.Text;
                    tintero.CodStick = cmbStickT6.Text;
                    _dbconexion.SubmitChanges();
                }
                if (tintero.NroTintero == 7)
                {
                    tintero.Lote_Insumo = txtLoteT7.Text;
                    tintero.CodInsumo = lblColort7.Text;
                    tintero.CodAnilox = cmbAniloxT7.Text;
                    tintero.CodStick = cmbStickT7.Text;
                    _dbconexion.SubmitChanges();
                }
                if (tintero.NroTintero == 8)
                {
                    tintero.Lote_Insumo = txtLoteT8.Text;
                    tintero.CodInsumo = lblColort8.Text;
                    tintero.CodAnilox = cmbAniloxT8.Text;
                    tintero.CodStick = cmbStickT8.Text;
                    _dbconexion.SubmitChanges();
                }
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            if (_controlTinta != null)
            {
                //Crear nuevo el control
                Modificar_ControlTinta(true);
                LimpiarControles();

            }
            else
            {
                Crear_ControlTinta();
                Modificar_ControlTinta(true);
                LimpiarControles();
            }
        }

        private void cmbResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool ValidarColor(string strColor, out string errorMessage, bool Estado_Tintero)
        {
            if (strColor.Trim() == "" && Estado_Tintero)
            {
                errorMessage = "Debe definir el color.";
                return false;
            }

            errorMessage = "color correcto";
            return true;
        }
        public bool ValidarLote(string strLote, out string errorMessage, bool Estado_Tintero)
        {
            if (strLote.Trim() == "" && Estado_Tintero)
            {
                errorMessage = "Debe definir un lote de la tinta usada.";
                return false;
            }

            errorMessage = "lote correcto";
            return true;
        }
        public bool ValidarPedido(string strPedido, out string errorMessage)
        {
            if (strPedido.Trim() == "")
            {
                errorMessage = "Se requiere definir el pedido";
                return false;
            }

            errorMessage = "Pedido correcto";
            return true;
        }
        public bool ValidarDensidad(string strDensidad, out string errorMessage)
        {
            if (strDensidad.Trim() == "")
            {
                errorMessage = "La densidad es requerida.";
                return false;
            }
            if (chkEquinox.Checked && (strDensidad == ""))
            {
                errorMessage = "Debe definir un valor de densidad válido.";
                return false;
            }
            if (decimal.TryParse(strDensidad, out _densidad) == false)
            {
                errorMessage = "La densidad debe ser un valor decimal. \n Por ejemplo 8.9 ó 8.0";
                return false;
            }
            if (decimal.TryParse(strDensidad, out _densidad) && _densidad > 10m)
            {
                errorMessage = "La densidad debe ser entre 0 y 10.";
                return false;
            }

            errorMessage = "Valor de densidad correcto.";
            //txtDelta.Focus();
            return true;
        }

        public bool ValidarDelta(string strDelta, out string errorMessage)
        {
            if (strDelta.Trim() == "")
            {
                errorMessage = "El valor delta es requerido.";
                return false;
            }
            if (decimal.TryParse(strDelta, out _delta) == false)
            {
                errorMessage = "El delta debe ser un valor decimal. \n Por ejemplo 15.9 ó 25.0";
                return false;
            }

            if (decimal.TryParse(strDelta, out _delta) && _delta > 30m)
            {
                errorMessage = "El valor delta no debe ser mayor a 30.";
                return false;
            }

            errorMessage = "Valor de delta correcto.";
            return true;
        }


        public bool ValidarViscosidad(string strViscosidad, out string errorMessage)
        {
            if (strViscosidad.Trim() == "")
            {
                errorMessage = "La viscosidad es requerida.";
                return false;
            }
            if (chkEquinox.Checked && (strViscosidad == ""))
            {
                errorMessage = "Debe definir un valor de viscosidad válido.";
                return false;
            }
            if (short.TryParse(strViscosidad, out _viscosidad) == false)
            {
                errorMessage = "La viscosidad debe ser un valor entero. \n Por ejemplo 8";
                return false;
            }
            if (short.TryParse(strViscosidad, out _viscosidad) && _viscosidad < 15 || _viscosidad > 40)
            {
                errorMessage = "El valor de la viscosidad debe definirse entre 15 y 40.";
                return false;
            }

            errorMessage = "Valor de viscosidad correcto.";
            //txtDensidad.Focus();
            return true;

        }
        private void ResetearErroresValidacion(object sender, EventArgs e)
        {
            errorProvider1.Clear();

        }
        private void txtDelta_Validated(object sender, EventArgs e)
        {
            //this.errorProvider1.SetError(txtDelta, "");
        }

        public bool ValidarResponsable(string strResponsable, out string errorMessage)
        {
            if (strResponsable.Trim() == "")
            {
                errorMessage = "Debe asignar un responsable.";
                return false;
            }

            errorMessage = "El responsable es válido";
            return true;
        }

        private void cmbResponsable_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarResponsable(cmbResponsable.Text, out errorMsg))
            {
                e.Cancel = true;
                cmbResponsable.Select(0, cmbResponsable.Text.Length);
                this.errorProvider1.SetError(cmbResponsable, errorMsg);
            }
        }

        private void cmbResponsable_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbResponsable, "");

        }

        private void cmbColorT2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorT2.Text != "")
                lblColort2.Text = cmbColorT2.SelectedValue.ToString();
            else
                lblColort2.Text = "";
        }

        private void cmbColorT3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorT3.Text != "")
                lblColort3.Text = cmbColorT3.SelectedValue.ToString();
            else
                lblColort3.Text = "";
        }

        private void cmbColorT4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorT4.Text != "")
                lblColort4.Text = cmbColorT4.SelectedValue.ToString();
            else
                lblColort4.Text = "";
        }

        private void cmbColorT5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorT5.Text != "")
                lblColort5.Text = cmbColorT5.SelectedValue.ToString();
            else
                lblColort5.Text = "";
        }

        private void cmbColorT6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorT6.Text != "")
                lblColort6.Text = cmbColorT6.SelectedValue.ToString();
            else
                lblColort6.Text = "";
        }

        private void cmbColorT7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorT7.Text != "")
                lblColort7.Text = cmbColorT7.SelectedValue.ToString();
            else
                lblColort7.Text = "";
        }

        private void cmbColorT8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorT8.Text != "")
                lblColort8.Text = cmbColorT8.SelectedValue.ToString();
            else
                lblColort8.Text = "";
        }

        private void cmbColorT1_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbColorT1.Text;
            List<clsInsumoTinta> filteredItems = ListaTintas.Where(x => x.Codigo.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbColorT1.DataSource = null;
            cmbColorT1.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbColorT1.DataSource = ListaTintas;
            }
            Cursor.Current = Cursors.Default;
            cmbColorT1.ItemHeight = 100;
            cmbColorT1.DisplayMember = "Codigo";
            cmbColorT1.ValueMember = "Descripcion";
            cmbColorT1.MaxDropDownItems = 8;
            cmbColorT1.SelectedIndex = -1;
            cmbColorT1.DroppedDown = true;
            cmbColorT1.Text = filter_param;
            cmbColorT1.SelectionLength = filter_param.Length;
            cmbColorT1.Select(filter_param.Length, 0);
        }

        private void cmbColorT2_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbColorT2.Text;
            List<clsInsumoTinta> filteredItems = ListaTintas.Where(x => x.Codigo.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbColorT2.DataSource = null;
            cmbColorT2.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbColorT2.DataSource = ListaTintas;
            }
            Cursor.Current = Cursors.Default;
            cmbColorT2.ItemHeight = 100;
            cmbColorT2.DisplayMember = "Codigo";
            cmbColorT2.ValueMember = "Descripcion";
            cmbColorT2.MaxDropDownItems = 8;
            cmbColorT2.SelectedIndex = -1;
            cmbColorT2.DroppedDown = true;
            cmbColorT2.Text = filter_param;
            cmbColorT2.SelectionLength = filter_param.Length;
            cmbColorT2.Select(filter_param.Length, 0);
        }

        private void cmbColorT3_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbColorT3.Text;
            List<clsInsumoTinta> filteredItems = ListaTintas.Where(x => x.Codigo.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbColorT3.DataSource = null;
            cmbColorT3.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbColorT3.DataSource = ListaTintas;
            }
            Cursor.Current = Cursors.Default;
            cmbColorT3.ItemHeight = 100;
            cmbColorT3.DisplayMember = "Codigo";
            cmbColorT3.ValueMember = "Descripcion";
            cmbColorT3.MaxDropDownItems = 8;
            cmbColorT3.SelectedIndex = -1;
            cmbColorT3.DroppedDown = true;
            cmbColorT3.Text = filter_param;
            cmbColorT3.SelectionLength = filter_param.Length;
            cmbColorT3.Select(filter_param.Length, 0);
        }

        private void cmbColorT4_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbColorT4.Text;
            List<clsInsumoTinta> filteredItems = ListaTintas.Where(x => x.Codigo.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbColorT4.DataSource = null;
            cmbColorT4.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbColorT4.DataSource = ListaTintas;
            }
            Cursor.Current = Cursors.Default;
            cmbColorT4.ItemHeight = 100;
            cmbColorT4.DisplayMember = "Codigo";
            cmbColorT4.ValueMember = "Descripcion";
            cmbColorT4.MaxDropDownItems = 8;
            cmbColorT4.SelectedIndex = -1;
            cmbColorT4.DroppedDown = true;
            cmbColorT4.Text = filter_param;
            cmbColorT4.SelectionLength = filter_param.Length;
            cmbColorT4.Select(filter_param.Length, 0);
        }

        private void cmbColorT5_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbColorT5.Text;
            List<clsInsumoTinta> filteredItems = ListaTintas.Where(x => x.Codigo.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbColorT5.DataSource = null;
            cmbColorT5.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbColorT5.DataSource = ListaTintas;
            }
            Cursor.Current = Cursors.Default;
            cmbColorT5.ItemHeight = 100;
            cmbColorT5.DisplayMember = "Codigo";
            cmbColorT5.ValueMember = "Descripcion";
            cmbColorT5.MaxDropDownItems = 8;
            cmbColorT5.SelectedIndex = -1;
            cmbColorT5.DroppedDown = true;
            cmbColorT5.Text = filter_param;
            cmbColorT5.SelectionLength = filter_param.Length;
            cmbColorT5.Select(filter_param.Length, 0);
        }

        private void cmbColorT6_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbColorT6.Text;
            List<clsInsumoTinta> filteredItems = ListaTintas.Where(x => x.Codigo.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbColorT6.DataSource = null;
            cmbColorT6.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbColorT6.DataSource = ListaTintas;
            }
            Cursor.Current = Cursors.Default;
            cmbColorT6.ItemHeight = 100;
            cmbColorT6.DisplayMember = "Codigo";
            cmbColorT6.ValueMember = "Descripcion";
            cmbColorT6.MaxDropDownItems = 8;
            cmbColorT6.SelectedIndex = -1;
            cmbColorT6.DroppedDown = true;
            cmbColorT6.Text = filter_param;
            cmbColorT6.SelectionLength = filter_param.Length;
            cmbColorT6.Select(filter_param.Length, 0);
        }

        private void cmbColorT7_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbColorT7.Text;
            List<clsInsumoTinta> filteredItems = ListaTintas.Where(x => x.Codigo.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbColorT7.DataSource = null;
            cmbColorT7.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbColorT7.DataSource = ListaTintas;
            }
            Cursor.Current = Cursors.Default;
            cmbColorT7.ItemHeight = 100;
            cmbColorT7.DisplayMember = "Codigo";
            cmbColorT7.ValueMember = "Descripcion";
            cmbColorT7.MaxDropDownItems = 8;
            cmbColorT7.SelectedIndex = -1;
            cmbColorT7.DroppedDown = true;
            cmbColorT7.Text = filter_param;
            cmbColorT7.SelectionLength = filter_param.Length;
            cmbColorT7.Select(filter_param.Length, 0);
        }

        private void cmbColorT8_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbColorT8.Text;
            List<clsInsumoTinta> filteredItems = ListaTintas.Where(x => x.Codigo.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbColorT8.DataSource = null;
            cmbColorT8.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbColorT8.DataSource = ListaTintas;
            }
            Cursor.Current = Cursors.Default;
            cmbColorT8.ItemHeight = 100;
            cmbColorT8.DisplayMember = "Codigo";
            cmbColorT8.ValueMember = "Descripcion";
            cmbColorT8.MaxDropDownItems = 8;
            cmbColorT8.SelectedIndex = -1;
            cmbColorT8.DroppedDown = true;
            cmbColorT8.Text = filter_param;
            cmbColorT8.SelectionLength = filter_param.Length;
            cmbColorT8.Select(filter_param.Length, 0);
        }

        private void cmbColorT1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorT1.Text != "")
                lblColort1.Text = cmbColorT1.SelectedValue.ToString();
            else
                lblColort1.Text = "";
        }
        private void txtViscosidadT1_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarViscosidad(txtViscosidadT1.Text, out errorMsg))
            {
                e.Cancel = true;
                txtViscosidadT1.Select(0, txtViscosidadT1.Text.Length);
                this.errorProvider1.SetError(txtViscosidadT1, errorMsg);
            }
        }

        private void txtViscosidadT2_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarViscosidad(txtViscosidadT2.Text, out errorMsg))
            {
                e.Cancel = true;
                txtViscosidadT1.Select(0, txtViscosidadT2.Text.Length);
                this.errorProvider1.SetError(txtViscosidadT2, errorMsg);
            }
        }

        private void txtViscosidadT3_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarViscosidad(txtViscosidadT3.Text, out errorMsg))
            {
                e.Cancel = true;
                txtViscosidadT3.Select(0, txtViscosidadT3.Text.Length);
                this.errorProvider1.SetError(txtViscosidadT3, errorMsg);
            }
        }

        private void txtViscosidadT4_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarViscosidad(txtViscosidadT4.Text, out errorMsg))
            {
                e.Cancel = true;
                txtViscosidadT4.Select(0, txtViscosidadT4.Text.Length);
                this.errorProvider1.SetError(txtViscosidadT4, errorMsg);
            }
        }

        private void txtViscosidadT5_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarViscosidad(txtViscosidadT5.Text, out errorMsg))
            {
                e.Cancel = true;
                txtViscosidadT5.Select(0, txtViscosidadT5.Text.Length);
                this.errorProvider1.SetError(txtViscosidadT5, errorMsg);
            }
        }

        private void txtViscosidadT6_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarViscosidad(txtViscosidadT6.Text, out errorMsg))
            {
                e.Cancel = true;
                txtViscosidadT6.Select(0, txtViscosidadT6.Text.Length);
                this.errorProvider1.SetError(txtViscosidadT6, errorMsg);
            }
        }

        private void txtViscosidadT7_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarViscosidad(txtViscosidadT7.Text, out errorMsg))
            {
                e.Cancel = true;
                txtViscosidadT7.Select(0, txtViscosidadT7.Text.Length);
                this.errorProvider1.SetError(txtViscosidadT7, errorMsg);
            }
        }

        private void txtViscosidadT8_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarViscosidad(txtViscosidadT8.Text, out errorMsg))
            {
                e.Cancel = true;
                txtViscosidadT8.Select(0, txtViscosidadT8.Text.Length);
                this.errorProvider1.SetError(txtViscosidadT8, errorMsg);
            }
        }

        private void txtDensidadT1_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDensidad(txtDensidadT1.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDensidadT1.Select(0, txtDensidadT1.Text.Length);
                this.errorProvider1.SetError(txtDensidadT1, errorMsg);
            }
        }

        private void txtDensidadT2_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDensidad(txtDensidadT2.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDensidadT2.Select(0, txtDensidadT2.Text.Length);
                this.errorProvider1.SetError(txtDensidadT2, errorMsg);
            }
        }

        private void txtDensidadT3_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDensidad(txtDensidadT3.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDensidadT3.Select(0, txtDensidadT3.Text.Length);
                this.errorProvider1.SetError(txtDensidadT3, errorMsg);
            }
        }

        private void txtDensidadT4_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDensidad(txtDensidadT4.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDensidadT4.Select(0, txtDensidadT4.Text.Length);
                this.errorProvider1.SetError(txtDensidadT4, errorMsg);
            }
        }

        private void txtDensidadT5_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDensidad(txtDensidadT5.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDensidadT5.Select(0, txtDensidadT5.Text.Length);
                this.errorProvider1.SetError(txtDensidadT5, errorMsg);
            }
        }

        private void txtDensidadT6_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDensidad(txtDensidadT6.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDensidadT6.Select(0, txtDensidadT6.Text.Length);
                this.errorProvider1.SetError(txtDensidadT6, errorMsg);
            }
        }

        private void txtDensidadT7_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDensidad(txtDensidadT7.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDensidadT7.Select(0, txtDensidadT7.Text.Length);
                this.errorProvider1.SetError(txtDensidadT7, errorMsg);
            }
        }

        private void txtDensidadT8_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDensidad(txtDensidadT8.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDensidadT8.Select(0, txtDensidadT8.Text.Length);
                this.errorProvider1.SetError(txtDensidadT8, errorMsg);
            }
        }

        private void txtDeltaT1_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDelta(txtDeltaT1.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDeltaT1.Select(0, txtDeltaT1.Text.Length);
                this.errorProvider1.SetError(txtDeltaT1, errorMsg);
            }
        }

        private void txtDeltaT2_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDelta(txtDeltaT2.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDeltaT2.Select(0, txtDeltaT2.Text.Length);
                this.errorProvider1.SetError(txtDeltaT2, errorMsg);
            }

        }

        private void txtDeltaT3_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDelta(txtDeltaT3.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDeltaT3.Select(0, txtDeltaT3.Text.Length);
                this.errorProvider1.SetError(txtDeltaT3, errorMsg);
            }

        }

        private void txtDeltaT4_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDelta(txtDeltaT4.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDeltaT4.Select(0, txtDeltaT4.Text.Length);
                this.errorProvider1.SetError(txtDeltaT4, errorMsg);
            }

        }

        private void txtDeltaT5_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDelta(txtDeltaT5.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDeltaT5.Select(0, txtDeltaT5.Text.Length);
                this.errorProvider1.SetError(txtDeltaT5, errorMsg);
            }

        }

        private void txtDeltaT6_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDelta(txtDeltaT6.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDeltaT6.Select(0, txtDeltaT6.Text.Length);
                this.errorProvider1.SetError(txtDeltaT6, errorMsg);
            }

        }

        private void txtDeltaT7_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDelta(txtDeltaT7.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDeltaT7.Select(0, txtDeltaT7.Text.Length);
                this.errorProvider1.SetError(txtDeltaT7, errorMsg);
            }

        }

        private void txtDeltaT8_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarDelta(txtDeltaT8.Text, out errorMsg))
            {
                e.Cancel = true;
                txtDeltaT8.Select(0, txtDeltaT8.Text.Length);
                this.errorProvider1.SetError(txtDeltaT8, errorMsg);
            }

        }

        private void txtDensidadT1_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtDensidadT1, "");
        }

        private void txtDensidadT2_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtDensidadT2, "");
        }

        private void txtDensidadT3_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtDensidadT3, "");
        }

        private void txtDensidadT4_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtDensidadT4, "");
        }

        private void txtDensidadT5_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtDensidadT5, "");
        }

        private void txtDensidadT6_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtDensidadT6, "");
        }

        private void txtDensidadT7_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtDensidadT7, "");
        }

        private void txtDensidadT8_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtDensidadT8, "");
        }

        private bool ValidarFormulario()
        {
            string error;
            CancelEventArgs _e = new CancelEventArgs();
            _e.Cancel = false;

            if (!ValidarPedido(txtPedido.Text, out error))
            {
                txtPedido.Focus();
                txtPedido_Validating(txtPedido, _e);
                return false;
            }

            if (!ValidarResponsable(cmbResponsable.Text, out error))
            {
                cmbResponsable.Focus();
                cmbResponsable_Validating(cmbResponsable, _e);
                return false;
            }

            if (ptintero1.Enabled)
            {
                if (!ValidarColor(cmbColorT1.Text, out error, ptintero1.Enabled))
                {
                    _e.Cancel = false;
                    cmbColorT1.Focus();
                    cmbColorT1_Validating(cmbColorT1, _e);
                    return false;
                }

                if (!ValidarViscosidad(txtViscosidadT1.Text, out error))
                {
                    _e.Cancel = false;
                    txtViscosidadT1.Focus();
                    txtViscosidadT1_Validating(txtViscosidadT1, _e);
                    return false;
                }
                if (!ValidarDensidad(txtDensidadT1.Text, out error))
                {
                    _e.Cancel = false;
                    txtDensidadT1.Focus();
                    txtDensidadT1_Validating(txtDensidadT1, _e);
                    return false;
                }
                if (!ValidarDelta(txtDeltaT1.Text, out error))
                {
                    _e.Cancel = false;
                    txtDeltaT1.Focus();
                    txtDeltaT1_Validating(txtDeltaT1, _e);
                    return false;
                }
                if(!ValidarLote(txtLoteT1.Text,out error,ptintero1.Enabled))
                {
                    _e.Cancel = false;
                    txtLoteT1.Focus();
                    txtLoteT1_Validating(txtLoteT1, _e);
                    return false;
                }

            }
            if (ptintero2.Enabled)
            {
                if (!ValidarColor(cmbColorT2.Text, out error, ptintero2.Enabled))
                {
                    _e.Cancel = false;
                    cmbColorT2.Focus();
                    cmbColorT2_Validating(cmbColorT2, _e);
                    return false;
                }

                if (!ValidarViscosidad(txtViscosidadT2.Text, out error))
                {
                    _e.Cancel = false;
                    txtViscosidadT2.Focus();
                    txtViscosidadT2_Validating(txtViscosidadT2, _e);
                    return false;
                }
                if (!ValidarDensidad(txtDensidadT2.Text, out error))
                {
                    _e.Cancel = false;
                    txtDensidadT2.Focus();
                    txtDensidadT2_Validating(txtDensidadT2, _e);
                    return false;
                }
                if (!ValidarDelta(txtDeltaT2.Text, out error))
                {
                    _e.Cancel = false;
                    txtDeltaT2.Focus();
                    txtDeltaT2_Validating(txtDeltaT2, _e);
                    return false;
                }
                if (!ValidarLote(txtLoteT2.Text, out error, ptintero2.Enabled))
                {
                    _e.Cancel = false;
                    txtLoteT2.Focus();
                    txtLoteT2_Validating(txtLoteT2, _e);
                    return false;
                }
            }
            if (ptintero3.Enabled)
            {
                if (!ValidarColor(cmbColorT3.Text, out error, ptintero3.Enabled))
                {
                    _e.Cancel = false;
                    cmbColorT3.Focus();
                    cmbColorT3_Validating(cmbColorT3, _e);
                    return false;
                }

                if (!ValidarViscosidad(txtViscosidadT3.Text, out error))
                {
                    _e.Cancel = false;
                    txtViscosidadT3.Focus();
                    txtViscosidadT3_Validating(txtViscosidadT3, _e);
                    return false;
                }
                if (!ValidarDensidad(txtDensidadT3.Text, out error))
                {
                    _e.Cancel = false;
                    txtDensidadT3.Focus();
                    txtDensidadT3_Validating(txtDensidadT3, _e);
                    return false;
                }
                if (!ValidarDelta(txtDeltaT3.Text, out error))
                {
                    _e.Cancel = false;
                    txtDeltaT3.Focus();
                    txtDeltaT3_Validating(txtDeltaT3, _e);
                    return false;
                }
                if (!ValidarLote(txtLoteT3.Text, out error, ptintero3.Enabled))
                {
                    _e.Cancel = false;
                    txtLoteT3.Focus();
                    txtLoteT3_Validating(txtLoteT3, _e);
                    return false;
                }
            }
            if (ptintero4.Enabled)
            {
                if (!ValidarColor(cmbColorT4.Text, out error, ptintero4.Enabled))
                {
                    _e.Cancel = false;
                    cmbColorT4.Focus();
                    cmbColorT4_Validating(cmbColorT4, _e);
                    return false;
                }

                if (!ValidarViscosidad(txtViscosidadT4.Text, out error))
                {
                    _e.Cancel = false;
                    txtViscosidadT4.Focus();
                    txtViscosidadT4_Validating(txtViscosidadT4, _e);
                    return false;
                }
                if (!ValidarDensidad(txtDensidadT4.Text, out error))
                {
                    _e.Cancel = false;
                    txtDensidadT4.Focus();
                    txtDensidadT4_Validating(txtDensidadT4, _e);
                    return false;
                }
                if (!ValidarDelta(txtDeltaT4.Text, out error))
                {
                    _e.Cancel = false;
                    txtDeltaT4.Focus();
                    txtDeltaT4_Validating(txtDeltaT4, _e);
                    return false;
                }
                if (!ValidarLote(txtLoteT4.Text, out error, ptintero4.Enabled))
                {
                    _e.Cancel = false;
                    txtLoteT4.Focus();
                    txtLoteT4_Validating(txtLoteT4, _e);
                    return false;
                }
            }
            if (ptintero5.Enabled)
            {
                if (!ValidarColor(cmbColorT5.Text, out error, ptintero5.Enabled))
                {
                    _e.Cancel = false;
                    cmbColorT5.Focus();
                    cmbColorT5_Validating(cmbColorT5, _e);
                    return false;
                }

                if (!ValidarViscosidad(txtViscosidadT5.Text, out error))
                {
                    _e.Cancel = false;
                    txtViscosidadT5.Focus();
                    txtViscosidadT5_Validating(txtViscosidadT5, _e);
                    return false;
                }
                if (!ValidarDensidad(txtDensidadT5.Text, out error))
                {
                    _e.Cancel = false;
                    txtDensidadT5.Focus();
                    txtDensidadT5_Validating(txtDensidadT5, _e);
                    return false;
                }
                if (!ValidarDelta(txtDeltaT5.Text, out error))
                {
                    _e.Cancel = false;
                    txtDeltaT5.Focus();
                    txtDeltaT5_Validating(txtDeltaT5, _e);
                    return false;
                }
                if (!ValidarLote(txtLoteT5.Text, out error, ptintero5.Enabled))
                {
                    _e.Cancel = false;
                    txtLoteT5.Focus();
                    txtLoteT5_Validating(txtLoteT5, _e);
                    return false;
                }
            }
            if (ptintero6.Enabled)
            {
                if (!ValidarColor(cmbColorT6.Text, out error, ptintero6.Enabled))
                {
                    _e.Cancel = false;
                    cmbColorT6.Focus();
                    cmbColorT6_Validating(cmbColorT6, _e);
                    return false;
                }

                if (!ValidarViscosidad(txtViscosidadT6.Text, out error))
                {
                    _e.Cancel = false;
                    txtViscosidadT6.Focus();
                    txtViscosidadT6_Validating(txtViscosidadT6, _e);
                    return false;
                }
                if (!ValidarDensidad(txtDensidadT6.Text, out error))
                {
                    _e.Cancel = false;
                    txtDensidadT6.Focus();
                    txtDensidadT6_Validating(txtDensidadT6, _e);
                    return false;
                }
                if (!ValidarDelta(txtDeltaT6.Text, out error))
                {
                    _e.Cancel = false;
                    txtDeltaT6.Focus();
                    txtDeltaT6_Validating(txtDeltaT6, _e);
                    return false;
                }
                if (!ValidarLote(txtLoteT6.Text, out error, ptintero6.Enabled))
                {
                    _e.Cancel = false;
                    txtLoteT6.Focus();
                    txtLoteT6_Validating(txtLoteT6, _e);
                    return false;
                }
            }
            if (ptintero7.Enabled)
            {
                if (!ValidarColor(cmbColorT7.Text, out error, ptintero7.Enabled))
                {
                    _e.Cancel = false;
                    cmbColorT7.Focus();
                    cmbColorT7_Validating(cmbColorT7, _e);
                    return false;
                }

                if (!ValidarViscosidad(txtViscosidadT7.Text, out error))
                {
                    _e.Cancel = false;
                    txtViscosidadT7.Focus();
                    txtViscosidadT7_Validating(txtViscosidadT7, _e);
                    return false;
                }
                if (!ValidarDensidad(txtDensidadT7.Text, out error))
                {
                    _e.Cancel = false;
                    txtDensidadT7.Focus();
                    txtDensidadT7_Validating(txtDensidadT7, _e);
                    return false;
                }
                if (!ValidarDelta(txtDeltaT7.Text, out error))
                {
                    _e.Cancel = false;
                    txtDeltaT7.Focus();
                    txtDeltaT7_Validating(txtDeltaT7, _e);
                    return false;
                }
                if (!ValidarLote(txtLoteT7.Text, out error, ptintero7.Enabled))
                {
                    _e.Cancel = false;
                    txtLoteT7.Focus();
                    txtLoteT7_Validating(txtLoteT7, _e);
                    return false;
                }
            }
            if (ptintero8.Enabled)
            {
                if (!ValidarColor(cmbColorT8.Text, out error, ptintero8.Enabled))
                {
                    _e.Cancel = false;
                    cmbColorT8.Focus();
                    cmbColorT8_Validating(cmbColorT8, _e);
                    return false;
                }

                if (!ValidarViscosidad(txtViscosidadT8.Text, out error))
                {
                    _e.Cancel = false;
                    txtViscosidadT8.Focus();
                    txtViscosidadT8_Validating(txtViscosidadT8, _e);
                    return false;
                }
                if (!ValidarDensidad(txtDensidadT8.Text, out error))
                {
                    _e.Cancel = false;
                    txtDensidadT8.Focus();
                    txtDensidadT8_Validating(txtDensidadT8, _e);
                    return false;
                }
                if (!ValidarDelta(txtDeltaT8.Text, out error))
                {
                    _e.Cancel = false;
                    txtDeltaT8.Focus();
                    txtDeltaT8_Validating(txtDeltaT8, _e);
                    return false;
                }
                if (!ValidarLote(txtLoteT8.Text, out error, ptintero8.Enabled))
                {
                    _e.Cancel = false;
                    txtLoteT8.Focus();
                    txtLoteT8_Validating(txtLoteT8, _e);
                    return false;
                }
            }
            return true;
        }

        private void ValidarCampos()
        {
            CancelEventArgs ee = new CancelEventArgs();
            ee.Cancel = false;
            txtPedido_Validating(txtPedido, ee);

            if (ee.Cancel)
            {
                txtPedido.Focus();
                return;
            }
            cmbResponsable_Validating(cmbResponsable, ee);
            if (ee.Cancel)
            {
                cmbResponsable.Focus();
                return;
            }

            if (ptintero1.Enabled)
            {
                txtViscosidadT1_Validating(txtViscosidadT1, ee);
                if (ee.Cancel)
                {
                    txtViscosidadT1.Focus();
                    return;
                }
                txtDensidadT1_Validated(txtDensidadT1, ee);
                if (ee.Cancel)
                {
                    txtDensidadT1.Focus();
                    return;
                }
                txtDeltaT1_Validating(txtDeltaT1, ee);
                if (ee.Cancel)
                {
                    txtDeltaT1.Focus();
                    return;
                }
            }
            if (ptintero2.Enabled)
            {
                txtViscosidadT2_Validating(txtViscosidadT2, ee);
                if (ee.Cancel)
                {
                    txtViscosidadT2.Focus();
                    return;
                }
                txtDensidadT2_Validated(txtDensidadT2, ee);
                if (ee.Cancel)
                {
                    txtDensidadT2.Focus();
                    return;
                }
                txtDeltaT2_Validating(txtDeltaT2, ee);
                if (ee.Cancel)
                {
                    txtDeltaT2.Focus();
                    return;
                }
            }
            if (ptintero3.Enabled)
            {
                txtViscosidadT3_Validating(txtViscosidadT3, ee);
                if (ee.Cancel)
                {
                    txtViscosidadT3.Focus();
                    return;
                }
                txtDensidadT3_Validated(txtDensidadT3, ee);
                if (ee.Cancel)
                {
                    txtDensidadT3.Focus();
                    return;
                }
                txtDeltaT3_Validating(txtDeltaT3, ee);
                if (ee.Cancel)
                {
                    txtDeltaT3.Focus();
                    return;
                }
            }
            if (ptintero4.Enabled)
            {
                txtViscosidadT4_Validating(txtViscosidadT4, ee);
                if (ee.Cancel)
                {
                    txtViscosidadT4.Focus();
                    return;
                }
                txtDensidadT4_Validated(txtDensidadT4, ee);
                if (ee.Cancel)
                {
                    txtDensidadT4.Focus();
                    return;
                }
                txtDeltaT4_Validating(txtDeltaT4, ee);
                if (ee.Cancel)
                {
                    txtDeltaT4.Focus();
                    return;
                }
            }
            if (ptintero5.Enabled)
            {
                txtViscosidadT5_Validating(txtViscosidadT5, ee);
                if (ee.Cancel)
                {
                    txtViscosidadT5.Focus();
                    return;
                }
                txtDensidadT5_Validated(txtDensidadT5, ee);
                if (ee.Cancel)
                {
                    txtDensidadT5.Focus();
                    return;
                }
                txtDeltaT5_Validating(txtDeltaT5, ee);
                if (ee.Cancel)
                {
                    txtDeltaT5.Focus();
                    return;
                }
            }
            if (ptintero6.Enabled)
            {
                txtViscosidadT6_Validating(txtViscosidadT6, ee);
                if (ee.Cancel)
                {
                    txtViscosidadT6.Focus();
                    return;
                }
                txtDensidadT6_Validated(txtDensidadT6, ee);
                if (ee.Cancel)
                {
                    txtDensidadT6.Focus();
                    return;
                }
                txtDeltaT6_Validating(txtDeltaT6, ee);
                if (ee.Cancel)
                {
                    txtDeltaT6.Focus();
                    return;
                }
            }
            if (ptintero7.Enabled)
            {
                txtViscosidadT7_Validating(txtViscosidadT7, ee);
                if (ee.Cancel)
                {
                    txtViscosidadT7.Focus();
                    return;
                }
                txtDensidadT7_Validated(txtDensidadT7, ee);
                if (ee.Cancel)
                {
                    txtDensidadT7.Focus();
                    return;
                }
                txtDeltaT7_Validating(txtDeltaT7, ee);
                if (ee.Cancel)
                {
                    txtDeltaT7.Focus();
                    return;
                }
            }
            if (ptintero8.Enabled)
            {
                txtViscosidadT8_Validating(txtViscosidadT8, ee);
                if (ee.Cancel)
                {
                    txtViscosidadT8.Focus();
                    return;
                }
                txtDensidadT8_Validated(txtDensidadT8, ee);
                if (ee.Cancel)
                {
                    txtDensidadT8.Focus();
                    return;
                }
                txtDeltaT8_Validating(txtDeltaT8, ee);
                if (ee.Cancel)
                {
                    txtDeltaT8.Focus();
                    return;
                }
            }
        }

        private void txtPedido_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarPedido(txtPedido.Text, out errorMsg))
            {
                e.Cancel = true;
                txtPedido.Select(0, txtPedido.Text.Length);
                this.errorProvider1.SetError(txtPedido, errorMsg);
            }
        }

        private void cmbResponsable_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbResponsable.Text;
            List<PersonalTintas> filteredItems = ListaEmpleados.FindAll(x => x.Nombre.ToLower().Contains(filter_param.ToLower()));
            cmbResponsable.DataSource = null;
            cmbResponsable.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbResponsable.DataSource = ListaEmpleados;
            }
            Cursor.Current = Cursors.Default;
            cmbResponsable.DisplayMember = "Nombre";
            cmbResponsable.ValueMember = "Cedula";
            cmbResponsable.SelectedIndex = -1;
            cmbResponsable.DroppedDown = true;
            cmbResponsable.Text = filter_param;
            cmbResponsable.SelectionLength = filter_param.Length;
            cmbResponsable.Select(filter_param.Length, 0);
        }

        private void cmbColorT1_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarColor(cmbColorT1.Text, out errorMsg, ptintero1.Enabled))
            {
                e.Cancel = true;
                cmbColorT1.Select(0, cmbColorT1.Text.Length);
                this.errorProvider1.SetError(cmbColorT1, errorMsg);
            }
        }

        private void cmbColorT1_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbColorT1, "");
        }

        private void cmbResponsable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cmbResponsable.SelectedIndex!=-1 && cmbResponsable.SelectedValue!=null )
                lblResponsable.Text = string.IsNullOrWhiteSpace(cmbResponsable.Text) ? "-" : cmbResponsable.SelectedValue.ToString();
        }

        private void cmbColorT2_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarColor(cmbColorT2.Text, out errorMsg, ptintero2.Enabled))
            {
                e.Cancel = true;
                cmbColorT2.Select(0, cmbColorT2.Text.Length);
                this.errorProvider1.SetError(cmbColorT2, errorMsg);
            }
        }

        private void cmbColorT3_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarColor(cmbColorT3.Text, out errorMsg, ptintero3.Enabled))
            {
                e.Cancel = true;
                cmbColorT3.Select(0, cmbColorT3.Text.Length);
                this.errorProvider1.SetError(cmbColorT3, errorMsg);
            }
        }

        private void cmbColorT4_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarColor(cmbColorT4.Text, out errorMsg, ptintero4.Enabled))
            {
                e.Cancel = true;
                cmbColorT4.Select(0, cmbColorT4.Text.Length);
                this.errorProvider1.SetError(cmbColorT4, errorMsg);
            }
        }

        private void cmbColorT5_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarColor(cmbColorT5.Text, out errorMsg, ptintero5.Enabled))
            {
                e.Cancel = true;
                cmbColorT5.Select(0, cmbColorT5.Text.Length);
                this.errorProvider1.SetError(cmbColorT5, errorMsg);
            }
        }

        private void cmbColorT6_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarColor(cmbColorT6.Text, out errorMsg, ptintero6.Enabled))
            {
                e.Cancel = true;
                cmbColorT6.Select(0, cmbColorT6.Text.Length);
                this.errorProvider1.SetError(cmbColorT6, errorMsg);
            }
        }

        private void cmbColorT7_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarColor(cmbColorT7.Text, out errorMsg, ptintero7.Enabled))
            {
                e.Cancel = true;
                cmbColorT7.Select(0, cmbColorT7.Text.Length);
                this.errorProvider1.SetError(cmbColorT7, errorMsg);
            }
        }

        private void cmbColorT8_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarColor(cmbColorT8.Text, out errorMsg, ptintero8.Enabled))
            {
                e.Cancel = true;
                cmbColorT8.Select(0, cmbColorT8.Text.Length);
                this.errorProvider1.SetError(cmbColorT8, errorMsg);
            }
        }

        private void cmbColorT2_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbColorT2, "");
        }

        private void cmbColorT3_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbColorT3, "");
        }

        private void cmbColorT4_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbColorT4, "");
        }

        private void cmbColorT5_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbColorT5, "");
        }

        private void cmbColorT6_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbColorT6, "");
        }

        private void cmbColorT7_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbColorT7, "");
        }

        private void cmbColorT8_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbColorT8, "");
        }

        private void txtViscosidadT1_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnCambiarTinteros_Click(object sender, EventArgs e)
        {
            frmCambiarTinteros cambioTintero = new frmCambiarTinteros(ref _dbconexion,txtPedido.Text);
            cambioTintero.StartPosition = FormStartPosition.CenterScreen;
            cambioTintero.Show();
            
        }

        private void btnActualizarTinteros_Click(object sender, EventArgs e)
        {
            CargarDatosTinteros(txtPedido.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _dbconexion.ExecuteCommand(string.Format("EXEC dbo.uspControlCalidadTintas_CambiarTintero @pNroOrden='{0}', @pTinteroOrigen={1}, @pTinteroDestino={2}", _controlTinta.OrdenNro, cmbOrigen.Text.Trim(), cmbDestino.Text));
            CargarDatosTinteros(_controlTinta.OrdenNro);
            
        }

        private void btnCambioTintero_MouseLeave(object sender, EventArgs e)
        {
            btnCambioTintero.Image = CalidadTintas.Properties.Resources.Transfer_25px;
        }

        private void btnCambioTintero_MouseHover(object sender, EventArgs e)
        {
            btnCambioTintero.Image = CalidadTintas.Properties.Resources.Transfer_hover_25px;
        }

        private void ctrolProceso_Load(object sender, EventArgs e)
        {

        }

        private void txtLoteT1_Validated(object sender, EventArgs e)
        {
            if(loteObligatorio)
                this.errorProvider1.SetError(txtLoteT1, "");
        }

        private void txtLoteT2_Validated(object sender, EventArgs e)
        {
            if (loteObligatorio)
                this.errorProvider1.SetError(txtLoteT2, "");

        }

        private void txtLoteT3_Validated(object sender, EventArgs e)
        {
            if (loteObligatorio)
                this.errorProvider1.SetError(txtLoteT3, "");

        }

        private void txtLoteT4_Validated(object sender, EventArgs e)
        {
            if (loteObligatorio)
                this.errorProvider1.SetError(txtLoteT4, "");

        }

        private void txtLoteT5_Validated(object sender, EventArgs e)
        {
            if (loteObligatorio)
                this.errorProvider1.SetError(txtLoteT5, "");

        }

        private void txtLoteT7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoteT7_Validated(object sender, EventArgs e)
        {
            if (loteObligatorio)
                this.errorProvider1.SetError(txtLoteT7, "");

        }

        private void txtLoteT8_Validated(object sender, EventArgs e)
        {
            if (loteObligatorio)
                this.errorProvider1.SetError(txtLoteT8, "");

        }

        private void txtLoteT1_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarLote(txtLoteT1.Text, out errorMsg, ptintero1.Enabled))
            {
                e.Cancel = true;
                //cmbColorT1.Select(0, cmbColorT1.Text.Length);
                this.errorProvider1.SetError(txtLoteT1, errorMsg);
            }
        }

        private void txtLoteT2_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarLote(txtLoteT2.Text, out errorMsg, ptintero2.Enabled))
            {
                e.Cancel = true;
                //cmbColorT1.Select(0, cmbColorT1.Text.Length);
                this.errorProvider1.SetError(txtLoteT2, errorMsg);
            }
        }

        private void txtLoteT4_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarLote(txtLoteT4.Text, out errorMsg, ptintero4.Enabled))
            {
                e.Cancel = true;
                //cmbColorT1.Select(0, cmbColorT1.Text.Length);
                this.errorProvider1.SetError(txtLoteT4, errorMsg);
            }
        }

        private void txtLoteT3_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarLote(txtLoteT3.Text, out errorMsg, ptintero3.Enabled))
            {
                e.Cancel = true;
                //cmbColorT1.Select(0, cmbColorT1.Text.Length);
                this.errorProvider1.SetError(txtLoteT3, errorMsg);
            }
        }

        private void txtLoteT5_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarLote(txtLoteT5.Text, out errorMsg, ptintero5.Enabled))
            {
                e.Cancel = true;
                //cmbColorT1.Select(0, cmbColorT1.Text.Length);
                this.errorProvider1.SetError(txtLoteT5, errorMsg);
            }
        }

        private void txtLoteT6_Validated(object sender, EventArgs e)
        {
            if (loteObligatorio)
                this.errorProvider1.SetError(txtLoteT6, "");
        }

        private void txtLoteT6_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarLote(txtLoteT6.Text, out errorMsg, ptintero6.Enabled))
            {
                e.Cancel = true;
                //cmbColorT1.Select(0, cmbColorT1.Text.Length);
                this.errorProvider1.SetError(txtLoteT6, errorMsg);
            }
        }

        private void txtLoteT7_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarLote(txtLoteT7.Text, out errorMsg, ptintero7.Enabled))
            {
                e.Cancel = true;
                //cmbColorT1.Select(0, cmbColorT1.Text.Length);
                this.errorProvider1.SetError(txtLoteT7, errorMsg);
            }
        }

        private void txtLoteT8_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarLote(txtLoteT8.Text, out errorMsg, ptintero8.Enabled))
            {
                e.Cancel = true;
                //cmbColorT1.Select(0, cmbColorT1.Text.Length);
                this.errorProvider1.SetError(txtLoteT8, errorMsg);
            }
        }
    }
    public class clsInsumoTinta
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
    public class clsEmpleados
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
    }
    public class clsTinteros
    {
        public short NumeroTintero { get; set; }
    }
}
