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
    public partial class ctrolAprobadoLista : UserControl
    {
        private OfimaticaDBContext _dbconexion;

        public ctrolAprobadoLista(ref OfimaticaDBContext dbConexion)
        {
            _dbconexion = dbConexion;
            InitializeComponent();
            CargarControlesAprobados();
        }
        private void CargarControlesAprobados()
        {
            vUsrControlCalidadTintasAprobadosBindingSource.DataSource = _dbconexion.vUsrControlCalidadTintasAprobados.OrderByDescending(x=>x.Fecha).Take(200).ToList();
            //dtgDefectos.Sort(dtgDefectos.Columns["Porcentaje"], ListSortDirection.Descending);

        }
        private void CargarControlesAprobados(string pedido,string cliente, string producto, string impresora)
        {
            vUsrControlCalidadTintasAprobadosBindingSource.DataSource = 
                _dbconexion.vUsrControlCalidadTintasAprobados.
                Where(w=>(w.OrdenNro.Contains(pedido) || pedido=="") && (w.Cliente.ToLower().Contains(cliente.ToLower()) || cliente == "")
                    && (w.Producto.Contains(producto) || producto == "") && (w.Impresora.ToLower().Contains(impresora.ToLower()) || impresora == "")).
                OrderByDescending(x => x.Fecha).Take(200).ToList();
        }

        private void vUsrControlCalidadTintasAprobadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["verControl"].Index && e.RowIndex >= 0)
            {
                string pedido = senderGrid.Rows[e.RowIndex].Cells["OrdenNroGridColumn"].Value.ToString().TrimEnd();
                //MessageBox.Show(senderGrid.Rows[e.RowIndex].Cells["ordenNroDataGridViewTextBoxColumn"].Value.ToString());
                if(!string.IsNullOrWhiteSpace(pedido))
                {
                    frmDetalleControl detalle = new frmDetalleControl(ref _dbconexion, pedido);
                    detalle.StartPosition = FormStartPosition.CenterScreen;
                    detalle.Show();
                }
                
                
                
            }

            
        }

        private void ctrolAprobadoLista_Load(object sender, EventArgs e)
        {

        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {
            CargarControlesAprobados(txtPedido.Text, txtCliente.Text, txtProducto.Text, txtImpresora.Text);
        }
        private void filtrarConsulta(object sender, EventArgs e)
        {
            CargarControlesAprobados(txtPedido.Text, txtCliente.Text, txtProducto.Text, txtImpresora.Text);
        }
    }
}
