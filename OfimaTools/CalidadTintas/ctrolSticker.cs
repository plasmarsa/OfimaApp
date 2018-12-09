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
    public partial class ctrolSticker : UserControl
    {
        public OfimaticaDBContext _dbConexion;

        public ctrolSticker(ref OfimaticaDBContext dbConexion)
        {
            InitializeComponent();
            _dbConexion = dbConexion;
            ConsultarStick();
        }
        private void ConsultarStick()
        {
            grid.DataSource = null;
            grid.DataSource = _dbConexion.tblControlCalidadTintasStick.ToList();
            grid.Refresh();
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }

        private void CrearStick(string codStick, string Descripcion)
        {
            tblControlCalidadTintasStick stick = new tblControlCalidadTintasStick();
            stick = _dbConexion.tblControlCalidadTintasStick.Where(x => x.CodStick == codStick).SingleOrDefault();
            if (stick == null)
            {
                stick = new tblControlCalidadTintasStick();
                stick.CodStick = codStick;
                stick.Descripcion = Descripcion;
                _dbConexion.tblControlCalidadTintasStick.InsertOnSubmit(stick);
            }
            else
            {
                stick.Descripcion = Descripcion;
            }
            _dbConexion.SubmitChanges();
            ConsultarStick();
        }

        private void EliminarStick(string codStick)
        {
            tblControlCalidadTintasStick stick = new tblControlCalidadTintasStick();
            stick = _dbConexion.tblControlCalidadTintasStick.Where(x => x.CodStick == codStick).SingleOrDefault();

            
            
                if (stick != null)
                {
                    if (_dbConexion.tblControlCalidadTinteros.Where(x => x.CodStick == codStick).Count() > 0)
                    {
                        MessageBox.Show(string.Format("No se puede eliminar el stick {0}, ya esta siendo usado.", codStick), "Eliminando stick...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ConsultarStick();
                        return;
                    }

                   _dbConexion.tblControlCalidadTintasStick.DeleteOnSubmit(stick);
                   _dbConexion.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(string.Format("Código de stick {0} no existe en el maestro.", codStick), "Eliminando stick...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConsultarStick();
                return;
                }
            ConsultarStick();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtDescripcion.Text = grid.Rows[grid.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CrearStick(txtCodigo.Text, txtDescripcion.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarStick(txtCodigo.Text);
        }
    }
}
