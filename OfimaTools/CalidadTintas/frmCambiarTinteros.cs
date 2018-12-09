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
    public partial class frmCambiarTinteros : Form
    {
        private OfimaticaDBContext _dbconexion;
        private string _pedido;
        public List<clsInsumoTinta> ListaTintas;
        public tblControlCalidadTintas _controlTinta;

        public frmCambiarTinteros()
        {
            InitializeComponent();
        }
        public frmCambiarTinteros(ref OfimaticaDBContext dbConexion, string pedido)
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            _dbconexion = dbConexion;
            _pedido = pedido;
        }
        private void frmCambiarTinteros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }


        private void btnCambiarTinteros_Click(object sender, EventArgs e)
        {
            _dbconexion.ExecuteCommand(string.Format("UPDATE t SET t.NroTintero ='{0}' FROM dbo.tblControlCalidadTinteros t WHERE t.OrdenNro='{1}' AND t.NroTintero={2}",cmbDestino.Text.Trim(), _pedido, cmbOrigen.Text));
            _dbconexion.ExecuteCommand(string.Format("UPDATE t SET t.NroTintero ='{0}' FROM dbo.tblControlCalidadTinteros t WHERE t.OrdenNro='{1}' AND t.NroTintero={2}", cmbOrigen.Text.Trim(), _pedido, cmbDestino.Text));

            //if (cmbOrigen.Text == cmbDestino.Text)
            //{
            //    MessageBox.Show("El tintero origen y destino no pueden ser el mismo.","Cambio los tinteros.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            //tblControlCalidadTinteros tinteroOrigen = new tblControlCalidadTinteros();
                //tblControlCalidadTinteros tinteroDestino = new tblControlCalidadTinteros();
                //var s = _dbConn.ExecuteQuery<SalidaMatPrima>(string.Format("SELECT t.IdMov, t.Fecha_Hora, t.IdPesaje, t.Proveedor,RTRIM(m.NOMBRE) AS RazonSocial,t.Producto,p.descripcio as NombreProducto, t.OrdenCompra, t.FacturaProveedor,t.CantidadBruta,t.CantidadNeta FROM dbo.tblInvMovProducto t(nolock) INNER JOIN dbo.MTMERCIA p(NOLOCK)ON p.CODIGO = t.Producto INNER JOIN dbo.MTPROCLI m(NOLOCK)ON m.NIT = t.Proveedor WHERE t.IdPesaje = '{0}' AND t.tipo = 'E'", strIdPesaje)).SingleOrDefault();
                //tinteroOrigen = _dbconexion.ExecuteQuery<tblControlCalidadTinteros>(string.Format("SELECT t.OrdenNro, t.NroTintero, t.CodInsumo, t.Cantidad, t.CodAnilox, t.CodStick, t.Lote_Insumo, t.Viscosidad, t.Densidad, t.Delta FROM dbo.tblControlCalidadTinteros t WHERE t.OrdenNro='{0}' AND t.NroTintero= {1}",_pedido,cmbOrigen.Text)).SingleOrDefault();
                //tinteroDestino = _dbconexion.ExecuteQuery<tblControlCalidadTinteros>(string.Format("SELECT t.OrdenNro, t.NroTintero, t.CodInsumo, t.Cantidad, t.CodAnilox, t.CodStick, t.Lote_Insumo, t.Viscosidad, t.Densidad, t.Delta FROM dbo.tblControlCalidadTinteros t WHERE t.OrdenNro='{0}' AND t.NroTintero= {1}", _pedido, cmbDestino.Text)).SingleOrDefault();
                
                

                //_dbconexion.ExecuteCommand(string.Format("DELETE FROM dbo.tblControlCalidadTinteros WHERE OrdenNro='{0}' AND NroTintero={1}",_pedido,cmbOrigen.Text));
                //_dbconexion.ExecuteCommand(string.Format("DELETE FROM dbo.tblControlCalidadTinteros WHERE OrdenNro='{0}' AND NroTintero={1}", _pedido, cmbDestino.Text));
                
                //if (tinteroOrigen != null)
                //{
                //    tinteroOrigen.NroTintero = short.Parse(cmbDestino.Text);
                //    //_dbconexion.tblControlCalidadTinteros.InsertOnSubmit(tinteroOrigen);
                //    _dbconexion.SubmitChanges();
                //}
                //if (tinteroDestino != null)
                //{
                //    tinteroDestino.NroTintero = short.Parse(cmbOrigen.Text);
                //    //_dbconexion.tblControlCalidadTinteros.InsertOnSubmit(tinteroDestino);
                //    _dbconexion.SubmitChanges();
                //}



            //}
            this.Dispose();     
            
        }

        private void frmCambiarTinteros_Load(object sender, EventArgs e)
        {
            this.Text = "Cambiar Tinteros Pedido " + _pedido;
        }
    }
}
