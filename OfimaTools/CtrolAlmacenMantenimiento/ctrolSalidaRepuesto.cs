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
    public partial class ctrolSalidaRepuesto : UserControl
    {
        OfimaticaDBContext _dbConn;
        private List<Repuesto> repuestos;
        private List<Tecnico> tecnicos;
        private List<Proveedor> proveedores;
        public  List<tblMantenMovRepuesto> salidaRepuestos;
        public  List<CENTCOS> centrosCostos;
        //private tblMantenMovRepuesto salidaRepuesto;
        public ctrolSalidaRepuesto()
        {
            InitializeComponent();
        }
        public ctrolSalidaRepuesto(ref OfimaticaDBContext dbconn, ref List<Proveedor> Proveedores, ref List<Repuesto> Repuestos, ref List<Tecnico> Tecnicos)
        {
            InitializeComponent();
            _dbConn = dbconn;
            repuestos = Repuestos;
            tecnicos = Tecnicos;
            proveedores = Proveedores;
        }

        private void cmbProyecto_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbProyecto.Text;

            List<tblMantenProjecto> filteredItems = _dbConn.tblMantenProjecto.Where(x => x.Nombre_Proyecto.ToLower().Contains(filter_param.ToLower())).ToList();
            cmbProyecto.DataSource = null;
            cmbProyecto.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbProyecto.DataSource = _dbConn.tblMantenProjecto;
            }
            Cursor.Current = Cursors.Default;
            cmbProyecto.ItemHeight = 100;
            cmbProyecto.DisplayMember = "Nombre_Proyecto";
            cmbProyecto.ValueMember = "IdProyecto";
            cmbProyecto.MaxDropDownItems = 8;
            cmbProyecto.SelectedIndex = -1;
            cmbProyecto.DroppedDown = true;
            cmbProyecto.Text = filter_param;
            cmbProyecto.SelectionLength = filter_param.Length;
            cmbProyecto.Select(filter_param.Length, 0);
        }

        private void cmbProyecto_Validated(object sender, EventArgs e)
        {

        }

        private void cmbProyecto_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cmbMaquina_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbMaquina.Text;

            List<Maquina> filteredItems =
                    _dbConn.tblMantenMaquinas.Where(x => x.Nombre.ToLower().Contains(filter_param)).Select(s => new Maquina() { Codigo = s.CodMaquina.Trim(), Descripcion = s.Nombre.TrimEnd() }).ToList();
            cmbMaquina.DataSource = null;
            cmbMaquina.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbMaquina.DataSource = _dbConn.tblMantenMaquinas;
            }
            Cursor.Current = Cursors.Default;
            cmbMaquina.ItemHeight = 100;
            cmbMaquina.DisplayMember = "Descripcion";
            cmbMaquina.ValueMember = "Codigo";
            cmbMaquina.MaxDropDownItems = 8;
            cmbMaquina.SelectedIndex = -1;
            cmbMaquina.DroppedDown = true;
            cmbMaquina.Text = filter_param;
            cmbMaquina.SelectionLength = filter_param.Length;
            cmbMaquina.Select(filter_param.Length, 0);
        }

        private void cmbTecnico_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbTecnico.Text;

            List<Tecnico> filteredItems = _dbConn.ExecuteQuery<Tecnico>(string.Format("SELECT t.IdTecnico as Cedula,ISNULL(g.Nombre_Completo,T.OtroNombre) as Nombre FROM dbo.tblMantenTecnico t LEFT JOIN dbo.vUsrGosem_ghPlasmar_rhRecursos AS g ON t.IdTecnico=g.cod_recurso WHERE ISNULL(g.Nombre_Completo,T.OtroNombre) LIKE '%{0}%'", filter_param)).ToList();
            cmbTecnico.DataSource = null;
            cmbTecnico.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbTecnico.DataSource = _dbConn.ExecuteQuery<Tecnico>("SELECT t.IdTecnico as Cedula,ISNULL(g.Nombre_Completo,T.OtroNombre) as Nombre FROM dbo.tblMantenTecnico t LEFT JOIN dbo.vUsrGosem_ghPlasmar_rhRecursos AS g ON t.IdTecnico=g.cod_recurso").ToList(); ;
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
        }

        private void cmbCentCos_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbCentCos.Text;

            List<CENTCOS> filteredItems = _dbConn.ExecuteQuery<CENTCOS>(string.Format("SELECT c.AUXILIAR, c.CAPACIDAD, RTRIM(c.CODCC) AS CODCC, c.NIT, RTRIM(c.NOMBRE) AS NOMBRE, c.STADSINCRO, c.NITFABRICA, c.TIPO FROM dbo.CENTCOS AS C WHERE C.NOMBRE NOT LIKE '%obsoleto%' AND C.NOMBRE LIKE '%{0}%' and len(c.codcc)=4", filter_param)).ToList();
            cmbCentCos.DataSource = null;
            cmbCentCos.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbCentCos.DataSource = _dbConn.ExecuteQuery<CENTCOS>("SELECT c.AUXILIAR, c.CAPACIDAD, RTRIM(c.CODCC) AS CODCC, c.NIT, RTRIM(c.NOMBRE) AS NOMBRE, c.STADSINCRO, c.NITFABRICA, c.TIPO FROM dbo.CENTCOS AS C WHERE C.NOMBRE NOT LIKE '%obsoleto%' and len(codcc)=4").ToList();
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

        private void chkCatalogo_CheckedChanged(object sender, EventArgs e)
        {
            cmbCatalogo.DataSource = null;
           
                if (chkCatalogo.Checked == true)
                {//Consulta catalogo
                    cmbCatalogo.DataSource = repuestos.ToList();
                    cmbCatalogo.BackColor = Color.Beige;
                }
                else
                {//Consulta entradas
                    //cmbCatalogo.DataSource = _db.tblMantenMovRepuesto.Join(_db.MTMERCIA, m => m.CodProducto, p => p.CODIGO, (m, p) => new { Nombre = string.Format("{0} - [{1}]", p.DESCRIPCIO.TrimEnd(), p.CODIGO.TrimEnd()), Codigo = m.CodProducto }).Distinct().ToList();
                    cmbCatalogo.DataSource = _dbConn.vUsrMantenOrdenesCompras.Where(x =>x.FECHA>=DateTime.Now.AddMonths(-2)).Select(x => new { Nombre = x.Producto.TrimEnd(), Codigo = x.Codigo.TrimEnd() }).Distinct();
                    cmbCatalogo.BackColor = Color.Gold;
                }
                cmbCatalogo.DisplayMember = "Descripcion";
                cmbCatalogo.ValueMember = "Codigo";
                cmbCatalogo.SelectedIndex = -1;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProyecto.Text == "")
            {
                MessageBox.Show("Seleccione un proyecto de la lista.", "Salida de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProyecto.Focus();
                return;
            }
            if (cmbMaquina.Text == "")
            {
                MessageBox.Show("Seleccione una máquina de la lista.", "Salida de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMaquina.Focus();
                return;
            }
            if (cmbTecnico.Text == "")
            {
                MessageBox.Show("Seleccione un técnico de la lista.", "Salida de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTecnico.Focus();
                return;
            }
            if (cmbCatalogo.Text == "")
            {
                MessageBox.Show("Seleccione un repuesto de la lista.", "Salida de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCatalogo.Focus();
                return;
            }

            if (cmbCentCos.Text == "")
            {
                MessageBox.Show("Seleccione un Centro de Costos de la lista.", "Salida de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCentCos.Focus();
                return;
            }
            if (txtCantidad.Text == "" || decimal.Parse(txtCantidad.Text) == 0)
            {
                MessageBox.Show("La cantidad no es válida.", "Salida de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
                return;
            }
            try
            {
                string codcc = _dbConn.CENTCOS.Where(x => x.NOMBRE==cmbCentCos.Text).Select(s=>s.CODCC).SingleOrDefault();
                AdicionarItemSalidarepuesto(cmbCatalogo.SelectedValue.ToString(),cmbCatalogo.Text,cmbProyecto.SelectedValue.ToString(),
                    cmbProyecto.Text,BuscarCodigoMaquina(cmbMaquina.Text),cmbMaquina.Text,cmbTecnico.SelectedValue.ToString(),cmbTecnico.Text,
                    /*codcc.TrimEnd()*/ cmbCentCos.SelectedValue.ToString(), cmbCentCos.Text,decimal.Parse(txtCantidad.Text));
                cmbCatalogo.Text = "";
                txtCantidad.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Salida de Repuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AdicionarItemSalidarepuesto(string codigoRepuesto,string DescripcionRepuesto,string IdProyecto,string Proyecto,string IdMaquina, string Maquina, string Idtecnico, string Tecnico,string codcc, string NombreCodCC, decimal cantidad)
        {

            grid.Rows
                .Add(new object[] { codigoRepuesto, DescripcionRepuesto,IdProyecto, Proyecto, IdMaquina, Maquina, Idtecnico,Tecnico,codcc,NombreCodCC, string.Format("{0:0.##}", cantidad) });
        }

        private string BuscarCodigoMaquina(string descripcionMaquina)
        {
            return _dbConn.tblMantenMaquinas.Where(x => x.Nombre == descripcionMaquina).Select(s => s.CodMaquina).SingleOrDefault();
        }
        private string BuscarCodigoRepuesto(string descripcionRepuesto)
        {
            return repuestos.Where(x => string.Format("{0} - {1}", x.Codigo.TrimEnd(), x.Descripcio.TrimEnd()) == descripcionRepuesto).Select(s => s.Codigo.TrimEnd()).SingleOrDefault();
        }
        private void CargarGrid()
        {
            //grid.DataSource = salidaRepuestos;
            //grid.DataSource = salidaRepuestos;
            //gridSalidaRepuesto.DataSource = salidaRepuestos;
        }
        private void cmbCatalogo_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbCatalogo.Text;
            List<Repuesto> filteredItems = new List<Repuesto>();

            if (chkCatalogo.Checked)
            {
                filteredItems = _dbConn.MTMERCIA.Where(x =>(x.TIPOINV=="MTTO" || x.TIPOINV=="ADMON") && x.HABILITADO==true &&  (x.CODIGO.ToLower().Contains(filter_param.ToLower()) || x.DESCRIPCIO.ToLower().Contains(filter_param.ToLower()))).Select(s => new Repuesto() { Codigo = s.CODIGO.TrimEnd(), Descripcio = string.Format("{0} - {1}", s.CODIGO.TrimEnd(), s.DESCRIPCIO.TrimEnd()) }).ToList();
                if (String.IsNullOrWhiteSpace(filter_param))
                {
                    filteredItems = _dbConn.MTMERCIA.Where(x => (x.TIPOINV == "MTTO" || x.TIPOINV=="ADMON") && x.HABILITADO == true).Select(s => new Repuesto() { Codigo = s.CODIGO.TrimEnd(), Descripcio = string.Format("{0} - {1}", s.CODIGO.TrimEnd(), s.DESCRIPCIO.TrimEnd()) }).ToList();
                }

            }
            else
            {
                string consulta;
                consulta = string.Format("SELECT DISTINCT rtrim(m.PRODUCTO) as Codigo,rtrim(m.PRODUCTO) +' - ' +rtrim(m.NOMBRE) as Descripcio FROM dbo.MVTRADE m(nolock) INNER JOIN dbo.MTMERCIA p(nolock) ON m.PRODUCTO=p.CODIGO WHERE m.ORIGEN='com' AND m.TIPODCTO='or' AND DATEDIFF(MONTH,m.FECHA,GETDATE())<=6 AND p.TIPOINV in('mtto','admon') AND m.NOMBRE LIKE '%{0}%'", filter_param);
                filteredItems = _dbConn.ExecuteQuery<Repuesto>(consulta).ToList();
                    //_dbConn.vUsrMantenOrdenesCompras.Where(x => x.FECHA >= DateTime.Now.AddMonths(-10) && x.Producto.Contains(filter_param)).Select(x => new Repuesto() { Codigo = x.Codigo.TrimEnd(), Descripcio = string.Format("{0} - {1}", x.Codigo.TrimEnd(), x.Producto.TrimEnd()) }).Distinct().ToList();
                if (String.IsNullOrWhiteSpace(filter_param))
                {
                    filteredItems = _dbConn.ExecuteQuery<Repuesto>(string.Format("SELECT DISTINCT rtrim(m.PRODUCTO) as Codigo,rtrim(m.PRODUCTO) +' - ' + rtrim(m.NOMBRE) as Descripcio FROM dbo.MVTRADE m(nolock) INNER JOIN dbo.MTMERCIA p(nolock) ON m.PRODUCTO=p.CODIGO WHERE m.ORIGEN='com' AND m.TIPODCTO='or' AND DATEDIFF(MONTH,m.FECHA,GETDATE())<=6 AND p.TIPOINV in('mtto','admon')"), filter_param).ToList();
                    //_dbConn.vUsrMantenOrdenesCompras.Where(x => x.FECHA >= DateTime.Now.AddMonths(-10)).Select(x => new Repuesto() { Codigo = x.Codigo.TrimEnd(), Descripcio = string.Format("{0} - {1}", x.Codigo.TrimEnd(), x.Producto.TrimEnd()) }).Distinct().ToList();
                }
            }

            cmbCatalogo.DataSource = filteredItems;
            Cursor.Current = Cursors.Default;
            cmbCatalogo.ItemHeight = 100;
            cmbCatalogo.DisplayMember = "Descripcio";
            cmbCatalogo.ValueMember = "Codigo";
            cmbCatalogo.MaxDropDownItems = 8;
            cmbCatalogo.SelectedIndex = -1;
            cmbCatalogo.DroppedDown = true;
            cmbCatalogo.Text = filter_param;
            cmbCatalogo.SelectionLength = filter_param.Length;
            cmbCatalogo.Select(filter_param.Length, 0);



        }

        private void ctrolSalidaRepuesto_Load(object sender, EventArgs e)
        {
            salidaRepuestos = new List<tblMantenMovRepuesto>();
            centrosCostos= _dbConn.ExecuteQuery<CENTCOS>("SELECT c.AUXILIAR, c.CAPACIDAD, RTRIM(c.CODCC) AS CODCC, c.NIT, RTRIM(c.NOMBRE) AS NOMBRE, c.STADSINCRO, c.NITFABRICA, c.TIPO FROM dbo.CENTCOS AS C WHERE C.NOMBRE NOT LIKE '%obsoleto%' and len(codcc)=4").ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count != 0)
            {
                foreach (DataGridViewRow detalle in grid.Rows)
                {
                    tblMantenMovRepuesto salidaRepuesto = new tblMantenMovRepuesto();
                    if (decimal.Parse(detalle.Cells[10].Value.ToString()) > 0)
                    {
                        salidaRepuesto.Fecha_Hora = dFecha.Value;
                        salidaRepuesto.Tipo = 'S';
                        salidaRepuesto.Proveedor = "";
                        salidaRepuesto.CodProducto = detalle.Cells[0].Value.ToString();
                        salidaRepuesto.IdProyecto = detalle.Cells[2].Value.ToString();
                        salidaRepuesto.CodMaquina = detalle.Cells[4].Value.ToString();
                        salidaRepuesto.IdTecnico = detalle.Cells[6].Value.ToString();
                        salidaRepuesto.CodCC = detalle.Cells[8].Value.ToString();
                        salidaRepuesto.Cantidad = decimal.Parse(detalle.Cells[10].Value.ToString());
                        salidaRepuesto.OrdenCompra = "";
                        salidaRepuesto.FacturaProveedor = "";
                        salidaRepuesto.Observacion = "Salida de repuesto";
                        salidaRepuesto.Integrado = false;
                        salidaRepuesto.TipoMvto = "CON";
                    }
                    try
                    {
                        _dbConn.tblMantenMovRepuestos.InsertOnSubmit(salidaRepuesto);
                        _dbConn.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Salida de Repuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("Salida de repuesto exitosa.", "Salida de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCentCos.Text = "";
                grid.Rows.Clear();
            }
            else
            {
                MessageBox.Show("No hay datos para registrar.", "Salida de Repuesto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == a || e.KeyChar == (char)Keys.Enter))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtCantidad.Text.Contains("."))
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

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtCantidad, "");
        }

        private void cmbMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCentCos.Text = "";
            if(cmbMaquina.SelectedIndex!=-1 && cmbMaquina.SelectedIndex!=0)
            {
                cmbCentCos.DataSource = null;
                cmbCentCos.DataSource = centrosCostos;
                cmbCentCos.DisplayMember = "NOMBRE";
                cmbCentCos.ValueMember = "CODCC";
                string query = string.Format("SELECT rtrim(c.NOMBRE) as NOMBRE FROM dbo.tblMantenMaquinas m INNER JOIN dbo.CENTCOS c ON m.CodCC=c.CODCC WHERE m.Nombre='{0}'", cmbMaquina.Text);
                query = _dbConn.ExecuteQuery<string>(query).SingleOrDefault();
                cmbCentCos.SelectedIndex = cmbCentCos.FindStringExact(query);


            }

        }

 
    }
}
