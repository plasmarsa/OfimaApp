using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using Dataccess;

namespace CtrolAlmacenMantenimiento
{
    public partial class ctrolInventario : UserControl
    {
        protected OfimaticaDBContext _dbConn;
        public bool actualizarGrid;
        public ctrolInventario()
        {
            InitializeComponent();
        }
        public ctrolInventario(ref OfimaticaDBContext dbConn )
        {
            InitializeComponent();
            _dbConn = dbConn;
        }

        private void ctrolInventario_Load(object sender, EventArgs e)
        {


            ConsultarInventario();
        }
        private void ConsultarInventario()
        {
            List<DetalleSaldoInventario> detallesInventarios = new List<DetalleSaldoInventario>();
            gridMov.Rows.Clear();
            string query;
            query = "SELECT v.CodLinea,v.Linea,V.Repuesto,V.Descripcion,v.Entradas,v.Salidas,v.Saldo,v.Detalle FROM dbo.vUsrMantenSaldoRepuestos AS V";
            detallesInventarios = _dbConn.ExecuteQuery<DetalleSaldoInventario>(query).ToList();
            foreach (DetalleSaldoInventario detalle in detallesInventarios)
            {
                gridMov.Rows.Add(new object[] { detalle.CodLinea, detalle.Linea, detalle.Repuesto, detalle.Descripcion, detalle.Entradas,detalle.Salidas,detalle.Saldo, detalle.Detalle });
            }
        }
        private void ConsultarInventario(string linea,string repuesto)
        {
            List<DetalleSaldoInventario> detallesInventarios = new List<DetalleSaldoInventario>();
            gridMov.Rows.Clear();
            string query;
            query = string.Format("SELECT v.CodLinea,v.Linea,V.Repuesto,V.Descripcion,v.Entradas,v.Salidas,v.Saldo,v.Detalle FROM dbo.vUsrMantenSaldoRepuestos " +
                "AS V WHERE (V.Linea LIKE '%{0}%' OR '%{0}%'='') AND (V.Repuesto LIKE '%{1}%' OR '%{1}%'='') ORDER BY V.Linea,V.Descripcion", linea,repuesto);
            detallesInventarios = _dbConn.ExecuteQuery<DetalleSaldoInventario>(query).ToList();
            foreach (DetalleSaldoInventario detalle in detallesInventarios)
            {
                gridMov.Rows.Add(new object[] { detalle.CodLinea, detalle.Linea, detalle.Repuesto, detalle.Descripcion,detalle.Entradas,detalle.Salidas, detalle.Saldo, detalle.Detalle });
            }
        }
        private void cmbLinea_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbLinea.Text;
            string query;
            query = string.Format("SELECT DISTINCT V.CodLinea,V.Linea,'' AS Repuesto,'' AS Descripcion,cast(0 as decimal) AS Saldo,'' " +
                "AS Detalle FROM dbo.vUsrMantenSaldoRepuestos AS V WHERE V.Linea LIKE '%{0}%'", filter_param);
            List<DetalleSaldoInventario> filteredItems = _dbConn.ExecuteQuery<DetalleSaldoInventario>(query).ToList();
            cmbLinea.DataSource = null;
            cmbLinea.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbLinea.DataSource = _dbConn.ExecuteQuery<DetalleSaldoInventario>("SELECT DISTINCT V.CodLinea,V.Linea,'' AS Repuesto,'' AS Descripcion,cast(0 as decimal) AS Saldo," +
                    "'' AS Detalle FROM dbo.vUsrMantenSaldoRepuestos AS V order by v.Linea").ToList();
            }
            Cursor.Current = Cursors.Default;
            cmbLinea.ItemHeight = 100;
            cmbLinea.DisplayMember = "Linea";
            cmbLinea.ValueMember = "CodLinea";
            cmbLinea.MaxDropDownItems = 8;
            cmbLinea.SelectedIndex = -1;
            cmbLinea.DroppedDown = true;
            cmbLinea.Text = filter_param;
            cmbLinea.SelectionLength = filter_param.Length;
            cmbLinea.Select(filter_param.Length, 0);
            ConsultarInventario(cmbLinea.Text, cmbProducto.Text);
        }

        private void cmbProducto_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbProducto.Text;
            string query;
            query = string.Format("SELECT DISTINCT '' AS CodLinea,'' AS Linea,V.Repuesto,V.Descripcion,cast(0 as decimal) AS Saldo,'' AS Detalle FROM dbo.vUsrMantenSaldoRepuestos AS V WHERE (V.Linea= '{0}' or '{0}'='') AND V.Repuesto LIKE '%{1}%'",cmbLinea.Text, filter_param);
            List<DetalleSaldoInventario> filteredItems = _dbConn.ExecuteQuery<DetalleSaldoInventario>(query).ToList();
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = filteredItems;


            if (String.IsNullOrWhiteSpace(filter_param))
            {
                query = string.Format("SELECT DISTINCT '' AS CodLinea,'' AS Linea,V.Repuesto,V.Descripcion,cast(0 as decimal) AS Saldo,'' AS Detalle FROM dbo.vUsrMantenSaldoRepuestos AS V WHERE (V.Linea = '{0}' or '{0}'='')", cmbLinea.Text);
                cmbProducto.DataSource = _dbConn.ExecuteQuery<DetalleSaldoInventario>(query).ToList();
            }
            Cursor.Current = Cursors.Default;
            cmbProducto.ItemHeight = 100;
            cmbProducto.DisplayMember = "Repuesto";
            cmbProducto.ValueMember = "Descripcion";
            cmbProducto.MaxDropDownItems = 8;
            cmbProducto.SelectedIndex = -1;
            cmbProducto.DroppedDown = true;
            cmbProducto.Text = filter_param;
            cmbProducto.SelectionLength = filter_param.Length;
            cmbProducto.Select(filter_param.Length, 0);
            ConsultarInventario(cmbLinea.Text,cmbProducto.Text);
            
        }

        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLinea.SelectedIndex!=-1)
                ConsultarInventario(cmbLinea.Text, cmbProducto.Text);
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1)
                ConsultarInventario(cmbLinea.Text, cmbProducto.Text);
        }

        private void gridMov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["detalle"].Index && e.RowIndex >= 0)
            {
                string repuesto = senderGrid.Rows[e.RowIndex].Cells["repuesto"].Value.ToString().TrimEnd();
                string descripcionrepuesto = senderGrid.Rows[e.RowIndex].Cells["descripcion"].Value.ToString().TrimEnd();
                string codlinea = senderGrid.Rows[e.RowIndex].Cells["codlinea"].Value.ToString().TrimEnd();
                string linea = senderGrid.Rows[e.RowIndex].Cells["linea"].Value.ToString().TrimEnd();


                if (!string.IsNullOrWhiteSpace(repuesto))
                {
                    frmSaldoDetalle detalle = new frmSaldoDetalle(ref _dbConn, codlinea, linea, repuesto, descripcionrepuesto);
                    detalle.StartPosition = FormStartPosition.CenterScreen;
                    detalle.Show();
                }



            }
        }
        public static void Log(string logMessage, System.IO.TextWriter w)
        {
            w.WriteLine(logMessage);
            //w.Write("\r\nLog Entry : ");
            //w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            //    DateTime.Now.ToLongDateString());
            //w.WriteLine("  :");
            //w.WriteLine("  :{0}", logMessage);
            //w.WriteLine("-------------------------------");
        }
        private void GenReporteSaldosRepuestos()
        {

            string _linea = "";
            char separadorLista = Convert.ToChar(Thread.CurrentThread.CurrentCulture.TextInfo.ListSeparator);
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "csv FlatFile|*.csv";
            guardarArchivo.Title = "Guardar un archivo plano tipo .CSV";
            guardarArchivo.ShowDialog();

            try
            {

                if (guardarArchivo.FileName != "")
                {
                    using (System.IO.StreamWriter w = System.IO.File.AppendText(guardarArchivo.FileName))
                    {
                        Log("Saldo inventario Repuestos a " + DateTime.Now.ToString(), w);
                        //Log("Cod_Linea;Linea;Cod_Repuesto;Desc_Repuesto;Entradas;Salidas;Saldo", w);
                        Log(string.Format("Cod_Linea{0}Linea{0}Cod_Repuesto{0}Desc_Repuesto{0}Entradas{0}Salidas{0}Saldo", separadorLista), w);
                        foreach (DataGridViewRow linea in gridMov.Rows)
                        {
                            string codlinea = linea.Cells[0].Value.ToString();
                            string desclinea = linea.Cells[1].Value.ToString();
                            string repuesto = linea.Cells[2].Value.ToString();
                            string descripcionRepuesto = linea.Cells[3].Value.ToString();
                            string entradas = linea.Cells[4].Value.ToString();
                            string salidas = linea.Cells[5].Value.ToString();
                            string saldo = linea.Cells[6].Value.ToString();
                            _linea = string.Format("{0}{7}_{1}{7}{2}{7}{3}{7}{4}{7}{5}{7}{6}", codlinea, desclinea, repuesto, descripcionRepuesto, entradas, salidas, saldo, separadorLista);
                            Log(_linea, w);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Generar archivo plano tipo .scv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(string.Format("Archivo generado {0}.", guardarArchivo.FileName), "Archivo de saldos Repuestos Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenExcel_Click(object sender, EventArgs e)
        {
            if (gridMov.Rows.Count > 0)
            {
                GenReporteSaldosRepuestos();
            }
        }

        //public static void Log(string logMessage, System.IO.TextWriter w)
        //{
        //    w.WriteLine(logMessage);

        //    //w.Write("\r\nLog Entry : ");
        //    //w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
        //    //    DateTime.Now.ToLongDateString());
        //    //w.WriteLine("  :");
        //    //w.WriteLine("  :{0}", logMessage);
        //    //w.WriteLine("-------------------------------");
        //}
        //private void GenReporteSaldosRepuestos()
        //{
           
        //    string _linea = "";
        //    char separadorLista= Convert.ToChar(Thread.CurrentThread.CurrentCulture.TextInfo.ListSeparator);

        //    SaveFileDialog guardarArchivo = new SaveFileDialog();
        //    guardarArchivo.Filter = "csv FlatFile|*.csv";
        //    guardarArchivo.Title = "Guardar un archivo plano tipo .CSV";
        //    guardarArchivo.ShowDialog();
            
        //    try
        //    {
                
        //        if (guardarArchivo.FileName!="")
        //        {
        //            using (System.IO.StreamWriter w = System.IO.File.AppendText(guardarArchivo.FileName))
        //            {
        //                Log("Saldo inventario Repuestos a " + DateTime.Now.ToString(), w);
        //                //Log("Cod_Linea;Linea;Cod_Repuesto;Desc_Repuesto;Entradas;Salidas;Saldo", w);
        //                Log(string.Format("Cod_Linea{0}Linea{0}Cod_Repuesto{0}Desc_Repuesto{0}Entradas{0}Salidas{0}Saldo", separadorLista), w);

        //                foreach (DataGridViewRow linea in gridMov.Rows)
        //                {
        //                    string codlinea = linea.Cells[0].Value.ToString();
        //                    string desclinea = linea.Cells[1].Value.ToString();
        //                    string repuesto = linea.Cells[2].Value.ToString();
        //                    string descripcionRepuesto = linea.Cells[3].Value.ToString();
        //                    string entradas = linea.Cells[4].Value.ToString();
        //                    string salidas = linea.Cells[5].Value.ToString();
        //                    string saldo = linea.Cells[6].Value.ToString();
        //                    _linea = string.Format("{0}{7}_{1}{7}{2}{7}{3}{7}{4}{7}{5}{7}{6}", codlinea, desclinea, repuesto, descripcionRepuesto, entradas, salidas, saldo,separadorLista);
        //                    Log(_linea, w);
        //                }
        //            }
        //        }
                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Generar archivo plano tipo .scv", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    MessageBox.Show(string.Format("Archivo generado {0}.", guardarArchivo.FileName), "Archivo de saldos Repuestos Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if(gridMov.Rows.Count>0)
            {
                GenReporteSaldosRepuestos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cmbProducto_TextUpdate(null,null);
        }
    }

}
