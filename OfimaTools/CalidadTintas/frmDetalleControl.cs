using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dataccess;

namespace CalidadTintas
{
    public partial class frmDetalleControl : Form
    {
        private OfimaticaDBContext _dbconexion;
        private string _pedido;
        public List<clsInsumoTinta> ListaTintas;
        public tblControlCalidadTintas _controlTinta;
        public frmDetalleControl()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
        }
        public frmDetalleControl(ref OfimaticaDBContext dbConexion,string pedido)
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            _dbconexion = dbConexion;
            _pedido = pedido;
        }

        private void frmDetalleControl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }

        }

        private void frmDetalleControl_Load(object sender, EventArgs e)
        {
            txtPedido.Text = _pedido;
            ListaTintas = _dbconexion.MTMERCIA.Where(x => x.CODLINEA == "0102").Select(s => new clsInsumoTinta { Codigo = string.Format("{0} - {1}", s.CODIGO.TrimEnd(), s.DESCRIPCIO.TrimEnd()), Descripcion = s.CODIGO.TrimEnd() }).ToList();
            txtPedido_Validated(txtPedido, null);
            
        }

        private void txtPedido_Validated(object sender, EventArgs e)
        {
            MVPISO _lote = new MVPISO();
            tblProgImpresion programacion = new tblProgImpresion();
            _controlTinta= new tblControlCalidadTintas();

            var u = _dbconexion.tblControlCalidadTintasStick.ToList();

            //Consultar Cliente
            lblCliente.Text = _dbconexion.TRADE.Where(t => t.NRODCTO == _pedido && t.ORIGEN == "fac" && t.TIPODCTO == "pd").Select(s => new { s.NRODCTO, s.NIT })
                    .Join(_dbconexion.MTPROCLI, t => t.NIT, m => m.NIT, (t, m) => new { t.NIT, m.NOMBRE }).Select(s => s.NOMBRE).SingleOrDefault().TrimEnd();



            //Consulta del producto
            clsInsumoTinta _codigo;
            _codigo = _dbconexion.MVTRADE.Join(_dbconexion.MTMERCIA, m => m.PRODUCTO, c => c.CODIGO, (m, c) => new { m.NRODCTO,
                    m.PRODUCTO, c.DESCRIPCIO, m.ORIGEN, m.TIPODCTO }).Where(m => m.ORIGEN == "fac" && m.TIPODCTO == "pd" && m.NRODCTO == _pedido).
                    Select(x=> new clsInsumoTinta() { Codigo= x.PRODUCTO.TrimEnd(),Descripcion=x.DESCRIPCIO.TrimEnd() } ).SingleOrDefault();

            _lote = _dbconexion.MVPISO.Where(m => m.LOTEOP == txtPedido.Text && m.CODCC == "0202").SingleOrDefault();
            if (_lote != null)
            {
                txtCantidad.Text = string.Format("{0:0.##}", _lote.CANTREQUE);
            }
            else
            {
                txtCantidad.Text = _dbconexion.MVTRADE.Where(x => x.ORIGEN == "fac" && x.TIPODCTO == "pd" && x.NRODCTO == _pedido).Select(s => string.Format("{0:0.##}", s.CANTIDAD)).SingleOrDefault();
            }

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


            //Buscar control en proceso con el pedido actual
            _controlTinta = new tblControlCalidadTintas();
            _controlTinta = _dbconexion.tblControlCalidadTintas.Where(x => x.OrdenNro == txtPedido.Text).SingleOrDefault();
            if (_controlTinta == null)
            {
                MessageBox.Show("No se encontrol control de calidad de tintas para el pedido especificado.\n Por favor verifiquelo.","Controles Aprobados.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
                


            txtCodigo.Text = _codigo.Codigo.Trim();
            txtDescripcion.Text = _codigo.Descripcion.TrimEnd();
            txtCantidad.Text = _controlTinta.Cantidad;
            chkEquinox.Checked = _controlTinta.Equinox;
            lblMaquina.Text = _controlTinta.Impresora;
            txtComentarios.Text = _controlTinta.Comentarios;
            txtCreado.Text = BuscarEmpleado(_controlTinta.IdResponsable);
            txtModifico.Text = BuscarEmpleado(_controlTinta.IdResponsable_Mod);
            txtFechaAprobado.Text = _controlTinta.Fecha_Hora_Mod.ToString();
            CargarDatosTinteros(_controlTinta.OrdenNro);

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

            foreach (tblControlCalidadTinteros _detalleTintero in _detalleTinteros)
            {
                if (_detalleTintero.NroTintero == 1)
                {
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        txtcolort1.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        txtcolort1.Text = _detalleTintero.CodInsumo;

                    lblColort1.Text = _detalleTintero.CodInsumo;
                    txtLoteT1.Text = _detalleTintero.Lote_Insumo;
                    txtstickt1.Text = _detalleTintero.CodStick.ToString();
                    txtaniloxt1.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT1.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT1.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT1.Text = _detalleTintero.Delta.ToString();
                }

                if (_detalleTintero.NroTintero == 2)
                {
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        txtcolort2.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        txtcolort2.Text = _detalleTintero.CodInsumo;

                    lblColort2.Text = _detalleTintero.CodInsumo;
                    lblColort2.Text = _detalleTintero.CodInsumo;
                    txtLoteT2.Text = _detalleTintero.Lote_Insumo;
                    txtstickt2.Text = _detalleTintero.CodStick.ToString();
                    txtaniloxt2.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT2.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT2.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT2.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 3)
                {
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        txtcolort3.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        txtcolort3.Text = _detalleTintero.CodInsumo;

                    lblColort3.Text = _detalleTintero.CodInsumo;
                    txtLoteT3.Text = _detalleTintero.Lote_Insumo;
                    txtstickt3.Text = _detalleTintero.CodStick.ToString();
                    txtaniloxt3.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT3.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT3.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT3.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 4)
                {
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        txtcolort4.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        txtcolort4.Text = _detalleTintero.CodInsumo;

                    lblColort4.Text = _detalleTintero.CodInsumo;
                    txtLoteT4.Text = _detalleTintero.Lote_Insumo;
                    txtstickt4.Text = _detalleTintero.CodStick.ToString();
                    txtaniloxt4.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT4.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT4.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT4.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 5)
                {
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        txtcolort5.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        txtcolort5.Text = _detalleTintero.CodInsumo;

                    lblColort5.Text = _detalleTintero.CodInsumo;
                    txtLoteT5.Text = _detalleTintero.Lote_Insumo;
                    txtstickt5.Text = _detalleTintero.CodStick.ToString();
                    txtaniloxt5.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT5.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT5.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT5.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 6)
                {
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        txtcolort6.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        txtcolort6.Text = _detalleTintero.CodInsumo;

                    lblColort6.Text = _detalleTintero.CodInsumo;
                    txtLoteT6.Text = _detalleTintero.Lote_Insumo;
                    txtstickt6.Text = _detalleTintero.CodStick.ToString();
                    txtaniloxt6.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT6.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT6.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT6.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 7)
                {
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        txtcolort7.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        txtcolort7.Text = _detalleTintero.CodInsumo;

                    lblColort7.Text = _detalleTintero.CodInsumo;
                    txtLoteT7.Text = _detalleTintero.Lote_Insumo;
                    txtstickt7.Text = _detalleTintero.CodStick.ToString();
                    txtaniloxt7.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT7.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT7.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT7.Text = _detalleTintero.Delta.ToString();
                }
                if (_detalleTintero.NroTintero == 8)
                {
                    if (!string.IsNullOrWhiteSpace(BuscarColor(_detalleTintero.CodInsumo)))
                        txtcolort8.Text = (BuscarColor(_detalleTintero.CodInsumo));
                    else
                        txtcolort8.Text = _detalleTintero.CodInsumo;

                    lblColort8.Text = _detalleTintero.CodInsumo;
                    txtLoteT8.Text = _detalleTintero.Lote_Insumo;
                    txtstickt8.Text = _detalleTintero.CodStick.ToString();
                    txtaniloxt8.Text = _detalleTintero.CodAnilox.ToString();
                    txtViscosidadT8.Text = _detalleTintero.Viscosidad.ToString();
                    txtDensidadT8.Text = _detalleTintero.Densidad.ToString();
                    txtDeltaT8.Text = _detalleTintero.Delta.ToString();
                }
            }


        }
        private string BuscarEmpleado(string cedula)
        {
            string _nombre;
            _nombre = _dbconexion.vUsrGosem_ghPlasmar_rhRecursos.Where(w => w.cod_recurso == cedula).Select(s => s.Nombre_Completo).SingleOrDefault();
            if(string.IsNullOrWhiteSpace(_nombre))
            {
                _nombre = "No se encontro";
            }
            return _nombre;
        }
        private string BuscarColor(string codigo)
        {
            string _codigo;
            _codigo= ListaTintas.Where(x => x.Descripcion == codigo).Select(s => s.Codigo).SingleOrDefault();

            if (string.IsNullOrWhiteSpace(_codigo))
            {
                _codigo = codigo;
            }
            return _codigo;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.Image = CalidadTintas.Properties.Resources.Cancel_hover_50px;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.Image = CalidadTintas.Properties.Resources.Cancel_black_50px;
        }
    }
}
