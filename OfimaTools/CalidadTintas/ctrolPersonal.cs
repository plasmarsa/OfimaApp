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
    public partial class ctrolPersonal : UserControl
    {
        private OfimaticaDBContext _dbConn;
        public ctrolPersonal()
        {
            InitializeComponent();
        }
        public ctrolPersonal(ref OfimaticaDBContext dbConexion)
        {
            _dbConn = dbConexion;
            InitializeComponent();
            ConsultarPersonalTintas();
        }

        private void ctrolPersonal_Load(object sender, EventArgs e)
        {

        }
        private void ConsultarPersonalTintas()
        {
            grid.DataSource = null;
            grid.Rows.Clear();
            List<PersonalTintas> lista = _dbConn.ExecuteQuery<PersonalTintas>("SELECT t.IdPersona as Cedula,ISNULL(e.Nombre_Completo,t.OtroNombre) as Nombre,t.OtroNombre as Roll FROM dbo.tblControlCalidadPersonal  t left JOIN dbo.vUsrGosem_ghPlasmar_rhRecursos e ON t.IdPersona=e.cod_recurso order by 2").ToList();

            foreach (PersonalTintas item in lista)
            {
                AdicionarTecnicoTintasGrid(item.Cedula, item.Nombre, item.Roll);
            }
            grid.Refresh();
            cmbPersonal.Text = "";
            txtRoll.Text = "";
        }

        private void CrearPersonalTintas(string NombreTecnico, string roll)
        {
            tblControlCalidadPersonal tecnico = new tblControlCalidadPersonal();
            string cedulaTecnico = BuscarCedulaPersona(NombreTecnico);
            if (string.IsNullOrWhiteSpace(cedulaTecnico))
            {
                cedulaTecnico = _dbConn.tblControlCalidadPersonal.Where(x => x.OtroNombre == roll).Select(s => s.IdPersona).SingleOrDefault();
            }

            tecnico = _dbConn.tblControlCalidadPersonal.Where(x => x.IdPersona == cedulaTecnico).SingleOrDefault();
            if (tecnico == null)
            {
                tecnico = new tblControlCalidadPersonal();
                tecnico.IdPersona = cedulaTecnico;
                tecnico.OtroNombre = roll;
                _dbConn.tblControlCalidadPersonal.InsertOnSubmit(tecnico);
            }
            else
            {
                tecnico.OtroNombre = roll;
            }
            _dbConn.SubmitChanges();
            ConsultarPersonalTintas();
        }

        private string BuscarCedulaPersona(string nombreTecnico)
        {
            return _dbConn.vUsrGosem_ghPlasmar_rhRecursos.Where(x => x.Nombre_Completo == nombreTecnico).Select(s => s.cod_recurso.Trim()).SingleOrDefault();
        }

        private void AdicionarTecnicoTintasGrid(string cedula, string nombre, string roll)
        {

            grid.Rows
                .Add(new object[] { cedula, nombre, roll});
        }

        private void EliminarPersonalTintas(string tecnicoTintas)
        {
            tblControlCalidadPersonal objTecnico = new tblControlCalidadPersonal();


            objTecnico = _dbConn.tblControlCalidadPersonal.Where(x => x.IdPersona == BuscarCedulaPersona(tecnicoTintas)).SingleOrDefault();

            if (objTecnico != null)
            {
                _dbConn.tblControlCalidadPersonal.DeleteOnSubmit(objTecnico);
                _dbConn.SubmitChanges();

            }
            else
            {
                MessageBox.Show("El técnico de tintas no puede ser eliminado..", "Eliminar técnico.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ConsultarPersonalTintas();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            CrearPersonalTintas(cmbPersonal.Text, txtRoll.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPersonalTintas(cmbPersonal.Text);
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmbPersonal.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtRoll.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[2].Value.ToString();
        }

        private void cmbPersonal_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbPersonal.Text;
            //List<Tecnico> filteredItems = _dbConn.vUsrGosem_ghPlasmar_rhRecursos.Where(x => x.Nombre_Completo.ToLower().Contains(filter_param.ToLower())).Select(s=> new Tecnico() {Cedula=s.cod_recurso.Trim(),Nombre=s.Nombre_Completo.TrimEnd(),Roll="" } ).ToList();
            List<PersonalTintas> filteredItems = _dbConn.ExecuteQuery<PersonalTintas>(string.Format("SELECT v.cod_recurso AS Cedula,v.Nombre_Completo AS Nombre FROM dbo.vUsrGosem_ghPlasmar_rhRecursos v WHERE v.cod_recurso NOT IN (SELECT t.IdPersona FROM dbo.tblControlCalidadPersonal t) AND  v.Nombre_Completo LIKE '%{0}%'", filter_param)).ToList();
            cmbPersonal.DataSource = null;
            cmbPersonal.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbPersonal.DataSource = _dbConn.ExecuteQuery<PersonalTintas>("SELECT v.cod_recurso AS Cedula,v.Nombre_Completo AS Nombre FROM dbo.vUsrGosem_ghPlasmar_rhRecursos v WHERE v.cod_recurso NOT IN (SELECT t.IdPersona FROM dbo.tblControlCalidadPersonal t)").ToList();
            }
            Cursor.Current = Cursors.Default;
            cmbPersonal.ItemHeight = 100;
            cmbPersonal.DisplayMember = "Nombre";
            cmbPersonal.ValueMember = "Cedula";
            cmbPersonal.MaxDropDownItems = 8;
            cmbPersonal.SelectedIndex = -1;
            cmbPersonal.DroppedDown = true;
            cmbPersonal.Text = filter_param;
            cmbPersonal.SelectionLength = filter_param.Length;
            cmbPersonal.Select(filter_param.Length, 0);
            txtRoll.Text = "";
        }

        private void cmbPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonal.SelectedIndex != -1)
                txtRoll.Text = "";
        }
    }
}
