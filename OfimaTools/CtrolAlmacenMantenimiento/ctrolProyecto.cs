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
    public partial class ctrolProyecto : UserControl
    {
        private OfimaticaDBContext _dbConn;
        public ctrolProyecto()
        {
            InitializeComponent();
        }
        public ctrolProyecto(ref OfimaticaDBContext dbconn)
        {
            InitializeComponent();
            _dbConn = dbconn;
            ConsultarProyectos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CrearProyecto(txtCodigo.Text, txtProyecto.Text,dFechaini.Value,dfechafin.Value);
        }
        private void CrearProyecto(string codProyecto, string Proyecto,DateTime Inicio,DateTime Fin)
        {
            tblMantenProjecto proyecto = new tblMantenProjecto();

            proyecto = _dbConn.tblMantenProjecto.Where(x => x.IdProyecto == codProyecto).SingleOrDefault();
            if (proyecto == null)
            {
                proyecto = new tblMantenProjecto();
                proyecto.IdProyecto = codProyecto;
                proyecto.Nombre_Proyecto = Proyecto;
                proyecto.CodCC = "";
                proyecto.FchInicio = Inicio;
                proyecto.FchFin = Fin;
                _dbConn.tblMantenProjecto.InsertOnSubmit(proyecto);
            }
            else
            {
                proyecto.Nombre_Proyecto = Proyecto;
                txtCodigo.Text = "";
                txtProyecto.Text = "";
            }
            _dbConn.SubmitChanges();
            ConsultarProyectos();
        }
        private void ConsultarProyectos()
        {
            grid.DataSource = null;
            grid.DataSource = _dbConn.tblMantenProjecto.ToList();
            grid.Refresh();
            txtCodigo.Text = "";
            txtProyecto.Text = "";
            dFechaini.Value = DateTime.Now;
            dfechafin.Value = DateTime.Now;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtProyecto.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            dFechaini.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[3].Value.ToString();
            dfechafin.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[4].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tblMantenProjecto proyecto = new tblMantenProjecto();
            proyecto = _dbConn.tblMantenProjecto.Where(x => x.IdProyecto == txtCodigo.Text).SingleOrDefault();

            if (proyecto != null)
            {
                _dbConn.tblMantenProjecto.DeleteOnSubmit(proyecto);
                _dbConn.SubmitChanges();

            }
            ConsultarProyectos();
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtProyecto.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            dFechaini.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[3].Value.ToString();
            dfechafin.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[4].Value.ToString();
        }
    }
}
