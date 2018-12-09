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

namespace CtrolAlmacenMantenimiento
{
    public partial class ctrolRegistro : UserControl
    {
        OfimaticaDBContext _dbConn;
        List<Proveedor> proveedores;
        List<Repuesto> repuestos;
        public ctrolRegistro()
        {
            InitializeComponent();
        }
        public ctrolRegistro(ref OfimaticaDBContext dbconn, ref List<Proveedor> Proveedores,ref List<Repuesto> Repuestos)
        {
            InitializeComponent();
            _dbConn = dbconn;
            proveedores = Proveedores;
            repuestos = Repuestos;
        }

        private void ctrolRegistro_Load(object sender, EventArgs e)
        {
            CargarUltimosMvtoAlmacen();
        }
        private void CargarUltimosMvtoAlmacen()
        {
            gridMov.DataSource = _dbConn.vUsrMantenEntradasSalidasRepuestos.Take(300).OrderByDescending(s=>s.Fecha_Hora).ToList();
        }
        private void CargarUltimosMvtoAlmacen(string repuesto)
        {
            gridMov.DataSource = _dbConn.vUsrMantenEntradasSalidasRepuestos.Where(x=>x.Nombre_Repuesto.ToLower().Contains(repuesto.ToLower())).Take(300).OrderByDescending(s => s.Fecha_Hora).ToList();
        }

        private void cmbProveedor_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbProveedor.Text;

            List<Proveedor> filteredItems = proveedores.Where(x => x.Nombre.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbProveedor.DataSource = null;
            cmbProveedor.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbProveedor.DataSource = proveedores;
                
            }
            Cursor.Current = Cursors.Default;
            cmbProveedor.ItemHeight = 100;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Nit";
            cmbProveedor.MaxDropDownItems = 8;
            cmbProveedor.SelectedIndex = -1;
            cmbProveedor.DroppedDown = true;
            cmbProveedor.Text = filter_param;
            cmbProveedor.SelectionLength = filter_param.Length;
            cmbProveedor.Select(filter_param.Length, 0);
            //CargarDatosDetalle(filter_param);
        }

        private void CargarDatosDetalle(string nitproveedor)
        {
            if (!string.IsNullOrWhiteSpace(nitproveedor))
            {
                gridMov.DataSource = _dbConn.vUsrMantenEntradasSalidasRepuestos.Where(x => x.Nit_Provee == nitproveedor).ToList();
            }
            else
            {
                gridMov.DataSource = _dbConn.vUsrMantenEntradasSalidasRepuestos.ToList();
            }
        }
        private string BuscarNitProveedor(string nombreProveedor)
        {
            return proveedores.Where(x => x.Nombre==nombreProveedor).Select(s => s.Nit.TrimEnd()).SingleOrDefault();
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosDetalle(BuscarNitProveedor(cmbProveedor.Text));
        }

        private void cmbRepuesto_TextChanged(object sender, EventArgs e)
        {
            string filter_param = cmbRepuesto.Text;

            List<Repuesto> filteredItems = repuestos.Where(x => x.Descripcio.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbRepuesto.DataSource = null;
            cmbRepuesto.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbRepuesto.DataSource = proveedores;

            }
            Cursor.Current = Cursors.Default;
            cmbRepuesto.ItemHeight = 100;
            cmbRepuesto.DisplayMember = "Descripcio";
            cmbRepuesto.ValueMember = "Codigo";
            cmbRepuesto.MaxDropDownItems = 8;
            cmbRepuesto.SelectedIndex = -1;
            cmbRepuesto.DroppedDown = true;
            cmbRepuesto.Text = filter_param;
            cmbRepuesto.SelectionLength = filter_param.Length;
            cmbRepuesto.Select(filter_param.Length, 0);
            //CargarDatosDetalle(filter_param);
        }

        private void txtDescripcionProducto_TextChanged(object sender, EventArgs e)
        {
            CargarUltimosMvtoAlmacen(txtDescripcionProducto.Text);
        }
    }
}
