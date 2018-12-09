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
    public partial class ctrolDashboard : UserControl
    {
        private OfimaticaDBContext _dbconexion; 
        public ctrolDashboard()
        {
            InitializeComponent();
        }
        public ctrolDashboard(ref OfimaticaDBContext dbConexion )
        {
            _dbconexion = dbConexion;
            InitializeComponent();
            txtControlesPendientes.Text = ConsultarControlesPendientes();
            txtAprobadosHoy.Text = ConsultarControlesAprobadosHoy();
            txtAprobados.Text = ConsultarControlesAprobados();
            txtAprobados.Text=txtAprobados.Text;
        }
        private string ConsultarControlesPendientes()
        {
            string _cantidad;
            lstPendientes.Items.Clear();
            List<string> ListaControlesPendientes;
            _cantidad = _dbconexion.tblControlCalidadTintas.Where(x => x.Aprobado == false).Count().ToString();
            if(string.IsNullOrWhiteSpace(_cantidad))
            {
                _cantidad = "0";
            }
            if (_cantidad != "0")
            {
                lstPendientes.Visible = true;
                ListaControlesPendientes = _dbconexion.vUsrControlCalidadTintasPendientes.OrderByDescending(s => s.OrdenNro).Select(x => x.OrdenNro.Trim()+'-'+x.Cliente).ToList();
                foreach (string item in ListaControlesPendientes)
                {
                    lstPendientes.Items.Add(item.ToString());
                }
            }
            else
            {
                lstPendientes.Visible = false;
            }
                
            return _cantidad;
        }
        private string ConsultarControlesAprobadosHoy()
        {
            lblFechaHoy.Text = "Hoy " + DateTime.Now.ToString("dd/MM/yyyy");
            string _cantidad;
            lstAprobados.Items.Clear();
            List<string> ListaControlesAprobadosHoy;
            _cantidad = _dbconexion.vUsrControlCalidadTintasAprobados.Where(s => s.Fecha == DateTime.Now.ToString("yyyy/MM/dd")).Count().ToString();
            if (string.IsNullOrWhiteSpace(_cantidad))
            {
                _cantidad = "0";
            }
            if (_cantidad != "0")
            {
                lstAprobados.Visible = true;
                ListaControlesAprobadosHoy = _dbconexion.vUsrControlCalidadTintasAprobados.Where(s => s.Fecha == DateTime.Now.ToString("yyyy/MM/dd")).OrderByDescending(s => s.OrdenNro).Select(x => x.OrdenNro.Trim() + '-' + x.Cliente).ToList();
                foreach (string item in ListaControlesAprobadosHoy)
                {
                    lstAprobados.Items.Add(item.ToString().Trim());
                }
            }
            else
                lstAprobados.Visible = false;
            return _cantidad;
        }


        private string ConsultarControlesAprobados()
        {
            string _cantidad;
            _cantidad = _dbconexion.vUsrControlCalidadTintasAprobados.Count().ToString();
            if (string.IsNullOrWhiteSpace(_cantidad))
            {
                _cantidad = "0";
            }
            
            return _cantidad;
        }

    }
}
