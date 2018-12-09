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
    public partial class frmMain : Form
    {
        Properties.Settings _configuracion = new Properties.Settings();
        public OfimaticaDBContext _dbConexion;
        private ctrolProceso _ctrolproceso;
        private ctrolAprobado _ctrolaprobado;
        private ctrolAprobadoLista _ctrolAprobadoLista;
        private ctrolDashboard _ctroldashboard;
        private ctrolAnilox _ctrolAnilox;
        private ctrolSticker _ctrolSticker;
        private ctrolPersonal _ctrolPersonal;
        private ctrolInformes _ctrolInformes;
        //private  _ctrolregistro;
        public frmMain()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
        }

        private void frmMain_Load(object sender, EventArgs e)
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
            ActivarControl("dashboard");
        }


        #region Modificar cadena de conexion
        private String ModificarDBConexion(String Servidor, String Database, string DBUser, string DBPassword)
        {
            //Data Source=hestia;Initial Catalog=PLASMARSA;Persist Security Info=True;User ID=ofimatica;Password=ofimatica
            String connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", Servidor, Database, DBUser, DBPassword);
            return connString;
        }
        #endregion


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ActivarControl(string Nombre_Control)
        {
            pControl.Controls.Clear();
            switch (Nombre_Control)
            {
                case "dashboard":
                    lblTitulo.Text = "DASHBOARD";
                    _ctroldashboard = new ctrolDashboard(ref _dbConexion);
                    pControl.Controls.Add(_ctroldashboard);
                    _ctroldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctroldashboard.Location = new System.Drawing.Point(6, 3);
                    this._ctroldashboard.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctroldashboard.Name = "control";
                    this._ctroldashboard.Size = new System.Drawing.Size(874, 478);
                    this._ctroldashboard.TabIndex = 1;
                    _ctrolaprobado = null;
                    _ctrolproceso = null;
                    _ctrolInformes = null;

                    break;
                case "proceso":
                    lblTitulo.Text = "CONTROLES EN PROCESO";
                    _ctrolproceso = new ctrolProceso(ref _dbConexion,_configuracion.LoteObligatorio);
                    pControl.Controls.Add(_ctrolproceso);
                    _ctrolproceso.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolproceso.Location = new System.Drawing.Point(6, 3);
                    this._ctrolproceso.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolproceso.Name = "control";
                    this._ctrolproceso.Size = new System.Drawing.Size(874, 478);
                    this._ctrolproceso.TabIndex = 1;
                    _ctroldashboard = null;
                    _ctrolaprobado = null;
                    _ctrolAnilox = null;
                    _ctrolSticker = null;
                    _ctrolInformes = null;
                    break;
                case "aprobado":
                    lblTitulo.Text = "CONTROLES APROBADOS";
                    _ctrolAprobadoLista = new ctrolAprobadoLista(ref _dbConexion);
                    pControl.Controls.Add(_ctrolAprobadoLista);
                    _ctrolAprobadoLista.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolAprobadoLista.Location = new System.Drawing.Point(6, 3);
                    this._ctrolAprobadoLista.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolAprobadoLista.Name = "control";
                    this._ctrolAprobadoLista.Size = new System.Drawing.Size(874, 478);
                    this._ctrolAprobadoLista.TabIndex = 1;
                    _ctroldashboard = null;
                    _ctrolSticker = null;
                    _ctrolproceso = null;
                    _ctrolAnilox = null;
                    _ctrolaprobado = null;
                    _ctrolInformes = null;
                    break;

                case "anilox":
                    lblTitulo.Text = "MAESTRO DE ANILOX";
                    _ctrolAnilox = new ctrolAnilox(ref _dbConexion);
                    pControl.Controls.Add(_ctrolAnilox);
                    pControl.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolAnilox.Location = new System.Drawing.Point(6, 3);
                    this._ctrolAnilox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolAnilox.Name = "control";
                    this._ctrolAnilox.Size = new System.Drawing.Size(874, 478);
                    this._ctrolAnilox.TabIndex = 1;
                    _ctrolaprobado = null;
                    _ctroldashboard = null;
                    _ctrolSticker = null;
                    _ctrolproceso = null;
                    _ctrolInformes = null;
                    break;

                case "sticker":
                    lblTitulo.Text = "MAESTRO DE STICKER";
                    _ctrolSticker = new ctrolSticker(ref _dbConexion);
                    pControl.Controls.Add(_ctrolSticker);
                    _ctrolSticker.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolSticker.Location = new System.Drawing.Point(6, 3);
                    this._ctrolSticker.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolSticker.Name = "control";
                    this._ctrolSticker.Size = new System.Drawing.Size(874, 478);
                    this._ctrolSticker.TabIndex = 1;
                    _ctroldashboard = null;
                    _ctrolAnilox = null;
                    _ctrolproceso = null;
                    _ctrolaprobado = null;
                    _ctrolInformes = null;

                    break;
                case "pendiente_detalle":
                    lblTitulo.Text = "DETALLE CONTROL CALIDAD TINTAS PENDIENTE";
                    _ctrolSticker = new ctrolSticker(ref _dbConexion);
                    pControl.Controls.Add(_ctrolSticker);
                    _ctrolSticker.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolSticker.Location = new System.Drawing.Point(6, 3);
                    this._ctrolSticker.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolSticker.Name = "control";
                    this._ctrolSticker.Size = new System.Drawing.Size(874, 478);
                    this._ctrolSticker.TabIndex = 1;
                    _ctroldashboard = null;
                    _ctrolAnilox = null;
                    _ctrolproceso = null;
                    _ctrolaprobado = null;
                    _ctrolAprobadoLista = null;
                    _ctrolInformes = null;

                    break;
                case "aprobado_detalle":
                    lblTitulo.Text = "DETALLE CONTROL CALIDAD TINTAS APROBADO";
                    _ctrolaprobado = new ctrolAprobado(ref _dbConexion);
                    pControl.Controls.Add(_ctrolaprobado);
                    _ctrolaprobado.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolaprobado.Location = new System.Drawing.Point(6, 3);
                    this._ctrolaprobado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolaprobado.Name = "control";
                    this._ctrolaprobado.Size = new System.Drawing.Size(874, 478);
                    this._ctrolaprobado.TabIndex = 1;
                    _ctroldashboard = null;
                    _ctrolAnilox = null;
                    _ctrolproceso = null;
                    _ctrolAprobadoLista = null;
                    _ctrolInformes = null;

                    break;
                case "personal":
                    lblTitulo.Text = "PERSONAL AREA DE TINTAS";
                    _ctrolPersonal = new ctrolPersonal(ref _dbConexion);
                    pControl.Controls.Add(_ctrolPersonal);
                    _ctrolPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolPersonal.Location = new System.Drawing.Point(6, 3);
                    this._ctrolPersonal.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolPersonal.Name = "control";
                    this._ctrolPersonal.Size = new System.Drawing.Size(874, 478);
                    this._ctrolPersonal.TabIndex = 1;
                    _ctroldashboard = null;
                    _ctrolAnilox = null;
                    _ctrolproceso = null;
                    _ctrolAprobadoLista = null;
                    _ctrolaprobado = null;
                    _ctrolInformes = null;

                    break;
                case "informes":
                    lblTitulo.Text = "INFORMES";
                    _ctrolInformes = new ctrolInformes(ref _dbConexion);
                    pControl.Controls.Add(_ctrolInformes);
                    _ctrolInformes.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolInformes.Location = new System.Drawing.Point(6, 3);
                    this._ctrolInformes.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolInformes.Name = "control";
                    this._ctrolInformes.Size = new System.Drawing.Size(874, 478);
                    this._ctrolInformes.TabIndex = 1;
                    _ctroldashboard = null;
                    _ctrolAnilox = null;
                    _ctrolproceso = null;
                    _ctrolAprobadoLista = null;
                    _ctrolaprobado = null;
                    _ctrolPersonal = null;

                    break;

                default:
                    lblTitulo.Text = "DASHBOARD";
                    _ctroldashboard = new ctrolDashboard(ref _dbConexion);
                    pControl.Controls.Add(_ctroldashboard);
                    _ctroldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctroldashboard.Location = new System.Drawing.Point(6, 3);
                    this._ctroldashboard.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctroldashboard.Name = "control";
                    this._ctroldashboard.Size = new System.Drawing.Size(874, 478);
                    this._ctroldashboard.TabIndex = 1;
                    _ctrolaprobado = null;
                    _ctrolproceso = null;
                    _ctrolAnilox = null;
                    _ctrolSticker = null;
                    _ctrolInformes = null;

                    break;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivarControl("dashboard");
        }

        private void btnCtrolProceso_Click(object sender, EventArgs e)
        {
            ActivarControl("proceso");

        }

        private void btnCtrolAprobado_Click(object sender, EventArgs e)
        {
            ActivarControl("aprobado");
        }

        private void btnVisitantes_Click(object sender, EventArgs e)
        {
            ActivarControl("anilox");
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            ActivarControl("sticker");
        }

        private void btnAprobadoDetalle_Click(object sender, EventArgs e)
        {
            ActivarControl("aprobado_detalle");
        }

        private void btnPendienteDetalle_Click(object sender, EventArgs e)
        {
            ActivarControl("pendiente_detalle");
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            ActivarControl("informes");
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            ActivarControl("personal");
        }

        private void pControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class PersonalTintas
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Roll { get; set; }
    }
        

}
