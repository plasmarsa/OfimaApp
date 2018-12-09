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
    public partial class ctrolAprobado : UserControl
    {
        private OfimaticaDBContext _dbconexion;
        public ctrolAprobado()
        {
            InitializeComponent();
        }
        public ctrolAprobado(ref OfimaticaDBContext dbConexion)
        {
            _dbconexion = dbConexion;
            InitializeComponent();
            CargarControlesAprobados();
            
        }
        private void CargarControlesAprobados()
        {
            vUsrControlCalidadTintasAprobadosBindingSource.DataSource= _dbconexion.vUsrControlCalidadTintasAprobados.ToList();
            //grid.DataSource = _dbconexion.vUsrControlCalidadTintasAprobados.ToList();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if(e.ColumnIndex==senderGrid.Columns["verdetalle"].Index && e.RowIndex>=0)
            {
                string pedido = senderGrid.Rows[e.RowIndex].Cells["OrdenNroDataGridView"].Value.ToString();
                if(!string.IsNullOrWhiteSpace(pedido))
                {
                    frmDetalleControl detalle = new frmDetalleControl(ref _dbconexion, pedido);
                    detalle.StartPosition = FormStartPosition.CenterScreen;
                    detalle.Show();
                }

            }
        }
    }
}
