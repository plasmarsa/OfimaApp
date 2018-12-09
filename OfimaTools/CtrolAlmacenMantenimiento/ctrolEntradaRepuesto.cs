using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Dataccess;
namespace CtrolAlmacenMantenimiento
{
    public partial class ctrolEntradaRepuesto : UserControl
    {
        private OfimaticaDBContext _dbConn;
        private  List<Tecnico> tecnicos;
        private  List<Proveedor> proveedores;
        private  List<Repuesto> repuestos;
        private List<tblMantenMovRepuesto> entradaRepuestos;
        private tblMantenMovRepuesto entradaRepuesto;
        public ctrolEntradaRepuesto()
        {
            InitializeComponent();
        }

        public ctrolEntradaRepuesto(ref OfimaticaDBContext dbconn, ref List<Proveedor> Proveedores, ref List<Repuesto> Repuestos, ref List<Tecnico> Tecnicos)
        {
            InitializeComponent();
            _dbConn = dbconn;
            proveedores = Proveedores;
            repuestos = Repuestos;
            tecnicos = Tecnicos;
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

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarDecimal((TextBox)sender);
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtCantidad, "");
            //if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            //    _pesoNeto2 = decimal.Parse(txtCantidad.Text);
        }

        private void cmbProveedor_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbProveedor.Text;

                List<Proveedor> filteredItems = proveedores.Where(x => x.Nombre.ToLower().Contains(filter_param.ToLower())).ToList();
                cmbProveedor.DataSource = null;
                cmbProveedor.DataSource = filteredItems;

                if (String.IsNullOrWhiteSpace(filter_param))
                {
                    cmbProveedor.DataSource = proveedores;
                }
                Cursor.Current = Cursors.Default;
                cmbProveedor.ItemHeight = 100;
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "Nit";
                cmbProveedor.MaxDropDownItems = 8;
                cmbProveedor.SelectedIndex = -1;
                cmbProveedor.DroppedDown = true;
                cmbProveedor.Text = filter_param;
                cmbProveedor.SelectionLength = filter_param.Length;
                cmbProveedor.Select(filter_param.Length, 0);


        }

        private void cmbProveedor_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbProveedor, "");
        }

        private void cmbProveedor_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarProveedor(cmbProveedor.Text, out errorMsg))
            {
                e.Cancel = true;
                cmbProveedor.Select(0, cmbProveedor.Text.Length);
                this.errorProvider1.SetError(cmbProveedor, errorMsg);
            }
        }


        public bool ValidarProveedor(string nombreProveedor, out string errorMessage)
        {
            if (cmbProveedor.Text.Trim() == "")
            {
                errorMessage = "Filter y seleccione un proveedor de la lista.";
                return false;
            }

            errorMessage = "proveedor correcto";
            return true;
        }
        public bool ValidarRepuesto(string descripcionrepuesto, out string errorMessage)
        {
            if (cmbRepuesto.Text.Trim() == "")
            {
                errorMessage = "Filter y seleccione un repuesto de la lista.";
                return false;
            }

            errorMessage = "repuesto correcto";
            return true;
        }
        public bool ValidarOrden(string orden, out string errorMessage,bool validarOrden)
        {
            if (validarOrden)
            {
                //errorMessage = "Filter y seleccione un repuesto de la lista.";
                //return false;
            }

            errorMessage = "repuesto correcto";
            return true;
        }
        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbProveedor.Text))
            {
                lblProveedor.Text = cmbProveedor.SelectedValue.ToString();
            }
            
        }

        private void cmbRepuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbRepuesto.Text))
            {
                lblRepuesto.Text = cmbRepuesto.SelectedValue.ToString();
            }
        }

        private void cmbRepuesto_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbRepuesto.Text;
            //List<Repuesto> filteredItems = repuestos.Where(x => x.Descripcio.ToLower().Contains(filter_param.ToLower())).ToList();
            List<Repuesto> filteredItems = _dbConn.MTMERCIA.Where(x => x.HABILITADO == true && x.TIPOINV == "MTTO" && x.DESCRIPCIO.Contains(filter_param)).Select(s => new Repuesto() { Codigo = s.CODIGO.TrimEnd(), Descripcio = s.DESCRIPCIO.TrimEnd() }).ToList();
            cmbRepuesto.DataSource = null;
            cmbRepuesto.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                //cmbRepuesto.DataSource = repuestos;
                cmbRepuesto.DataSource=_dbConn.MTMERCIA.Where(x => x.HABILITADO == true && x.TIPOINV == "MTTO").Select(s => new Repuesto() { Codigo = s.CODIGO.TrimEnd(), Descripcio = s.DESCRIPCIO.TrimEnd() }).ToList();
            }
            Cursor.Current = Cursors.Default;
            cmbRepuesto.ItemHeight = 100;
            cmbRepuesto.DisplayMember = "Descripcio";
            cmbRepuesto.ValueMember = "Codigo";
            cmbRepuesto.MaxDropDownItems = 8;
            cmbRepuesto.SelectedIndex = -1;
            cmbRepuesto.DroppedDown = true;
            cmbRepuesto.Text = filter_param;
            cmbRepuesto.SelectionLength = filter_param.Length;
            cmbRepuesto.Select(filter_param.Length, 0);
        }

        private void cmbRepuesto_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cmbRepuesto, "");
        }

        private void cmbRepuesto_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarRepuesto(cmbRepuesto.Text, out errorMsg))
            {
                e.Cancel = true;
                cmbRepuesto.Select(0, cmbRepuesto.Text.Length);
                this.errorProvider1.SetError(cmbRepuesto, errorMsg);
            }
        }

        private void ctrolEntradaRepuesto_Load(object sender, EventArgs e)
        {
            dFecha.Text = DateTime.Now.ToString();
            entradaRepuestos = new List<tblMantenMovRepuesto>();
            gridMov.DataSource = entradaRepuestos;
        }

        private void chkOrden_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOrden.Checked)
            {
                gridMov.Visible = false;
                btnGuardar.Visible = false;
                btnAdicionar.Visible = false;
                gridOrden.Enabled = true;
                gridOrden.Visible = true;
                btnOrdenAdd.Visible = true;
                txtOrden_TextChanged(txtOrden, null);

            }
            else
            {
                gridOrden.Visible = false;
                btnOrdenAdd.Visible = false;
                gridMov.Visible = true;
                btnAdicionar.Visible = true;
                btnGuardar.Visible = true;
            }
        }

        private void txtOrden_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtOrden, "");
        }

        private void txtOrden_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidarOrden(cmbRepuesto.Text, out errorMsg,chkOrden.Checked))
            {
                e.Cancel = true;
                cmbRepuesto.Select(0, cmbRepuesto.Text.Length);
                this.errorProvider1.SetError(cmbRepuesto, errorMsg);
            }
        }

        private void txtOrden_TextChanged(object sender, EventArgs e)
        {
            string filter_param = txtOrden.Text;
            List<ItemOrdenCompra> filteredItems = null;
            filteredItems = new List<ItemOrdenCompra>();
            if (chkOrden.Checked)
            {
                gridOrden.Rows.Clear();
                filteredItems = _dbConn.ExecuteQuery<ItemOrdenCompra>
                    (string.Format("SELECT t.Nit,convert(varchar(10),t.Fecha,103) as Fecha, t.Nrodcto, t.Codigo as CodigoRepuesto, t.Producto as Descripcion, t.Cantidad, t.Valor FROM dbo.vUsrMantenOrdenesCompras AS t WHERE t.Nrodcto='{0}'", filter_param)).ToList();
                if(filteredItems!=null)
                {
                    foreach(ItemOrdenCompra item in filteredItems)
                    {
                        AdicionarItemsOrden(item.Fecha, item.Nit, item.NroDcto.TrimEnd(), item.CodigoRepuesto, item.Descripcion, item.Cantidad,item.Valor_Unitario);
                    }
                }
            }
        }
        private void AdicionarItemsOrden(string fecha, string nit, string orden, string repuesto, string descripcion, decimal cantidad, decimal valorUnitario)
        {

            gridOrden.Rows
                .Add(new object[] { fecha, nit, orden, repuesto, descripcion, string.Format("{0:0.##}", cantidad) });
        }

        private void btnAddItemsOrden_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linea in gridMov.Rows)
            {
                if (decimal.Parse(linea.Cells["4"].Value.ToString()) > 0)
                {
                    entradaRepuesto = new tblMantenMovRepuesto();
                    entradaRepuesto.Cantidad = decimal.Parse(linea.Cells[4].Value.ToString());
                    entradaRepuesto.CodCC = "";
                    entradaRepuesto.CodMaquina = "";
                    entradaRepuesto.CodProducto = linea.Cells[2].Value.ToString();
                    entradaRepuesto.FacturaProveedor = txtFactura.Text;
                    entradaRepuesto.Fecha_Hora = DateTime.Now;
                    entradaRepuesto.IdProyecto = "";
                    entradaRepuesto.IdTecnico = "";
                    entradaRepuesto.Observacion = "Entrada por orden de compra";
                    entradaRepuesto.OrdenCompra = linea.Cells[1].Value.ToString();
                    entradaRepuesto.Proveedor = linea.Cells[0].Value.ToString();
                    entradaRepuesto.Tipo = 'E';

                    entradaRepuestos.Add(entradaRepuesto);

                }

            }
            //gridItemOrden.Visible = true;
            btnAdicionar.Visible = true;
            btnGuardar.Visible = true;
            //cmbProveedor.Text = "";
            cmbRepuesto.Text = "";
            txtFactura.Text = "";
            txtOrden.Text = "";
            txtCantidad.Text = "";


            gridMov.Enabled = false;
            gridMov.Visible = false;
            btnAddItemsOrden.Visible = false;
            CargarGrid();
        }
        private void CargarGrid()
        {
            gridMov.DataSource = entradaRepuestos.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.Text == "")
            {
                MessageBox.Show("Seleccione un proveedor de la lista.", "Entrada de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProveedor.Focus();
                return;
            }
            if (cmbRepuesto.Text == "")
            {
                MessageBox.Show("Seleccione un repuesto de la lista.", "Entrada de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRepuesto.Focus();
                return;
            }
            if (txtCantidad.Text == "" || decimal.Parse(txtCantidad.Text) == 0)
            {
                MessageBox.Show("La cantidad es inválida.", "Entrada de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProveedor.Focus();
                return;
            }
            entradaRepuesto = new tblMantenMovRepuesto();
            entradaRepuesto.Cantidad = decimal.Parse(txtCantidad.Text);
            entradaRepuesto.CodCC = "";
            entradaRepuesto.CodMaquina = "";
            entradaRepuesto.CodProducto = cmbRepuesto.SelectedValue.ToString();
            entradaRepuesto.FacturaProveedor = txtFactura.Text;
            entradaRepuesto.IdProyecto = "";
            entradaRepuesto.IdTecnico = "";
            entradaRepuesto.Proveedor = cmbProveedor.SelectedValue.ToString();
            entradaRepuesto.Tipo = 'E';
            entradaRepuesto.OrdenCompra = txtOrden.Text;
            entradaRepuesto.FacturaProveedor = txtFactura.Text;
            entradaRepuestos.Add(entradaRepuesto);
            cmbProveedor.Text = "";
            cmbRepuesto.Text = "";
            txtFactura.Text = "";
            txtOrden.Text = "";
            txtCantidad.Text = "0";
            CargarGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow detalle in gridMov.Rows)
            {
                tblMantenMovRepuesto entradaRepuesto = new tblMantenMovRepuesto();
                if (decimal.Parse(detalle.Cells[9].Value.ToString()) > 0)
                {
                    entradaRepuesto.Fecha_Hora = dFecha.Value;
                    entradaRepuesto.Tipo = 'E';
                    entradaRepuesto.Proveedor = detalle.Cells[3].Value.ToString();
                    entradaRepuesto.CodProducto = detalle.Cells[4].Value.ToString();
                    entradaRepuesto.IdProyecto = "";
                    entradaRepuesto.CodMaquina = "";
                    entradaRepuesto.IdTecnico = "";
                    entradaRepuesto.CodCC = "";
                    entradaRepuesto.Cantidad = decimal.Parse(detalle.Cells[9].Value.ToString());
                    entradaRepuesto.OrdenCompra = detalle.Cells[10].Value.ToString();
                    entradaRepuesto.FacturaProveedor = detalle.Cells[11].Value.ToString();
                    entradaRepuesto.Observacion = "Entrada de repuesto";
                    entradaRepuesto.Integrado = false;
                    entradaRepuesto.TipoMvto = "ING";
                }

                try
                {

                    _dbConn.tblMantenMovRepuestos.InsertOnSubmit(entradaRepuesto);
                    _dbConn.SubmitChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Entrada de Repuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            entradaRepuestos.Clear();
            CargarGrid();
            MessageBox.Show("Entrada de repuesto exitosa.", "Entrada de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOrdenAdd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow linea in gridOrden.Rows)
                {
                    if (decimal.Parse(linea.Cells["clcantidad"].FormattedValue.ToString()) > 0)
                    {
                        entradaRepuesto = new tblMantenMovRepuesto();
                        entradaRepuesto.Cantidad = decimal.Parse(linea.Cells["clcantidad"].FormattedValue.ToString());
                        entradaRepuesto.CodCC = "";
                        entradaRepuesto.DescripcionOrden = true;
                        entradaRepuesto.CodMaquina = "";
                        entradaRepuesto.CodProducto = linea.Cells["clrepuesto"].Value.ToString();
                        entradaRepuesto.FacturaProveedor = txtFactura.Text;
                        entradaRepuesto.Fecha_Hora = DateTime.Now;
                        entradaRepuesto.IdProyecto = "";
                        entradaRepuesto.IdTecnico = "";
                        entradaRepuesto.Observacion = "Entrada por orden de compra";
                        entradaRepuesto.OrdenCompra = linea.Cells["clorden"].Value.ToString();
                        entradaRepuesto.Proveedor = linea.Cells["clnit"].Value.ToString();
                        entradaRepuesto.Tipo = 'E';

                        entradaRepuestos.Add(entradaRepuesto);
                        

                    }
                    //gridOrden.Rows.Remove(linea);
                }
                //gridMov.Rows.Clear();
                gridMov.Visible = true;
                btnAdicionar.Visible = true;
                btnGuardar.Visible = true;
                txtOrden.Text = "";
                chkOrden.Checked = false;
                txtCantidad.Text = "0";
                gridOrden.Enabled = false;
                gridOrden.Visible = false;
                btnOrdenAdd.Visible = false;
                CargarGrid();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Entrada de Repuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
