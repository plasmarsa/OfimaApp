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
    public partial class ctrolDashboard : UserControl
    {
        protected OfimaticaDBContext _dbConn;
        protected List<Proveedor> Proveedores;
        protected List<MateriaPrima> MateriasPrimas;
        public ctrolDashboard()
        {
            InitializeComponent();
        }
        public ctrolDashboard(ref OfimaticaDBContext dbConexion)
        {
            _dbConn = dbConexion;
            InitializeComponent();
            
        }

        private void ListarMateriasPrimas()
        {

        }
        private void ListarProveedorers()
        {

        }
    }
    public class Proveedor
    {
        public string Nit { get; set; }
        public string Nombre { get; set; }
    }
    public class MateriaPrima
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }

}
