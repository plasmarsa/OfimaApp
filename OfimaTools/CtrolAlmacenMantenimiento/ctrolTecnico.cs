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
    public partial class ctrolTecnico : UserControl
    {
        private OfimaticaDBContext _dbConn;
        public ctrolTecnico()
        {
            InitializeComponent();
        }
        public ctrolTecnico(ref OfimaticaDBContext dbconn)
        {
            InitializeComponent();
            _dbConn = dbconn;
            ConsultarTecnicos();
        }

        private void ctrolTecnico_Load(object sender, EventArgs e)
        {

        }
        private void CrearTecnico(string NombreTecnico, string roll)
        {
            tblMantenTecnico tecnico = new tblMantenTecnico();
            string cedulaTecnico = BuscarCedulaTecnico(NombreTecnico);
            if (string.IsNullOrWhiteSpace(cedulaTecnico))
            {
                cedulaTecnico = _dbConn.tblMantenTecnico.Where(x => x.OtroNombre == roll).Select(s => s.IdTecnico).SingleOrDefault();
            }

            tecnico = _dbConn.tblMantenTecnico.Where(x => x.IdTecnico == cedulaTecnico).SingleOrDefault();
            if (tecnico == null)
            {
                tecnico = new tblMantenTecnico();
                tecnico.IdTecnico = cedulaTecnico;
                tecnico.OtroNombre = roll;
                _dbConn.tblMantenTecnico.InsertOnSubmit(tecnico);
            }
            else
            {
                tecnico.OtroNombre = roll;
            }
            _dbConn.SubmitChanges();
            ConsultarTecnicos();
        }
        private string BuscarCedulaTecnico(string nombreTecnico)
        {
            return _dbConn.vUsrGosem_ghPlasmar_rhRecursos.Where(x => x.Nombre_Completo == nombreTecnico).Select(s => s.cod_recurso.Trim()).SingleOrDefault();
        }

        private void ConsultarTecnicos()
        {
            grid.DataSource = null;
            grid.DataSource = _dbConn.ExecuteQuery<Tecnico>("SELECT t.IdTecnico as Cedula,ISNULL(e.Nombre_Completo,t.OtroNombre) as Nombre,t.OtroNombre as Roll FROM dbo.tblMantenTecnico t left JOIN dbo.vUsrGosem_ghPlasmar_rhRecursos e ON t.IdTecnico=e.cod_recurso order by 2").ToList();
            grid.Refresh();
            cmbTecnico.Text = "";
            txtRoll.Text = "";
        }

        private void EliminarTecnico(string codMaquina)
        {
            tblMantenTecnico tecnico = new tblMantenTecnico();


            tecnico = _dbConn.tblMantenTecnico.Where(x => x.IdTecnico == BuscarCedulaTecnico(cmbTecnico.Text.TrimEnd())).SingleOrDefault();

            if (tecnico != null)
            {
                _dbConn.tblMantenTecnico.DeleteOnSubmit(tecnico);
                _dbConn.SubmitChanges();

            }
            else
            {
                MessageBox.Show("El técnico no puede ser eliminado..", "Eliminar técnico.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ConsultarTecnicos();

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbTecnico.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtRoll.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CrearTecnico(cmbTecnico.Text, txtRoll.Text);
        }

        private void cmbTecnico_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbTecnico.Text;
            //List<Tecnico> filteredItems = _dbConn.vUsrGosem_ghPlasmar_rhRecursos.Where(x => x.Nombre_Completo.ToLower().Contains(filter_param.ToLower())).Select(s=> new Tecnico() {Cedula=s.cod_recurso.Trim(),Nombre=s.Nombre_Completo.TrimEnd(),Roll="" } ).ToList();
            List<Tecnico> filteredItems = _dbConn.ExecuteQuery<Tecnico>(string.Format("SELECT t.IdTecnico as Cedula,ISNULL(g.Nombre_Completo,T.OtroNombre) as Nombre FROM dbo.tblMantenTecnico t LEFT JOIN dbo.vUsrGosem_ghPlasmar_rhRecursos AS g ON t.IdTecnico=g.cod_recurso WHERE ISNULL(g.Nombre_Completo,T.OtroNombre) LIKE '%{0}%'", filter_param)).ToList();
            cmbTecnico.DataSource = null;
            cmbTecnico.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbTecnico.DataSource = _dbConn.ExecuteQuery<Tecnico>("SELECT t.IdTecnico as Cedula,ISNULL(g.Nombre_Completo,T.OtroNombre) as Nombre FROM dbo.tblMantenTecnico t LEFT JOIN dbo.vUsrGosem_ghPlasmar_rhRecursos AS g ON t.IdTecnico=g.cod_recurso").ToList();
            }
            Cursor.Current = Cursors.Default;
            cmbTecnico.ItemHeight = 100;
            cmbTecnico.DisplayMember = "Nombre";
            cmbTecnico.ValueMember = "Cedula";
            cmbTecnico.MaxDropDownItems = 8;
            cmbTecnico.SelectedIndex = -1;
            cmbTecnico.DroppedDown = true;
            cmbTecnico.Text = filter_param;
            cmbTecnico.SelectionLength = filter_param.Length;
            cmbTecnico.Select(filter_param.Length, 0);
            txtRoll.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTecnico(cmbTecnico.Text);
        }



        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmbTecnico.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtRoll.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[2].Value.ToString();
        }
    }

}
