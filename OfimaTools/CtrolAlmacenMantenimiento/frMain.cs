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

namespace CtrolAlmacenMantenimiento
{
    public partial class frMain : Form
    {
        ctrolEntradaRepuesto _entrada;
        ctrolSalidaRepuesto _salida;
        ctrolProyecto _proyecto;
        ctrolMaquina _maquina;
        ctrolTecnico _tecnico;
        ctrolRegistro _registro;
        ctrolInventario _inventario;
        OfimaticaDBContext dbConn;
        System.Threading.Thread hilo;
        System.Threading.ThreadStart delegado;
        Properties.Settings configuracion = new Properties.Settings();
        public List<Proveedor> maestroProveedores;
        public List<Repuesto> maestroRepuestos;
        public List<Tecnico> maestroTecnicos;

        public frMain()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
        }

        private void frMain_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Bienvenido!";
            string[] Argumentos = Environment.GetCommandLineArgs();
            if (Argumentos.Length > 1)
            {
                dbConn = new OfimaticaDBContext();
                dbConn = new OfimaticaDBContext(ModificarDBConexion(configuracion.servidor, Argumentos[2], configuracion.user, configuracion.pass));
                lblUsuario.Text = Argumentos[3].ToUpper();
                lblDatabase.Text = Argumentos[2].ToUpper();
            }
            else
            {
                dbConn = new OfimaticaDBContext(ModificarDBConexion(configuracion.servidor, configuracion.db, configuracion.user, configuracion.pass));
                lblUsuario.Text = configuracion.user;
                lblDatabase.Text = configuracion.db.ToUpper();
            }
            //ActivarControl("entrada");
            delegado = new System.Threading.ThreadStart(LlenarMaestros);
            hilo = new System.Threading.Thread(LlenarMaestros);
            hilo.Start();
            
        }

        #region Modificar cadena de conexion
        private String ModificarDBConexion(String Servidor, String Database, string DBUser, string DBPassword)
        {
            //Data Source=hestia;Initial Catalog=PLASMARSA;Persist Security Info=True;User ID=ofimatica;Password=ofimatica
            String connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", Servidor, Database, DBUser, DBPassword);
            return connString;
        }
        #endregion

        
        private void LlenarMaestros()
        {
            maestroTecnicos = dbConn.ExecuteQuery<Tecnico>("SELECT v.cod_recurso,v.Nombre_Completo FROM dbo.vUsrGosem_ghPlasmar_rhRecursos v").ToList();
            maestroRepuestos = dbConn.ExecuteQuery<Repuesto>("SELECT rtrim(m.CODIGO) as Codigo,rtrim(m.DESCRIPCIO) as Descripcio FROM dbo.MTMERCIA m(nolock) WHERE m.TIPOINV in ('MTTO','ADMON') AND m.HABILITADO=1").ToList();
            maestroProveedores = dbConn.ExecuteQuery<Proveedor>("SELECT rtrim(m.NIT) as Nit,rtrim(m.NOMBRE) as Nombre FROM dbo.MTPROCLI m(nolock) WHERE m.ESPROVEE='S'").ToList();
        }

        private void ActivarControl(string Nombre_Control)
        {
            pControl.Controls.Clear();
            switch (Nombre_Control)
            {
                case "entrada":
                    lblTitulo.Text = "Entrada de Repuestos";
                    _entrada = new ctrolEntradaRepuesto(ref dbConn, ref maestroProveedores,ref maestroRepuestos, ref maestroTecnicos);
                    pControl.Controls.Add(_entrada);
                    _entrada.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._entrada.Location = new System.Drawing.Point(6, 3);
                    this._entrada.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._entrada.Name = "control";
                    this._entrada.Size = new System.Drawing.Size(874, 478);
                    this._entrada.TabIndex = 1;
                    _salida = null;
                    _tecnico = null;
                    _maquina = null;
                    _proyecto = null;
                    _registro = null;
                    _inventario = null;

                    break;
                case "salida":
                    lblTitulo.Text = "Salida de Repuestos";
                    _salida = new ctrolSalidaRepuesto(ref dbConn, ref maestroProveedores, ref maestroRepuestos, ref maestroTecnicos);
                    pControl.Controls.Add(_salida);
                    _salida.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._salida.Location = new System.Drawing.Point(6, 3);
                    this._salida.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._salida.Name = "control";
                    this._salida.Size = new System.Drawing.Size(874, 478);
                    this._salida.TabIndex = 1;
                    _entrada = null;
                    _tecnico = null;
                    _maquina = null;
                    _proyecto = null;
                    _registro = null;
                    _inventario = null;
                    break;
                case "maquina":
                    lblTitulo.Text = "Maestro de Máquinas";
                    _maquina = new ctrolMaquina(ref dbConn);
                    pControl.Controls.Add(_maquina);
                    _maquina.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._maquina.Location = new System.Drawing.Point(6, 3);
                    this._maquina.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._maquina.Name = "control";
                    this._maquina.Size = new System.Drawing.Size(874, 478);
                    this._maquina.TabIndex = 1;
                    _entrada = null;
                    _salida = null;
                    _proyecto = null;
                    _tecnico = null;
                    _registro = null;
                    _inventario = null;

                    break;

                case "tecnico":
                    lblTitulo.Text = "Maestro de Técnicos";
                    _tecnico = new ctrolTecnico(ref dbConn);
                    pControl.Controls.Add(_tecnico);
                    pControl.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._tecnico.Location = new System.Drawing.Point(6, 3);
                    this._tecnico.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._tecnico.Name = "control";
                    this._tecnico.Size = new System.Drawing.Size(874, 478);
                    this._tecnico.TabIndex = 1;
                    _entrada = null;
                    _salida = null;
                    _proyecto = null;
                    _maquina = null;
                    _registro = null;
                    _inventario = null;
                    break;

                case "proyecto":
                    lblTitulo.Text = "Maestro de Proyectos";
                    _proyecto = new ctrolProyecto(ref dbConn);
                    pControl.Controls.Add(_proyecto);
                    _proyecto.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._proyecto.Location = new System.Drawing.Point(6, 3);
                    this._proyecto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._proyecto.Name = "control";
                    this._proyecto.Size = new System.Drawing.Size(874, 478);
                    this._proyecto.TabIndex = 1;
                    _entrada = null;
                    _salida = null;
                    _maquina = null;
                    _tecnico = null;
                    _registro = null;
                    _inventario = null;
                    break;

                case "registro":
                    lblTitulo.Text = "Detalle Ingreso/Salida de Repuestos";
                    _registro = new ctrolRegistro(ref dbConn, ref  maestroProveedores, ref maestroRepuestos);
                    pControl.Controls.Add(_registro);
                    _registro.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._registro.Location = new System.Drawing.Point(6, 3);
                    this._registro.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._registro.Name = "control";
                    this._registro.Size = new System.Drawing.Size(874, 478);
                    this._registro.TabIndex = 1;
                    _entrada = null;
                    _salida = null;
                    _maquina = null;
                    _proyecto = null;
                    _tecnico = null;
                    _inventario = null;

                    break;
                case "inventario":
                    lblTitulo.Text = "Saldo de Repuestos";
                    _inventario = new ctrolInventario(ref dbConn);
                    pControl.Controls.Add(_inventario);
                    _inventario.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._inventario.Location = new System.Drawing.Point(6, 3);
                    this._inventario.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._inventario.Name = "control";
                    this._inventario.Size = new System.Drawing.Size(874, 478);
                    this._inventario.TabIndex = 1;
                    _registro = null;
                    _entrada = null;
                    _salida = null;
                    _maquina = null;
                    _proyecto = null;
                    _tecnico = null;

                    break;
                default:
                    lblTitulo.Text = "Entrada de Repuestos";
                    _entrada = new ctrolEntradaRepuesto(ref dbConn,ref maestroProveedores, ref maestroRepuestos,ref maestroTecnicos);
                    pControl.Controls.Add(_entrada);
                    _entrada.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._entrada.Location = new System.Drawing.Point(6, 3);
                    this._entrada.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._entrada.Name = "control";
                    this._entrada.Size = new System.Drawing.Size(874, 478);
                    this._entrada.TabIndex = 1;
                    _salida = null;
                    _tecnico = null;
                    _maquina = null;
                    _proyecto = null;

                    break;
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            ActivarControl("entrada");
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            ActivarControl("salida");
        }

        private void btnMaquina_Click(object sender, EventArgs e)
        {
            ActivarControl("maquina");
        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            ActivarControl("proyecto");
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            ActivarControl("tecnico");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            ActivarControl("registro");
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ActivarControl("inventario");
        }
    }
    public class Repuesto
    {
        public string Codigo { get; set; }
        public string Descripcio { get; set; }
    }
    public class Proveedor
    {
        public string Nit {get; set; }
        public string Nombre {get; set; }
    }
    public class Proyecto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
    public class Maquina
    {
        public Int32 IdReg { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string CentroCostos { get; set; }
    }
    public class Tecnico
    {
        //public string Cedula { get; set; }
        //public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Roll { get; set; }
    }
    public class ItemOrdenCompra
    {
        public string Nit { get; set; }
        public string Fecha { get; set; }
        public string NroDcto { get; set; }
        public string CodigoRepuesto { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Valor_Unitario { get; set; }
    }
    public class DetalleSaldoInventario
    {
        public string CodLinea { get; set; }
        public string Linea { get; set; }
        public string Repuesto { get; set; }
        public string Descripcion { get; set; }
        public decimal Entradas { get; set; }
        public decimal Salidas { get; set; }
        public  decimal Saldo { get; set; }
        public string Detalle { get; set; }

    }
    public class DetalleConsumo
    {
        public int idmov { get; set; }
        public DateTime fecha { get; set; }
        public string tecnico { get; set; }
        public string orden     { get; set; }
        public string factura { get; set; }
        public string tipomvto { get; set; }
        public decimal entrada { get; set; }
        public decimal salida { get; set; }
    }

}
