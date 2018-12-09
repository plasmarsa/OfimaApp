using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Dataccess;

namespace CtrolAlmacenMantenimiento
{
    public partial class frModificarMov : Form
    {
        private OfimaticaDBContext _dbconexion;
        private tblMantenMovRepuesto mvtoRepuesto;
        private string mvtoTecnico;
        frmSaldoDetalle saldos;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public frModificarMov()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
        }
        public frModificarMov(ref OfimaticaDBContext dbConexion, tblMantenMovRepuesto movimiento,string tecnico, frmSaldoDetalle frSaldosDetalle)
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            _dbconexion = dbConexion;
            mvtoRepuesto = movimiento;
            mvtoTecnico = tecnico;
            saldos = frSaldosDetalle;
        }

        private void frModificarMov_Load(object sender, EventArgs e)
        {
            string formato = string.Format("#{0}##", Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            dtFechaHora.Value = mvtoRepuesto.Fecha_Hora;
            txtTecnico.Text = mvtoTecnico;
            txtOrden.Text = mvtoRepuesto.OrdenCompra;
            txtFactura.Text = mvtoRepuesto.FacturaProveedor;
            cmbTipo.SelectedIndex = cmbTipo.FindStringExact(mvtoRepuesto.Tipo == 'E' ? "Entrada" : "Consumo");
            txtCantidad.Text = mvtoRepuesto.Cantidad.ToString(formato);

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == a || e.KeyChar == (char)Keys.Enter))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarDecimal((TextBox)sender);
        }
        public static bool ValidarDecimal(TextBox control)
        {
            try
            {
                decimal valor = Convert.ToDecimal(control.Text);
                return true;
            }
            catch (Exception ex)
            {
                //control.Text = "0";
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

                mvtoRepuesto.Cantidad = decimal.Parse(txtCantidad.Text);
                mvtoRepuesto.Tipo = cmbTipo.Text=="Entrada"?'E':'S';
                if(mvtoRepuesto.TipoMvto=="ING" || mvtoRepuesto.TipoMvto=="CON")
                {
                    mvtoRepuesto.TipoMvto = mvtoRepuesto.Tipo == 'E' ? "ING" : "CON";
                }
                try
                {
                    _dbconexion.SubmitChanges();
                    saldos.Movimientos_actualizados = true;    
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Al tratar de odificar un movimiento se genero el siguiente error: \n{0} ",ex.Message) , "Modificar movimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                this.Close();

            


        }
    }
}
