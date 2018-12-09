using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace migrarDatosContables
{
    public partial class frmMain : Form
    {
        public enum Opcion { Causacion_Plasmar, Causacion_Gerencia, Migracion_Empleados }
        public Opcion _opcion { get; set; }
        public dbOfimaticaDataContext dbConexion;
        Properties.Settings config = new Properties.Settings();
        string _windowString;
        //dbOfimaticaDataContext db;
        public frmMain()
        {

            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            gerencia.RutaArchivoIntegracion = config.Rutapreintegracion;
            gerencia.integrar = config.Integrar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Argumentos = Environment.GetCommandLineArgs();
            if (Argumentos.Length > 1)
            {
                dbConexion = new dbOfimaticaDataContext();
                dbConexion = new dbOfimaticaDataContext(BuildConnectionString(config.Servidor, Argumentos[2]));
                gerencia.dbConexion = dbConexion;
                _windowString = string.Format(" [DB: {0} - Usuario: {1}]", Argumentos[2].ToUpper(), Argumentos[3].ToUpper());
            }
            else
            {
                dbConexion = new dbOfimaticaDataContext(BuildConnectionString(config.Servidor, config.defaultDB));
                _windowString = string.Format("[DB: {0} - Usuario: Default]", config.defaultDB);
            }

            titulo.Text=_windowString;


        }

        #region Modificar cadena de conexion
        private String BuildConnectionString(String DataSource, String Database)
        {
            //Data Source=hestia;Initial Catalog=PLASMARSA;Persist Security Info=True;User ID=ofimatica;Password=ofimatica
            String connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID=ofimatica;Password=ofimatica", DataSource, Database);
            return connString;
        }
        #endregion
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            titulo2.Text = "Causacion Nomina Plasmar";
            _opcion = Opcion.Causacion_Plasmar;
            gerencia.Enabled = true;
            gerencia.Borrargrid();
            gerencia.Opcion_Seleccionada = _opcion.ToString();
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            titulo2.Text = "Causacion nomina Gerencia";
            _opcion = Opcion.Causacion_Gerencia;
            gerencia.Enabled = true;
            gerencia.Borrargrid();
            gerencia.Opcion_Seleccionada = _opcion.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            titulo2.Text = "Cargar nuevos empleados";
            _opcion = Opcion.Migracion_Empleados;
            gerencia.Enabled = true;
            gerencia.Borrargrid();
            gerencia.Opcion_Seleccionada = _opcion.ToString();
        }

        private void MigrarDatos(Opcion Opcion)
        {

        }

        private void gerencia_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gerencia_Load_1(object sender, EventArgs e)
        {

        }
    }
}
