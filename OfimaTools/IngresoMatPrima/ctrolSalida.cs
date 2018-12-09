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

namespace IngresoMatPrima
{
    public partial class ctrolSalida : UserControl
    {
        protected OfimaticaDBContext _dbConn;
        protected List<Proveedor> Proveedores;
        protected List<MateriaPrima> MateriasPrimas;
        public ctrolSalida()
        {
            InitializeComponent();
        }
        public ctrolSalida(ref OfimaticaDBContext dbConexion)
        {
            InitializeComponent();
            _dbConn = dbConexion;
        }
        private void ListarMateriasPrimas()
        {

        }
        private void ListarProveedorers()
        {

        }

        private void ctrolSalida_Load(object sender, EventArgs e)
        {
            txtIdEtiqueta.Focus();
        }

        private void txtIdEtiqueta_Validating(object sender, CancelEventArgs e)
        {
            string strIdPesaje;
            if (txtIdEtiqueta.Text == "")
                return;

            strIdPesaje = txtIdEtiqueta.Text;
            txtprovedor.Text = "";
            txtproducto.Text = "";
            txtnit.Text = "";
            txtcodigo.Text = "";
            txtPesoBruto.Text = "0";
            txtPesoNeto.Text = "0";
            try
            {
                var s = _dbConn.ExecuteQuery<SalidaMatPrima>(string.Format("SELECT t.IdMov, t.Fecha_Hora, t.IdPesaje, t.Proveedor,RTRIM(m.NOMBRE) AS RazonSocial,t.Producto,p.descripcio as NombreProducto, t.OrdenCompra, t.FacturaProveedor,t.CantidadBruta,t.CantidadNeta FROM dbo.tblInvMovProducto t(nolock) INNER JOIN dbo.MTMERCIA p(NOLOCK)ON p.CODIGO = t.Producto INNER JOIN dbo.MTPROCLI m(NOLOCK)ON m.NIT = t.Proveedor WHERE t.IdPesaje = '{0}' AND t.tipo = 'E'", strIdPesaje)).SingleOrDefault();
                if (s != null)
                {
                    txtprovedor.Text = s.RazonSocial;
                    txtproducto.Text = s.NombreProducto;
                    txtnit.Text = s.Proveedor;
                    txtcodigo.Text = s.Producto;
                    txtPesoBruto.Text = string.Format("{0:0.##}", s.CantidadBruta);  //s.CantidadBruta.ToString();
                    txtPesoNeto.Text = string.Format("{0:0.##}", s.CantidadNeta);  //s.CantidadNeta.ToString();
                    txtOrden.Text = s.OrdenCompra;
                    txtFactura.Text = s.FacturaProveedor;
                    btnPeso.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el id de la etiqueta.\n" + ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnit.Text != "" || txtcodigo.Text != "" || txtIdEtiqueta.Text != "" || txtPesoBruto.Text != null || txtPesoNeto.Text != "")
                {
                    tblInvMovProducto salida = new tblInvMovProducto();
                    salida.CantidadBruta = decimal.Parse(txtPesoBruto.Text);
                    salida.CantidadNeta = decimal.Parse(txtPesoNeto.Text);
                    salida.CantNetaPendiente = 0m;
                    salida.Estiba = 0m;
                    salida.FacturaProveedor = "";
                    salida.Fecha_Hora = DateTime.Now;
                    salida.IdPesaje = txtIdEtiqueta.Text;
                    salida.Observacion = "";
                    salida.OrdenCompra = "";
                    salida.Producto = txtcodigo.Text;
                    salida.Proveedor = txtnit.Text;
                    salida.Tipo = 'S';
                    salida.IdMov = 0;
                    try
                    {
                        _dbConn.tblInvMovProducto.InsertOnSubmit(salida);
                        _dbConn.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "No ha sido posible registrar la salida de la materia prima.\n"+ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    txtIdEtiqueta.Text = "";
                    txtcodigo.Text = "";
                    txtFactura.Text = "";
                    txtnit.Text = "";
                    txtproducto.Text = "";
                    txtprovedor.Text = "";
                    txtFactura.Text = "";
                    txtOrden.Text = "";
                    txtPesoBruto.Text = "";
                    txtPesoNeto.Text = "";
                    txtIdEtiqueta.Focus();
                }
                else
                { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el descarge de la etiqueta.\n"+ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIdEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (txtIdEtiqueta.Text != ""))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtIdEtiqueta_Validating(null, null);
                btnPeso_Click(null, null);
            }
        }
    }
    public class SalidaMatPrima
    {
        public dynamic IdMov;
        public dynamic Fecha_Hora;
        public dynamic IdPesaje;
        public dynamic Proveedor;
        public dynamic RazonSocial;
        public dynamic Producto;
        public dynamic NombreProducto;
        public dynamic OrdenCompra;
        public dynamic FacturaProveedor;
        public dynamic CantidadBruta;
        public dynamic CantidadNeta;



    }

}
