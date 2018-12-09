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

namespace IngresoMatPrima
{
    public partial class frMain : Form
    {
        Properties.Settings _configuracion = new Properties.Settings();
        public OfimaticaDBContext _dbConexion;
        private ctrolDashboard _ctrolDashBoard;
        private ctrolEntrada _ctrolEntrada;
        private ctrolSalida _ctrolSalida;
        public frMain()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
        }


        private void frMain_Load(object sender, EventArgs e)
        {
            string[] Argumentos = Environment.GetCommandLineArgs();
            if (Argumentos.Length > 1)
            {
                _dbConexion = new OfimaticaDBContext();
                _dbConexion = new OfimaticaDBContext(ModificarDBConexion(_configuracion.Servidor, Argumentos[2], _configuracion.dbUser, _configuracion.dbPassword));
                lblUsuario.Text = Argumentos[3].ToUpper();
                lblDatabase.Text = Argumentos[2].ToUpper();
            }
            else
            {
                _dbConexion = new OfimaticaDBContext(ModificarDBConexion(_configuracion.Servidor, _configuracion.Database, _configuracion.dbUser, _configuracion.dbPassword));
                lblUsuario.Text = _configuracion.dbUser;
                lblDatabase.Text = _configuracion.Database.ToUpper();
            }
            ActivarControl("entrada");
        }

        #region Modificar cadena de conexion
        private String ModificarDBConexion(String Servidor, String Database, string DBUser, string DBPassword)
        {
            //Data Source=hestia;Initial Catalog=PLASMARSA;Persist Security Info=True;User ID=ofimatica;Password=ofimatica
            String connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", Servidor, Database, DBUser, DBPassword);
            return connString;
        }
        #endregion

        private void ActivarControl(string Nombre_Control)
        {
            pControl.Controls.Clear();
            switch (Nombre_Control)
            {
                case "dashboard":
                    if (_ctrolEntrada != null)
                    {
                        _ctrolEntrada.Dispose();
                    }
                    _ctrolEntrada = null;
                    _ctrolSalida = null;
                    lblTitulo.Text = "DASHBOARD";
                    _ctrolDashBoard = new ctrolDashboard(ref _dbConexion);
                    pControl.Controls.Add(_ctrolDashBoard);
                    _ctrolDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolDashBoard.Location = new System.Drawing.Point(6, 3);
                    this._ctrolDashBoard.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolDashBoard.Name = "control";
                    this._ctrolDashBoard.Size = new System.Drawing.Size(874, 478);
                    this._ctrolDashBoard.TabIndex = 1;


                    break;
                case "entrada":
                    if (_ctrolEntrada != null)
                    {
                        _ctrolEntrada.Dispose();
                    }
                    _ctrolDashBoard = null;
                    _ctrolSalida = null;
                    lblTitulo.Text = "INGRESO DE MATERIAS PRIMAS";
                    _ctrolEntrada = new ctrolEntrada(ref _dbConexion);
                    pControl.Controls.Add(_ctrolEntrada);
                    _ctrolEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolEntrada.Location = new System.Drawing.Point(6, 3);
                    this._ctrolEntrada.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolEntrada.Name = "control";
                    this._ctrolEntrada.Size = new System.Drawing.Size(874, 478);
                    this._ctrolEntrada.TabIndex = 1;

                    break;

                case "salida":
                    if(_ctrolEntrada != null)
                    {
                        _ctrolEntrada.Dispose();
                    }
                    _ctrolDashBoard = null;
                    _ctrolEntrada = null;
                    lblTitulo.Text = "SALIDA DE MATERIAS PRIMAS";
                    _ctrolSalida = new ctrolSalida(ref _dbConexion);
                    pControl.Controls.Add(_ctrolSalida);
                    _ctrolSalida.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolSalida.Location = new System.Drawing.Point(6, 3);
                    this._ctrolSalida.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolSalida.Name = "control";
                    this._ctrolSalida.Size = new System.Drawing.Size(874, 478);
                    this._ctrolSalida.TabIndex = 1;

                    break;

                default:
                    _ctrolEntrada = null;
                    _ctrolSalida = null;
                    lblTitulo.Text = "DASHBOARD";
                    _ctrolDashBoard = new ctrolDashboard(ref _dbConexion);
                    pControl.Controls.Add(_ctrolDashBoard);
                    _ctrolDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolDashBoard.Location = new System.Drawing.Point(6, 3);
                    this._ctrolDashBoard.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolDashBoard.Name = "control";
                    this._ctrolDashBoard.Size = new System.Drawing.Size(874, 478);
                    this._ctrolDashBoard.TabIndex = 1;


                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntradaMateriaPrima_Click(object sender, EventArgs e)
        {
            ActivarControl("entrada");
        }

        private void btnSalidaMateriaPrima_Click(object sender, EventArgs e)
        {
            ActivarControl("salida");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivarControl("dashboard");
        }
    }
}
