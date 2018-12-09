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

using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using DevComponents.DotNetBar;
using Dataccess;

namespace MezclasExt.Controles
{
    
    public partial class MezclaDetalle : UserControl
    {
        public List<InsumoMezcla> lstInsumos { get; set; }
        public List<DetalleMezcla> lstDetalleMezcla;
        public decimal cantidad_Mezcladora;
        public int Cantidad_Mezcla { get; set; }
        public string MezclaBase { get; set; }
        public string Responsable { get; set; }
        public short NroMezcla { get; set; }
        public OfimaticaDBContext DB;
        private decimal factorPigmento;
        private decimal factorAyudante;
        private decimal factorAntiblock;
        private decimal factorAntioxidante;
        private decimal factorSlip;
        private decimal factorAditivo;
        Office2007Form frmain;

        public MezclaDetalle()
        {
            InitializeComponent();
            inicializarVariables();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", true);
        }

        public MezclaDetalle (Office2007Form frmGeneral)
        {
            InitializeComponent();
            inicializarVariables();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", true);
            frmain = frmGeneral;
        }

        private void inicializarVariables()
        {
            factorPigmento = 0;
            factorAyudante = 0;
            factorAntiblock = 0;
            factorAntioxidante = 0;
            factorSlip = 0;
            factorAditivo = 0;
            lstDetalleMezcla = new List<DetalleMezcla>();
    


        }

        private void MezclaDetalle_Load(object sender, EventArgs e)
        {

        }

        private void cmbPigmento_TextUpdate(object sender, EventArgs e)
        {
            var obj = cmbPigmento;
            string filtroTipo="Pigmento";
            string parametro_filtro = obj.Text;
            
            List<InsumoMezcla> insumosFiltrados = lstInsumos.Where(x => x.Descripcion.Contains(parametro_filtro) && x.Tipo == filtroTipo).ToList();
            obj.DataSource = null;
            obj.DataSource = insumosFiltrados;

            if (String.IsNullOrWhiteSpace(parametro_filtro))
                obj.DataSource = lstInsumos.Where(x => x.Tipo == filtroTipo).ToList();

            Cursor.Current = Cursors.Default;
            obj.DisplayMember = "Descripcion";
            obj.ValueMember = "Codigo";
            obj.SelectedIndex = -1;
            obj.DroppedDown = true;
            obj.Text = parametro_filtro;
            obj.SelectionLength = parametro_filtro.Length;
            obj.Select(parametro_filtro.Length, 0);
        }

        private void cmbAyudante_TextUpdate(object sender, EventArgs e)
        {
            var obj = cmbAyudante;
            string filtroTipo = "Ayudante de Proceso";
            string parametro_filtro = obj.Text;

            List<InsumoMezcla> insumosFiltrados = lstInsumos.Where(x => x.Descripcion.Contains(parametro_filtro) && x.Tipo == filtroTipo).ToList();
            obj.DataSource = null;
            obj.DataSource = insumosFiltrados;

            if (String.IsNullOrWhiteSpace(parametro_filtro))
                obj.DataSource = lstInsumos.Where(x => x.Tipo == filtroTipo).ToList();

            Cursor.Current = Cursors.Default;
            obj.DisplayMember = "Descripcion";
            obj.ValueMember = "Codigo";
            obj.SelectedIndex = -1;
            obj.DroppedDown = true;
            obj.Text = parametro_filtro;
            obj.SelectionLength = parametro_filtro.Length;
            obj.Select(parametro_filtro.Length, 0);
        }

        private void cmbAntiblock_TextUpdate(object sender, EventArgs e)
        {
            var obj = cmbAntiblock;
            string filtroTipo = "Antiblock";
            string parametro_filtro = obj.Text;

            List<InsumoMezcla> insumosFiltrados = lstInsumos.Where(x => x.Descripcion.Contains(parametro_filtro) && x.Tipo == filtroTipo).ToList();
            obj.DataSource = null;
            obj.DataSource = insumosFiltrados;

            if (String.IsNullOrWhiteSpace(parametro_filtro))
                obj.DataSource = lstInsumos.Where(x => x.Tipo == filtroTipo).ToList();

            Cursor.Current = Cursors.Default;
            obj.DisplayMember = "Descripcion";
            obj.ValueMember = "Codigo";
            obj.SelectedIndex = -1;
            obj.DroppedDown = true;
            obj.Text = parametro_filtro;
            obj.SelectionLength = parametro_filtro.Length;
            obj.Select(parametro_filtro.Length, 0);
        }




        private void cmbAntioxidante_TextUpdate(object sender, EventArgs e)
        {
            var obj = cmbAntioxidante;
            string filtroTipo = "Antioxidante";
            string parametro_filtro = obj.Text;

            List<InsumoMezcla> insumosFiltrados = lstInsumos.Where(x => x.Descripcion.Contains(parametro_filtro) && x.Tipo == filtroTipo).ToList();
            obj.DataSource = null;
            obj.DataSource = insumosFiltrados;

            if (String.IsNullOrWhiteSpace(parametro_filtro))
                obj.DataSource = lstInsumos.Where(x => x.Tipo == filtroTipo).ToList();

            Cursor.Current = Cursors.Default;
            obj.DisplayMember = "Descripcion";
            obj.ValueMember = "Codigo";
            obj.SelectedIndex = -1;
            obj.DroppedDown = true;
            obj.Text = parametro_filtro;
            obj.SelectionLength = parametro_filtro.Length;
            obj.Select(parametro_filtro.Length, 0);
        }

        private void cmbSlip_TextUpdate(object sender, EventArgs e)
        {
            var obj = cmbSlip;
            string filtroTipo = "Slip";
            string parametro_filtro = obj.Text;

            List<InsumoMezcla> insumosFiltrados = lstInsumos.Where(x => x.Descripcion.Contains(parametro_filtro) && x.Tipo == filtroTipo).ToList();
            obj.DataSource = null;
            obj.DataSource = insumosFiltrados;

            if (String.IsNullOrWhiteSpace(parametro_filtro))
                obj.DataSource = lstInsumos.Where(x => x.Tipo == filtroTipo).ToList();

            Cursor.Current = Cursors.Default;
            obj.DisplayMember = "Descripcion";
            obj.ValueMember = "Codigo";
            obj.SelectedIndex = -1;
            obj.DroppedDown = true;
            obj.Text = parametro_filtro;
            obj.SelectionLength = parametro_filtro.Length;
            obj.Select(parametro_filtro.Length, 0);
        }

        private void cmbOtro_TextUpdate(object sender, EventArgs e)
        {
            var obj = cmbOtro;
            string filtroTipo = "Otro Aditivo";
            string parametro_filtro = obj.Text;

            List<InsumoMezcla> insumosFiltrados = lstInsumos.Where(x => x.Descripcion.Contains(parametro_filtro) && x.Tipo == filtroTipo).ToList();
            obj.DataSource = null;
            obj.DataSource = insumosFiltrados;

            if (String.IsNullOrWhiteSpace(parametro_filtro))
                obj.DataSource = lstInsumos.Where(x => x.Tipo == filtroTipo).ToList();

            Cursor.Current = Cursors.Default;
            obj.DisplayMember = "Descripcion";
            obj.ValueMember = "Codigo";
            obj.SelectedIndex = -1;
            obj.DroppedDown = true;
            obj.Text = parametro_filtro;
            obj.SelectionLength = parametro_filtro.Length;
            obj.Select(parametro_filtro.Length, 0);
        }

        
        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim() == "" || txtCantidad.Text.Trim()=="0")
            {
                Cantidad_Mezcla = 0;
                InicializarMezcla();
                return;
            }
            else
            {
                Cantidad_Mezcla = int.Parse(txtCantidad.Text);
                lstDetalleMezcla.Clear();
                Grid.PrimaryGrid.Rows.Clear();
                Adicionar_Componentes_Base(this.MezclaBase);
            }
        }
        private void Adicionar_Componentes_Base(string Mezcla_Base)
        {
            foreach (var p in this.DB.MVKSTANDs.Where(x => x.CODIGO == Mezcla_Base).ToList())
            {
                Adicionar_Componente(p.CODINSUMO.TrimEnd(), "", 100, false, Convert.ToDecimal(p.CANTIDAD) * Cantidad_Mezcla, this.NroMezcla,"Base");
            }

        }

        private void Adicionar_Componente(string codigo,string nombre, decimal factor, Boolean adicion, decimal cantidad, short nromezcla, string tipo)
        {
            nombre=DB.MTMERCIA.Where(x => x.CODIGO == codigo).Select(x => x.DESCRIPCIO.TrimEnd()).Single();

            if(tipo!="Base" && tipo!="Otro")
            {
                if (!lstDetalleMezcla.Exists(x => x.Tipo == tipo))
                {
                    lstDetalleMezcla.Add(new DetalleMezcla(codigo, nombre, factor, adicion, cantidad, nromezcla, tipo));
                    Adicionar_Detalle_Mezcla(codigo, nombre, factor, adicion, cantidad, nromezcla, tipo);
                }

            }
            else
            {
                    lstDetalleMezcla.Add(new DetalleMezcla(codigo, nombre, factor, adicion, cantidad, nromezcla, tipo));
                    Adicionar_Detalle_Mezcla(codigo, nombre, factor, adicion, cantidad, nromezcla, tipo);

            }

        }

        private void Adicionar_Detalle_Mezcla(string codigo, string nombre, decimal factor, Boolean adicion, decimal cantidad, short nromezcla, string tipo)
        {
            GridPanel panel = Grid.PrimaryGrid;
            object[] objDetalle = new object[8];
            objDetalle[0] = tipo;
            objDetalle[1] = codigo;
            objDetalle[2] = nombre;
            objDetalle[3] = string.Format("{0:F2}", factor);
            objDetalle[4] = adicion;
            objDetalle[5] = string.Format("{0:F2}",cantidad);
            objDetalle[6] = nromezcla;
            objDetalle[7] = "Eliminar";

            GridRow detalle = new GridRow(objDetalle);
            panel.Rows.Add(detalle);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                   e.Handled = true;
            }
            
        }

        private void btnAddMezcla_Click(object sender, EventArgs e)
        {
            ValidarCantidadMezcla();
        }

        private void txtFactorSlip_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == a || e.KeyChar == (char)Keys.Enter))
            { e.Handled = true; }
            TextBox txtFactorSlip  = sender as TextBox;
            if (e.KeyChar == '.' && txtFactorSlip.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void btnAdicionarPigmento_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFactorPigmento.Text) && cmbPigmento.SelectedValue!=null)
            {
                ValidarCantidadMezcla();
                decimal cantidad = (Cantidad_Mezcla * factorPigmento) / 100;
                Adicionar_Componente(cmbPigmento.SelectedValue.ToString(), "", factorPigmento, true, cantidad, this.NroMezcla,"Pigmento");
            }
        }

        private void btnAdicionarAyudante_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFactorAyudante.Text) && cmbAyudante.SelectedValue != null)
            {
                ValidarCantidadMezcla();
                decimal cantidad = (Cantidad_Mezcla * factorAyudante) / 100;
                Adicionar_Componente(cmbAyudante.SelectedValue.ToString(), "", factorAyudante, true, cantidad, this.NroMezcla,"Ayudante");
            }
        }

        private void btnAdicionarAntiblock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFactorAntiblock.Text) && cmbAntiblock.SelectedValue != null)
            {

                ValidarCantidadMezcla();
                decimal cantidad = (Cantidad_Mezcla * factorAntiblock) / 100;
                Adicionar_Componente(cmbAntiblock.SelectedValue.ToString(), "", factorAntiblock, true, cantidad, this.NroMezcla,"Antiblock");
            }
        }
        private void btnAntioxidante_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFactorAntioxidante.Text) && cmbAntioxidante.SelectedValue != null)
            {

                ValidarCantidadMezcla();
                decimal cantidad = (Cantidad_Mezcla * factorAntioxidante) / 100;
                Adicionar_Componente(cmbAntioxidante.SelectedValue.ToString(), "", factorAntioxidante, true, cantidad, this.NroMezcla,"Antioxidante");
            }
        }

        private void btnSlip_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFactorSlip.Text) && cmbSlip.SelectedValue != null)
            {

                ValidarCantidadMezcla();
                decimal cantidad = (Cantidad_Mezcla * factorSlip) / 100;
                Adicionar_Componente(cmbSlip.SelectedValue.ToString(), "", factorSlip, true, cantidad, this.NroMezcla,"Slip");
            }
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFactorOtro.Text) && cmbOtro.SelectedValue != null)
            {

                ValidarCantidadMezcla();
                decimal cantidad = (Cantidad_Mezcla * factorAditivo) / 100;
                Adicionar_Componente(cmbOtro.SelectedValue.ToString(), "", factorAditivo, true, cantidad, this.NroMezcla,"Otro");
            }
        }

        private void ValidarCantidadMezcla()
        {
            if (Cantidad_Mezcla == 0)
            {
                MessageBox.Show("Debe especificar la cantidad a mezclar", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
            }

        }
        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
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
            (txtFactorPigmento.Text.IndexOf(".") == NOT_FOUND)) return;
            e.Handled = true;
        }

       private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Grid_CellClick(object sender, GridCellClickEventArgs e)
        {

            var senderGrid=(SuperGridControl)sender;

            if(e.GridCell.ColumnIndex==senderGrid.PrimaryGrid.Columns["eliminar"].ColumnIndex && e.GridCell.RowIndex>=0)
            {
                GridCell cell = Grid.PrimaryGrid.GetCell(e.GridCell.RowIndex, 1) as GridCell;
                if(Convert.ToBoolean(Grid.PrimaryGrid.GetCell(e.GridCell.RowIndex, 4).Value))
                {
                    //MessageBox.Show("Se puede borrar!");
                    DetalleMezcla detalleMezcla = lstDetalleMezcla.Where(x => x.Codigo_Insumo == Grid.PrimaryGrid.GetCell(e.GridCell.RowIndex, 1).Value.ToString()).Single();
                    lstDetalleMezcla.Remove(detalleMezcla);
                    Grid.PrimaryGrid.Rows.RemoveAt(e.GridCell.RowIndex);
                    Grid.Refresh();
                }

            }
        }

        private void txtFactorPigmento_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFactorPigmento.Text))
                factorPigmento = 0;
            else
            factorPigmento = decimal.Parse(txtFactorPigmento.Text);
        }

        private void txtFactorAyudante_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFactorAyudante.Text))
                factorAyudante = 0;
            else
                factorAyudante = decimal.Parse(txtFactorAyudante.Text);
        }

        private void txtFactorAntiblock_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFactorAntiblock.Text))
                factorAntiblock = 0;
            else
                factorAntiblock = decimal.Parse(txtFactorAntiblock.Text);
        }

        private void txtFactorAntioxidante_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFactorAntioxidante.Text))
                factorAntioxidante = 0;
            else
                factorAntioxidante = decimal.Parse(txtFactorAntioxidante.Text);
        }

        private void txtFactorSlip_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFactorSlip.Text))
                factorSlip = 0;
            else
                factorSlip = decimal.Parse(txtFactorSlip.Text);
        }

        private void txtFactorOtro_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFactorOtro.Text))
                factorAditivo = 0;
            else
                factorAditivo = decimal.Parse(txtFactorOtro.Text);
        }


        private void ValidarCapacidadMezcladora()
        {
            
        }


        public  void InicializarMezcla()
        {
            InicializarControles();
            lstDetalleMezcla.Clear();
            factorAditivo = 0;
            factorAntiblock = 0;
            factorAntioxidante = 0;
            factorAyudante = 0;
            factorPigmento = 0;
            factorSlip = 0;
            this.Cantidad_Mezcla = 0;

        }
        private void InicializarControles()
        {
            txtCantidad.Text = string.Empty;
            txtFactorAntiblock.Text = string.Empty;
            txtFactorAntioxidante.Text = string.Empty;
            txtFactorAyudante.Text = string.Empty;
            txtFactorOtro.Text = string.Empty;
            txtFactorPigmento.Text = string.Empty;
            txtFactorSlip.Text = string.Empty;
            cmbAntiblock.Text = string.Empty;
            cmbAntioxidante.Text = string.Empty;
            cmbAyudante.Text = string.Empty;
            cmbOtro.Text = string.Empty;
            cmbPigmento.Text = string.Empty;
            cmbSlip.Text = string.Empty;
            GridPanel panel = Grid.PrimaryGrid;
            panel.Rows.Clear();
        }
    }

    public class DetalleMezcla
    {
        public string Codigo_Insumo { get; set; }
        public string Nombre_Insumo { get; set; }
        public decimal Factor { get; set; }
        public Boolean Adicion { get; set; }
        public decimal Cantidad { get; set; }
        public short NroMezcla { get; set; }
        public string Tipo { get; set; }

        public DetalleMezcla()
        {

        }
        public DetalleMezcla(string codigo_insumo,string nombre_insumo,decimal factor, Boolean esAdicion,decimal cantidad, short nroMezcla, string tipo)
        {
            Codigo_Insumo = codigo_insumo;
            Nombre_Insumo = nombre_insumo;
            Factor = factor;
            Adicion = esAdicion;
            Cantidad = cantidad;
            NroMezcla = nroMezcla;
            Tipo = tipo;
        }
    }

    internal class EliminarComponente:GridButtonEditControl
    {
        public EliminarComponente()
        {
            Click += EliminarComponenteClick;
        }

        void EliminarComponenteClick(object sender,EventArgs e)
        {
            MessageBox.Show("Me diste click!");
        }

    }
}
