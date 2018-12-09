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
    public partial class ctrolMaquina : UserControl
    {
        OfimaticaDBContext _dbConn;
        public ctrolMaquina()
        {
            InitializeComponent();
        }
        public ctrolMaquina(ref OfimaticaDBContext dbconn)
        {
            InitializeComponent();
            _dbConn = dbconn;
            ConsultarMaquinas();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CrearMaquina(txtCodigo.Text, txtMaquina.Text);
        }

        private void CrearMaquina(string codMaquina, string Nombre)
        {
            tblMantenMaquinas maquina = new tblMantenMaquinas();
            maquina = _dbConn.tblMantenMaquinas.Where(x => x.CodMaquina == codMaquina).SingleOrDefault();
            if (maquina == null)
            {
                maquina = new tblMantenMaquinas();
                maquina.CodMaquina = codMaquina;
                maquina.Nombre = Nombre;
                maquina.CodCC = _dbConn.CENTCOS.Where(x => x.NOMBRE == cmbCentCos.Text).Select(s => s.CODCC.TrimEnd()).SingleOrDefault();
                _dbConn.tblMantenMaquinas.InsertOnSubmit(maquina);
            }
            else
            {
                maquina.Nombre = Nombre;
                maquina.CodCC = _dbConn.CENTCOS.Where(x=>x.NOMBRE==cmbCentCos.Text).Select(s=>s.CODCC.TrimEnd()).SingleOrDefault();
            }
            _dbConn.SubmitChanges();
            grid.Rows.Clear();
            grid.Refresh();
            ConsultarMaquinas();
        }


        private void ConsultarMaquinas()
        {
            List<Maquina> listaMaquinas = _dbConn.ExecuteQuery<Maquina>("SELECT m.IdReg, m.CodMaquina as Codigo, m.Nombre as Descripcion, m.CodCC as CentroCostos FROM dbo.tblMantenMaquinas m(nolock) order by 3").ToList();
            if(listaMaquinas!=null)
            {
                foreach(Maquina m in listaMaquinas)
                {
                 grid.Rows.Add(new object[] { m.IdReg, m.Codigo, m.Descripcion, BuscarCentroCostos(m.CentroCostos) });
                    //grid.Rows.Add(new object[] { m.IdReg, m.Codigo, m.Descripcion, BuscarCentroCostos(m.CentroCostos) });
                }
            }

            txtCodigo.Text = "";
            txtMaquina.Text = "";
            cmbCentCos.Text = "";
        }

        private void EliminarMaquina(string codMaquina)
        {
            tblMantenMaquinas maquina = new tblMantenMaquinas();
            maquina = _dbConn.tblMantenMaquinas.Where(x => x.CodMaquina == codMaquina).SingleOrDefault();

            if (maquina != null)
            {
                _dbConn.tblMantenMaquinas.DeleteOnSubmit(maquina);
                _dbConn.SubmitChanges();

            }
            ConsultarMaquinas();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMaquina(txtCodigo.Text);
        }
       

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtCodigo.Text = grid.CurrentCell.RowIndex.ToString();
            txtCodigo.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtMaquina.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[2].Value.ToString();
            lblCodCC.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[3].Value.ToString();
            cmbCentCos.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(grid.Rows[grid.CurrentCell.RowIndex].Cells[1].Value != null)
            {
                txtCodigo.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells["codmaquina"].Value.ToString();
                txtMaquina.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells["nombre"].Value.ToString();
                //cmbCentCos.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells["codcc"].Value.ToString();
                cmbCentCos.Text=grid.Rows[grid.CurrentCell.RowIndex].Cells["codcc"].Value.ToString();
            }

        }

        private string BuscarCentroCostos(string codCC)
        {
            string nombreCentroCostos;
            nombreCentroCostos= _dbConn.CENTCOS.Where(x => x.CODCC == codCC).Select(s => s.NOMBRE.TrimEnd()).SingleOrDefault();
            if (string.IsNullOrWhiteSpace(nombreCentroCostos))
                nombreCentroCostos = "";
            return nombreCentroCostos;
        }

        private void cmbCentCos_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbCentCos.Text;

            List<CENTCOS> filteredItems = _dbConn.ExecuteQuery<CENTCOS>(string.Format("SELECT c.AUXILIAR, c.CAPACIDAD, RTRIM(c.CODCC) AS CODCC, c.NIT, RTRIM(c.NOMBRE) AS NOMBRE, c.STADSINCRO, c.NITFABRICA, c.TIPO FROM dbo.CENTCOS AS C WHERE C.NOMBRE NOT LIKE '%obsoleto%' AND C.NOMBRE LIKE '%{0}%' and len(c.codcc)=4", filter_param)).ToList();
            cmbCentCos.DataSource = null;
            cmbCentCos.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbCentCos.DataSource = _dbConn.ExecuteQuery<CENTCOS>("SELECT c.AUXILIAR, c.CAPACIDAD, RTRIM(c.CODCC) AS CODCC, c.NIT, RTRIM(c.NOMBRE) AS NOMBRE, c.STADSINCRO, c.NITFABRICA, c.TIPO FROM dbo.CENTCOS AS C WHERE C.NOMBRE NOT LIKE '%obsoleto%' and len(codcc)=4").ToList(); ;
            }
            Cursor.Current = Cursors.Default;
            cmbCentCos.ItemHeight = 100;
            cmbCentCos.DisplayMember = "NOMBRE";
            cmbCentCos.ValueMember = "CODCC";
            cmbCentCos.MaxDropDownItems = 8;
            cmbCentCos.SelectedIndex = -1;
            cmbCentCos.DroppedDown = true;
            cmbCentCos.Text = filter_param;
            cmbCentCos.SelectionLength = filter_param.Length;
            cmbCentCos.Select(filter_param.Length, 0);
        }

        private void ctrolMaquina_Load(object sender, EventArgs e)
        {

        }

        
    }
}
