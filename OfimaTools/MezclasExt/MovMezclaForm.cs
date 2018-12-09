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

using DevComponents.DotNetBar;

namespace MezclasExt
{
    public partial class MovMezclaForm : Office2007Form
    {
        public List<OPERARIO> lstOperarios { get; set; }
        public  OfimaticaDBContext db;
        public int idMezclaAgrupada=0;
        public decimal Cantidad_Disponible=0;
        private  string strTipoMvto="S";
        private string strResponsable;
        private string strExtrusora;
        private string strPedido;
        private decimal decCantidad;
        private List<VPEDIDOS_LOGISTICO_PENDIENTE> lstPedidos_pendientes;

        public MovMezclaForm()
        {
            InitializeComponent();
        }

        private void MovMezclaForm_Load(object sender, EventArgs e)
        {
            //List<TipoMovimiento> lstMovimientos = new List<TipoMovimiento>();
            //lstMovimientos.Add(new TipoMovimiento { Tipo = "S", Nombre = "Salida a Extrusión" });
            //lstMovimientos.Add(new TipoMovimiento { Tipo = "D", Nombre = "Devolucion de Extrusión" });
            //cmbMov.DataSource = lstMovimientos;
            //cmbMov.DisplayMember = "Nombre";
            //cmbMov.ValueMember = "Tipo";
            //cmbMov.SelectedIndex = -1;
            rbSalida.Checked = true;
            lblDisponible.Text = string.Format("{0} Kg", Cantidad_Disponible);
            Cargar_Pedidos_Pendientes();
        }

        private void Cargar_Pedidos_Pendientes()
        {
            lstPedidos_pendientes = new List<VPEDIDOS_LOGISTICO_PENDIENTE>();
            lstPedidos_pendientes= db.VPEDIDOS_LOGISTICO_PENDIENTEs.ToList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntAceptar_Click(object sender, EventArgs e)
        {
            if(rbSalida.Checked )
            {
                if(decCantidad>Cantidad_Disponible)
                {
                    MessageBox.Show(string.Format("Solo hay disponibles {0} Kg de dicha mezcla para usar",Cantidad_Disponible) , "Validando salida de inventario de mezclas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    
            }
            tblMezclasAgrupacionComponentesMovimiento mov;
            if(idMezclaAgrupada!=0)
            {
                if (!ValidarResponsable()) { return; };
                if (!ValidarPedido()) { return; };
                if (!ValidarMovimiento()) { return; };
                if (!ValidarExtrusora()) { return; } ;
                if (!ValidarCantidad()) { return; } ;
                mov = new tblMezclasAgrupacionComponentesMovimiento();
                mov.IdAgrupacion = idMezclaAgrupada;
                mov.IdResponsable =strResponsable;
                mov.Pedido = strPedido;
                mov.TipoMvto = strTipoMvto;
                if (strTipoMvto == "S")
                    mov.Cantidad = decCantidad * -1;
                else
                    mov.Cantidad = decCantidad;

                mov.Extrusora = strExtrusora;
                mov.FechaHora = DateTime.Now;
                db.tblMezclasAgrupacionComponentesMovimiento.InsertOnSubmit(mov);
                db.SubmitChanges();
                db.ExecuteCommand(string.Format("UPDATE t SET t.Cantidad=t.Cantidad + ({0}) FROM dbo.tblMezclasAgrupacionComponentes AS t WHERE t.IdReg={1}", mov.Cantidad, idMezclaAgrupada));
                btnCancelar_Click(null, null);

            }
            this.Close();
        }
        private Boolean ValidarMovimiento()
        {
            if(rbDev.Checked==false && rbSalida.Checked==false)
            {
                MessageBox.Show("Debe seleccionar la extrusora para la salida de mezcla.", "Validando el movimiento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (rbDev.Checked)
                strTipoMvto = "D";
            else
                strTipoMvto = "S";
            return true;
        }
        private Boolean ValidarExtrusora()
        {
            
            foreach(DevComponents.DotNetBar.Controls.CheckBoxX p in groupPanel1.Controls)
            {
                if (p.Checked)
                {
                    strExtrusora = p.Tag.ToString();
                    return true;
                }
                    
                

            }
            return false;
        }
        private Boolean ValidarCantidad()
        {
            if( decCantidad==0)
            {
                MessageBox.Show("La cantidad de la mezcla debe ser mayor a 0.", "Validando el movimiento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private Boolean ValidarPedido()
        {
            if (strPedido == "")
            {
                MessageBox.Show("El pedido no es válido.", "Validando el movimiento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
                return true;
        }
        private Boolean ValidarResponsable()
        {
            if ( string.IsNullOrWhiteSpace(strResponsable))
            {
                MessageBox.Show("Debe definir el responsable del movimiento de la mezcla.", "Validando el movimiento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void cmbResponsable_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbResponsable.Text;
            List<OPERARIO> filteredItems = lstOperarios.Where(x => x.OPERARIO1.Contains(filter_param)).ToList();
            cmbResponsable.DataSource = null;
            cmbResponsable.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbResponsable.DataSource = lstOperarios;
            }
            Cursor.Current = Cursors.Default;
            cmbResponsable.DisplayMember = "Operario1";
            cmbResponsable.ValueMember = "Operario1";
            cmbResponsable.SelectedIndex = -1;
            cmbResponsable.DroppedDown = true;
            cmbResponsable.Text = filter_param;
            cmbResponsable.SelectionLength = filter_param.Length;
            cmbResponsable.Select(filter_param.Length, 0);
        }

        private void cmbPedido_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbPedido.Text;
            List<VPEDIDOS_LOGISTICO_PENDIENTE> filteredItems = lstPedidos_pendientes.Where(x => x.PEDIDO.Contains(filter_param)).ToList();
            cmbPedido.DataSource = null;
            cmbPedido.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbPedido.DataSource = lstPedidos_pendientes;
            }
            Cursor.Current = Cursors.Default;
            cmbPedido.DisplayMember = "Pedido";
            cmbPedido.ValueMember = "Pedido";
            cmbPedido.SelectedIndex = -1;
            cmbPedido.DroppedDown = true;
            cmbPedido.Text = filter_param;
            cmbPedido.SelectionLength = filter_param.Length;
            cmbPedido.Select(filter_param.Length, 0);
        }

        private void cmbResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbResponsable.Text == "Dataccess.OPERARIO" || cmbResponsable.SelectedIndex == -1)
            {
                lblNombreOperario.Text = string.Empty;
                strResponsable = string.Empty;
            }
            else
            {
                OPERARIO operario = lstOperarios.Where(x => x.OPERARIO1 == cmbResponsable.Text.ToString()).SingleOrDefault();
                lblNombreOperario.Text = operario.NOMBRE.TrimEnd();
                strResponsable = operario.OPERARIO1.Trim();
            }
        }

        private void cmbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPedido.Text == "Dataccess.VPEDIDOS_LOGISTICO_PENDIENTE" || cmbPedido.SelectedIndex == -1)
            {
                txtProducto.Text = string.Empty;
                lblCLiente.Text = string.Empty;
                strPedido = "";
            }
            else
            {
                VPEDIDOS_LOGISTICO_PENDIENTE pedidoPendiente = db.VPEDIDOS_LOGISTICO_PENDIENTEs.Where(x => x.PEDIDO == cmbPedido.Text.ToString()).SingleOrDefault();
                lblCLiente.Text = string.Format("Cliente: {0}", pedidoPendiente.NOMBRE.TrimEnd());
                txtProducto.Text = string.Format("Producto:\n\r{0} - {1}", pedidoPendiente.CODIGO.Trim(), pedidoPendiente.NOMBRE1.TrimEnd());
                strPedido = pedidoPendiente.PEDIDO.Trim();
            }
        }

        private void rbExt01_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = (int)e.KeyChar; // not really necessary to cast to int

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            if ((keyvalue == DECIMAL_POINT) &&
            (txtCantidad.Text.IndexOf(".") == NOT_FOUND)) return;
            e.Handled = true;
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
            }
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
                decCantidad = 0;
            else
                decCantidad = decimal.Parse(txtCantidad.Text);
        }
    }

    //public class TipoMovimiento
    //{
    //    public string Tipo { get; set; }
    //    public string Nombre { get; set; }
    //}
}
