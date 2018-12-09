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
    public partial class ctrolAnilox : UserControl
    {
        public OfimaticaDBContext _dbConexion;
        public ctrolAnilox(ref OfimaticaDBContext dbConexion)
        {
            InitializeComponent();
            _dbConexion = dbConexion;
            ConsultarAnilox();
            
        }
        private void ConsultarAnilox()
        {
            grid.DataSource = null;
            grid.DataSource = _dbConexion.tblControlCalidadTintasAnilox.ToList();
            grid.Refresh();
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }

        private void CrearAnilox(string codAnilox, string Descripcion)
        {
            tblControlCalidadTintasAnilox anilox = new tblControlCalidadTintasAnilox();
            anilox = _dbConexion.tblControlCalidadTintasAnilox.Where(x => x.CodAnilox == codAnilox).SingleOrDefault();
            if(anilox==null)
            {
                anilox = new tblControlCalidadTintasAnilox();
                anilox.CodAnilox = codAnilox;
                anilox.Descripcion = Descripcion;
                _dbConexion.tblControlCalidadTintasAnilox.InsertOnSubmit(anilox);
            }
            else
            {
                anilox.Descripcion = Descripcion;
            }
            _dbConexion.SubmitChanges();
            ConsultarAnilox();
        }

        private void EliminarAnilox(string codAnilox)
        {
            tblControlCalidadTintasAnilox anilox = new tblControlCalidadTintasAnilox();
            anilox = _dbConexion.tblControlCalidadTintasAnilox.Where(x => x.CodAnilox == codAnilox).SingleOrDefault();

            if (anilox!=null)
            {
                _dbConexion.tblControlCalidadTintasAnilox.DeleteOnSubmit(anilox);
                _dbConexion.SubmitChanges();
                
            }
            ConsultarAnilox();

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtCodigo.Text = grid.CurrentCell.RowIndex.ToString();
            txtCodigo.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtDescripcion.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAnilox(txtCodigo.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CrearAnilox(txtCodigo.Text, txtDescripcion.Text);
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.Image = CalidadTintas.Properties.Resources.Delete_a_record_hover_50px;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.Image = CalidadTintas.Properties.Resources.Delete_a_record_50px;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.Image = CalidadTintas.Properties.Resources.Save_as_50px;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.Image = CalidadTintas.Properties.Resources.Save_as_hover_50px;
        }

        private void ctrolAnilox_Load(object sender, EventArgs e)
        {

        }
    }
}
