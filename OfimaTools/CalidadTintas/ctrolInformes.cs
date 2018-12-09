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
using System.Threading;

namespace CalidadTintas
{
    public partial class ctrolInformes : UserControl
    {
        private OfimaticaDBContext _dbconexion;
        public ctrolInformes()
        {
            InitializeComponent();
        }
        public ctrolInformes(ref OfimaticaDBContext dbConexion)
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            _dbconexion = dbConexion;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            grid.DataSource=_dbconexion.ufnControlCalidadTintas_TinterosDetalle(txtPedido.Text, dtIni.Value, dtFin.Value).ToList();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "csv FlatFile|*.csv";
            guardarArchivo.Title = "Guardar un archivo plano tipo .CSV";
            guardarArchivo.ShowDialog();
            PlanoIntegracion(guardarArchivo.FileName);


        }


        private void PlanoIntegracion(string NombreArchivo)
        {
            string _rutaPreintegracion = "";
            string _linea = "";
            StringBuilder cadena;
            cadena = new StringBuilder();
            //char separadorLista = Convert.ToChar(Thread.CurrentThread.CurrentCulture.TextInfo.ListSeparator);
            char separadorLista = ';';
            _rutaPreintegracion = NombreArchivo;
            try
            {
                using (System.IO.StreamWriter w = System.IO.File.AppendText(_rutaPreintegracion))
                {
                    cadena.Clear();
                    Log("OrdenNro;Fecha;Modifico;Aprobado;TintaT1;StickT1;AniloxT1;ViscoT1;TintaT2;StickT2;AniloxT2;ViscoT2;TintaT3;StickT3;AniloxT3;ViscoT3;TintaT4;StickT4;AniloxT4;ViscoT4;TintaT5;StickT5;AniloxT5;ViscoT5;TintaT6;StickT6;AniloxT6;ViscoT6;TintaT7;StickT7;AniloxT7;ViscoT7;TintaT8;StickT8;AniloxT8;ViscoT8", w);

                    foreach (ufnControlCalidadTintas_TinterosDetalleResult obj in _dbconexion.ufnControlCalidadTintas_TinterosDetalle(txtPedido.Text, dtIni.Value, dtFin.Value))
                    {
                        cadena.Clear();
                        cadena.Append(string.Format("{0}{4}{1}{4}{2}{4}{3}{4}", obj.OrdenNro, obj.Fecha, obj.Modifico, obj.Aprobado,separadorLista));
                        cadena.Append(string.Format("{0}{4}{1}{4}{2}{4}{3}{4}", obj.TintaT1, obj.ViscoT1, obj.AniloxT1, obj.StickT1, separadorLista));
                        cadena.Append(string.Format("{0}{4}{1}{4}{2}{4}{3}{4}", obj.TintaT2, obj.ViscoT2, obj.AniloxT2, obj.StickT2, separadorLista));
                        cadena.Append(string.Format("{0}{4}{1}{4}{2}{4}{3}{4}", obj.TintaT3, obj.ViscoT3, obj.AniloxT3, obj.StickT3, separadorLista));
                        cadena.Append(string.Format("{0}{4}{1}{4}{2}{4}{3}{4}", obj.TintaT4, obj.ViscoT4, obj.AniloxT4, obj.StickT4, separadorLista));
                        cadena.Append(string.Format("{0}{4}{1}{4}{2}{4}{3}{4}", obj.TintaT5, obj.ViscoT5, obj.AniloxT5, obj.StickT5, separadorLista));
                        cadena.Append(string.Format("{0}{4}{1}{4}{2}{4}{3}{4}", obj.TintaT6, obj.ViscoT6, obj.AniloxT6, obj.StickT6, separadorLista));
                        cadena.Append(string.Format("{0}{4}{1}{4}{2}{4}{3}{4}", obj.TintaT7, obj.ViscoT7, obj.AniloxT7, obj.StickT7, separadorLista));
                        cadena.Append(string.Format("{0}{4}{1}{4}{2}{4}{3}{4}", obj.TintaT8, obj.ViscoT8, obj.AniloxT8, obj.StickT8, separadorLista));
                        Log(cadena.ToString(), w);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Integración Contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(string.Format("Documento de preintegración generado: {0}.", _rutaPreintegracion), "Integración Contable", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void Log(string logMessage, System.IO.TextWriter w)
        {
            w.WriteLine(logMessage);
        }

    }
}
