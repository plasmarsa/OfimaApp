using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using DevComponents.DotNetBar;
using Dataccess;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using System.Collections;

namespace MezclasExt
{
    public partial class frMain : Office2007Form
    {
        Properties.Settings _configuracion = new Properties.Settings();
        List<InsumoMezcla> lstMezclas;
        List<Mezcladora> lstMezcladoras;
        List<OPERARIO> lstOperarios;
        OfimaticaDBContext db;
        string codMezcladora;
        string cedula_responsable;
        int CapacidadMezcladora;

        public string strMezcla { get; set; }
        //string strResponsable;
        public frMain()
        {
            InitializeComponent();
            CapacidadMezcladora = 0;
            strMezcla = "";
            this.superTabItem1.Focus();
        }


        #region Modificar cadena de conexion
        private String ModificarDBConexion(String Servidor, String Database, string DBUser, string DBPassword)
        {
            //Data Source=hestia;Initial Catalog=PLASMARSA;Persist Security Info=True;User ID=ofimatica;Password=ofimatica
            String connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", Servidor, Database, DBUser, DBPassword);
            return connString;
        }
        #endregion

        private void ConexionDB()
        {
            string[] Argumentos = Environment.GetCommandLineArgs();
            if (Argumentos.Length > 1)
            {
                db = new OfimaticaDBContext();
                db = new OfimaticaDBContext(ModificarDBConexion(_configuracion.Servidor, Argumentos[2], _configuracion.dbUser, _configuracion.dbPassword));
                lblUsuario.Text = Argumentos[3].ToUpper();
                lblDatabase.Text = Argumentos[2].ToUpper();
            }
            else
            {
                db = new OfimaticaDBContext(ModificarDBConexion(_configuracion.Servidor, _configuracion.Database, _configuracion.dbUser, _configuracion.dbPassword));
                lblUsuario.Text = _configuracion.dbUser;
                lblDatabase.Text = _configuracion.Database.ToUpper();
            }
        }
        private void frMain_Load(object sender, EventArgs e)
        {
            //OfimaticaDBContext db = new OfimaticaDBContext();
            lblDescripcionMezclaBase.Text = "";
            lblNombreOperario.Text = "";
            ConexionDB();
            
            Cargar_Lista_Mezcladoras();
            Cargar_Lista_Mezclas();
            Cargar_Operarios();
            List<InsumoMezcla> lstIns;
            lstIns= db.tblMezclaExtruderComponentes.Join(db.MTMERCIA, c => c.Codigo, d => d.CODIGO, (c, d) => new { m = c, p = d }).Select(x => new InsumoMezcla() { Codigo = x.m.Codigo, Descripcion = string.Format("{0} - {1}", x.p.CODIGO.TrimEnd(), x.p.DESCRIPCIO.TrimEnd()),Tipo=x.m.Tipo }).ToList();
            mezclaDetalle1.lstInsumos = lstIns;
            mezclaDetalle2.lstInsumos = lstIns;
            mezclaDetalle3.lstInsumos = lstIns;
            mezclaDetalle4.lstInsumos = lstIns;
            mezclaDetalle1.DB = db;
            mezclaDetalle2.DB = db;
            mezclaDetalle3.DB = db;
            mezclaDetalle4.DB = db;
            mezclaDetalle1.NroMezcla = 1;
            mezclaDetalle2.NroMezcla = 2;
            mezclaDetalle3.NroMezcla = 3;
            mezclaDetalle4.NroMezcla = 4;
            superTabControl1.Tabs[0].Focus();
            InicializarGridBodega();
            Cargar_Lista_Mezclas();
            this.Refresh();

        }
        private void Cargar_Lista_Mezcladoras()
        {
            lstMezcladoras = new List<Mezcladora>();
            lstMezcladoras.Add(new Mezcladora("Mz01", "Mezcladora 1", 1500));
            lstMezcladoras.Add(new Mezcladora("Mz02", "Mezcladora 2", 2500));

            cmbMezcladora.DataSource = lstMezcladoras.ToList();
            cmbMezcladora.DisplayMember = "Nombre";
            cmbMezcladora.ValueMember = "Codigo";
            cmbMezcladora.SelectedIndex = -1;
        }
        private void Cargar_Operarios()
        {
            lstOperarios = db.OPERARIOs.ToList();
        }
        private void Cargar_Lista_Mezclas()
        {
            lstMezclas = new List<InsumoMezcla>();
            lstMezclas =
                db.tblMezclaExtruderComponentes.Join(db.MTMERCIA, c => c.Codigo, m => m.CODIGO, (c, m) => new { insumo = c, catalogo = m }).Select(x => new InsumoMezcla() { Codigo = x.insumo.Codigo, Descripcion = string.Format("{0} - {1}", x.insumo.Codigo, x.catalogo.DESCRIPCIO.TrimEnd()), Tipo = x.insumo.Tipo }).ToList();

        }
        private void cmbMezclaBase_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbMezclaBase.Text;
            List<InsumoMezcla> filteredItems = db.tblMezclaExtruderComponentes.Join(db.MTMERCIA, c => c.Codigo, d => d.CODIGO, (c, d) => new { cd = c, dd = d }).Where(x => x.cd.Tipo == "Mezcla Base" && x.cd.Codigo.Contains(filter_param)).Select(x => new InsumoMezcla() { Codigo = x.cd.Codigo, Descripcion = string.Format("{0} - {1}", x.cd.Codigo.TrimEnd(), x.dd.DESCRIPCIO.TrimEnd()) }).ToList();
            cmbMezclaBase.DataSource = null;
            cmbMezclaBase.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbMezclaBase.DataSource = db.tblMezclaExtruderComponentes.Join(db.MTMERCIA, c => c.Codigo, d => d.CODIGO, (c, d) => new { cd = c, dd = d }).Where(x => x.cd.Tipo == "Mezcla Base").Select(x => new InsumoMezcla() { Codigo = x.cd.Codigo, Descripcion = string.Format("{0} - {1}", x.cd.Codigo.TrimEnd(), x.dd.DESCRIPCIO.TrimEnd()) }).ToList();
            }
            Cursor.Current = Cursors.Default;
            cmbMezclaBase.DisplayMember = "Descripcion";
            cmbMezclaBase.ValueMember = "Codigo";
            cmbMezclaBase.SelectedIndex = -1;
            cmbMezclaBase.DroppedDown = true;
            cmbMezclaBase.Text = filter_param;
            cmbMezclaBase.SelectionLength = filter_param.Length;
            cmbMezclaBase.Select(filter_param.Length, 0);
        }
        private void cmbMezcladora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMezcladora.SelectedIndex != -1 && cmbMezcladora.SelectedValue != null)
            {
                Mezcladora p;
                p = lstMezcladoras.Where(x => x.codigo == cmbMezcladora.SelectedValue.ToString()).SingleOrDefault();
                if(p==null)
                {
                    CapacidadMezcladora = 0;
                    codMezcladora = "ND";
                }
                else
                { CapacidadMezcladora = p.capacidad;
                    codMezcladora = p.codigo;
                }
                    

                    
            }
            else
                CapacidadMezcladora = 0;
            lblCapacidad.Text = string.Format("{0} Kg", CapacidadMezcladora);
            mezclaDetalle1.cantidad_Mezcladora = CapacidadMezcladora;
            mezclaDetalle2.cantidad_Mezcladora = CapacidadMezcladora;
            mezclaDetalle3.cantidad_Mezcladora = CapacidadMezcladora;
            mezclaDetalle4.cantidad_Mezcladora = CapacidadMezcladora;
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
        private void cmbResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbResponsable.Text== "Dataccess.OPERARIO" || cmbResponsable.SelectedIndex==-1)
            {
                lblNombreOperario.Text = string.Empty;
                cedula_responsable = "";
            }
            else
            {
                OPERARIO operario = lstOperarios.Where(x => x.OPERARIO1 == cmbResponsable.Text.ToString()).SingleOrDefault();
                cedula_responsable = operario.OPERARIO1.TrimEnd();
                lblNombreOperario.Text = operario.NOMBRE.TrimEnd();
            }

            mezclaDetalle1.Responsable = cedula_responsable;
            mezclaDetalle2.Responsable = cedula_responsable;
            mezclaDetalle3.Responsable = cedula_responsable;
            mezclaDetalle4.Responsable = cedula_responsable;
        }
        private void cmbMezclaBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMezclaBase.SelectedIndex != -1 && cmbMezclaBase.SelectedValue != null)
            {
                lblDescripcionMezclaBase.Text = lstMezclas.Where(x => x.Codigo == cmbMezclaBase.SelectedValue.ToString()).Select(x => x.Descripcion).SingleOrDefault();
                strMezcla = cmbMezclaBase.SelectedValue.ToString();
            }
            else
            {
                lblDescripcionMezclaBase.Text = "";
                strMezcla = string.Empty;
            }

            mezclaDetalle1.MezclaBase = strMezcla;
            mezclaDetalle2.MezclaBase = strMezcla;
            mezclaDetalle3.MezclaBase = strMezcla;
            mezclaDetalle4.MezclaBase = strMezcla;
        }
        public Boolean  VerificarMezcladoraEstaAlTope()
        {
            double cantidad;
            if(CapacidadMezcladora< this.mezclaDetalle1.Cantidad_Mezcla+ this.mezclaDetalle2.Cantidad_Mezcla+ this.mezclaDetalle3.Cantidad_Mezcla+ this.mezclaDetalle4.Cantidad_Mezcla)
            {
                cantidad = (this.mezclaDetalle1.Cantidad_Mezcla + this.mezclaDetalle2.Cantidad_Mezcla + this.mezclaDetalle3.Cantidad_Mezcla + this.mezclaDetalle4.Cantidad_Mezcla) - CapacidadMezcladora;
                MessageBox.Show(string.Format("Cantidad a mezclar excede la capacidad de la mezcladora en {0} Kg",cantidad),"Validando ocupación de la mezcladora.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return true;
            }
            cantidad = (this.mezclaDetalle1.Cantidad_Mezcla + this.mezclaDetalle2.Cantidad_Mezcla + this.mezclaDetalle3.Cantidad_Mezcla + this.mezclaDetalle4.Cantidad_Mezcla);
            lblOcupacion.Text = string.Format("{0} Kg", cantidad);
            return false;
        }
        private void btnAddMezclas_Click(object sender, EventArgs e)
        {
            Validar_Responsable();
            List<Controles.MezclaDetalle> p= new List<Controles.MezclaDetalle>();
            p.Add(mezclaDetalle1);
            p.Add(mezclaDetalle2);
            p.Add(mezclaDetalle3);
            p.Add(mezclaDetalle4);

            if(mezclaDetalle1.Cantidad_Mezcla+ mezclaDetalle2.Cantidad_Mezcla+ mezclaDetalle3.Cantidad_Mezcla+ mezclaDetalle4.Cantidad_Mezcla>CapacidadMezcladora )
            {
                int cantidad = (mezclaDetalle1.Cantidad_Mezcla + mezclaDetalle2.Cantidad_Mezcla + mezclaDetalle3.Cantidad_Mezcla + mezclaDetalle4.Cantidad_Mezcla) - CapacidadMezcladora;
                MessageBox.Show(string.Format("La cantidad a mezclar supera la capacidad de la mezcladora en {0} Kg\nPor favor verifique las cantidades a mezclar.", cantidad), "Validando ocupación de la mezcladora.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tblMezclaExtruder mezcladb=null;
            tblMezclaExtruderDetalle mezcladbDetalle = null;
            foreach (Controles.MezclaDetalle  objmezcla in p)
            {
                if (objmezcla.Cantidad_Mezcla>0)
                {
                    if (mezcladb == null)
                    {
                        mezcladb = new tblMezclaExtruder();
                        mezcladb.CodMezclaBase = strMezcla;
                        mezcladb.FechaHora = DateTime.Now;
                        mezcladb.CodMezcladora = codMezcladora;
                        mezcladb.IdResponsable = cedula_responsable;
                        mezcladb.UserIng = lblUsuario.Text;
                        db.tblMezclaExtruder.InsertOnSubmit(mezcladb);
                        db.SubmitChanges();

                    }
                    if (mezcladb!=null)
                    {
                        foreach (var o in objmezcla.lstDetalleMezcla )
                        {
                            mezcladbDetalle = new tblMezclaExtruderDetalle();
                            mezcladbDetalle.tblMezclaExtruder = mezcladb;
                            mezcladbDetalle.Adicion = o.Adicion;
                            mezcladbDetalle.Cantidad = o.Cantidad;
                            mezcladbDetalle.CodInsumo = o.Codigo_Insumo;
                            mezcladbDetalle.Factor = o.Factor;
                            mezcladbDetalle.NroMezcla = objmezcla.NroMezcla;
                            mezcladbDetalle.TotalMezcla = objmezcla.Cantidad_Mezcla;
                            db.tblMezclaExtruderDetalles.InsertOnSubmit(mezcladbDetalle);
                            db.SubmitChanges();
                            mezcladbDetalle = null;
                        }
                    }
                    db.tblMezclaCantidadesSubmezclas.InsertOnSubmit(new tblMezclaCantidadesSubmezcla() { IdMezcla = mezcladb.IdMezcla, NroSubmezcla = objmezcla.NroMezcla, Cantidad = objmezcla.Cantidad_Mezcla });
                    db.SubmitChanges();
                }
            }

            if(mezcladb!=null)
            {
                if (mezcladb.IdMezcla != 0)
                {
                    //db.uspProcesarMezclaExtruder(mezcladb.IdMezcla);
                    db.ExecuteCommand(string.Format("Exec uspProcesarMezclaExtruder {0}", mezcladb.IdMezcla));
                }
                mezcladb = null;
                mezclaDetalle1.InicializarMezcla();
                mezclaDetalle2.InicializarMezcla();
                mezclaDetalle3.InicializarMezcla();
                mezclaDetalle4.InicializarMezcla();
                InicializarControles();


            }
        }

        private void Validar_Responsable()
        {
            if(String.IsNullOrEmpty(cedula_responsable))
            {
                MessageBox.Show("Debe selleccionar un responsable de la mezcla.", "Validando responsable..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void InicializarControles()
        {
            lblCapacidad.Text = string.Empty;
            lblDescripcionMezclaBase.Text = string.Empty;
            lblNombreOperario.Text = string.Empty;
            cmbMezclaBase.SelectedIndex = -1;
            cmbMezcladora.SelectedIndex = -1;
            cmbResponsable.SelectedIndex = -1;

        }
        private void btnAdicionarComponente_Click(object sender, EventArgs e)
        {
            sGridComp.PrimaryGrid.Rows.Clear();
            tblMezclaExtruderComponente componente = new tblMezclaExtruderComponente();
            componente = db.tblMezclaExtruderComponentes.Where(x => x.Codigo == cmbInsumo.SelectedValue.ToString().TrimEnd()).SingleOrDefault();
            if (componente == null)
            {
                componente = new tblMezclaExtruderComponente();
                componente.Codigo = cmbInsumo.SelectedValue.ToString().TrimEnd();
                componente.Tipo = cmbTipoComponente.Text;
            }
            else
                return;
            db.tblMezclaExtruderComponentes.InsertOnSubmit(componente);
            db.SubmitChanges();
            cmbInsumo.Text = string.Empty;
            cmbTipoComponente.SelectedIndex = -1;
            InicializarTabComponentes();
        }
        private void InicializarTabComponentes()
        {
            GridPanel panel = sGridComp.PrimaryGrid;
            panel.Rows.Clear();

            //string[] tiposComponentes = { "Mezcla", "Antioxidante", "Pigmento","Ayudante de proceso","Slip","Otro" };
            //string[] materiasPrimas = lstMateriasPrimas.Select(x => x.Codigo.TrimEnd()).ToArray();
            //panel.Columns["tipo"].EditorType = typeof(TipoCompCombobox);
            //panel.Columns["tipo"].EditorParams = new object[] { tiposComponentes };
            //panel.Columns["componente"].EditorType = typeof(MateriasPrimasCombobox);
            //panel.Columns["componente"].EditorParams = new object[] { lstMateriasPrimas};

            foreach (tblMezclaExtruderComponente comp in db.tblMezclaExtruderComponentes)
            {
                string nombreComponente = db.MTMERCIA.Where(x => x.CODIGO == comp.Codigo).Select(x => x.DESCRIPCIO.TrimEnd()).SingleOrDefault();
                GridRow row = new GridRow(comp.Codigo, nombreComponente, comp.Tipo, "Eliminar");
                panel.Rows.Add(row);

            }

        }

        private void cmbInsumo_TextUpdate(object sender, EventArgs e)
        {
            string filter_param = cmbInsumo.Text;
            List<InsumoMezcla> filteredItems = db.MTMERCIA.Where(x => (x.TIPOINV == "MP" || x.CLASIFICA2 == "MZ") && x.HABILITADO == true && x.CODIGO.ToLower().Contains(filter_param.ToLower())).Select(x => new InsumoMezcla() { Codigo = x.CODIGO.TrimEnd(), Descripcion = string.Format("{0} - {1}", x.CODIGO.TrimEnd(), x.DESCRIPCIO.TrimEnd()) }).ToList();
            cmbInsumo.DataSource = null;
            cmbInsumo.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filter_param))
            {
                cmbInsumo.DataSource = db.MTMERCIA.Where(x => (x.TIPOINV == "MP" || x.CLASIFICA2 == "MZ") && x.HABILITADO == true).Select(x => new InsumoMezcla() { Codigo = x.CODIGO.TrimEnd(), Descripcion = string.Format("{0} - {1}", x.CODIGO.TrimEnd(), x.DESCRIPCIO.TrimEnd()) }).ToList();
            }
            Cursor.Current = Cursors.Default;
            cmbInsumo.DisplayMember = "Descripcion";
            cmbInsumo.ValueMember = "Codigo";
            cmbInsumo.SelectedIndex = -1;
            cmbInsumo.DroppedDown = true;
            cmbInsumo.Text = filter_param;
            cmbInsumo.SelectionLength = filter_param.Length;
            cmbInsumo.Select(filter_param.Length, 0);
        }

        private void superTabItem5_Click(object sender, EventArgs e)
        {
            InicializarTabComponentes();
        }

        private void superTabItem10_Click(object sender, EventArgs e)
        {
            //Resumen de insumos a utilizar
            GridPanel panel = GridResultados.PrimaryGrid;
            panel.Rows.Clear();

            List<Controles.DetalleMezcla> lstResumen;
            lstResumen = new List<Controles.DetalleMezcla>();
            lstResumen.AddRange(mezclaDetalle1.lstDetalleMezcla);
            lstResumen.AddRange(mezclaDetalle2.lstDetalleMezcla);
            lstResumen.AddRange(mezclaDetalle3.lstDetalleMezcla);
            lstResumen.AddRange(mezclaDetalle4.lstDetalleMezcla);
            var resumen = lstResumen.GroupBy(x => new {x.Tipo, x.Codigo_Insumo, x.Nombre_Insumo }).Select(x => new { Tipo=x.Key.Tipo, Codigo_Insumo = x.Key.Codigo_Insumo, Nombre_Insumo = x.Key.Nombre_Insumo, Total_Cantidad = x.Sum(z => z.Cantidad) });

            foreach (var item in resumen)
            {
                object[] objDetalle = new object[4];
                objDetalle[0] = item.Tipo;
                objDetalle[1] = item.Codigo_Insumo;
                objDetalle[2] = item.Nombre_Insumo;
                objDetalle[3] = string.Format("{0:F2}", item.Total_Cantidad);
                GridRow detalle = new GridRow(objDetalle);
                panel.Rows.Add(detalle);
            }
                

        }

        private void sGridComp_CellClick(object sender, GridCellClickEventArgs e)
        {
            var senderGrid = (SuperGridControl)sender;

           /* if (e.GridCell.ColumnIndex == senderGrid.PrimaryGrid.Columns["eliminar"].ColumnIndex && e.GridCell.RowIndex >= 0)
            {
                GridCell cell = sGridComp.PrimaryGrid.GetCell(e.GridCell.RowIndex, 1) as GridCell;
                if (Convert.ToBoolean(sGridComp.PrimaryGrid.GetCell(e.GridCell.RowIndex, 4).Value))
                {
                    //MessageBox.Show("Se puede borrar!");
                    //DetalleMezcla detalleMezcla = lstDetalleMezcla.Where(x => x.Codigo_Insumo == sGridComp.PrimaryGrid.GetCell(e.GridCell.RowIndex, 1).Value.ToString()).Single();
                    //lstDetalleMezcla.Remove(detalleMezcla);
                    //Grid.PrimaryGrid.Rows.RemoveAt(e.GridCell.RowIndex);
                    sGridComp.Refresh();
                }

            }*/
        }

        private void superTabItem4_Click(object sender, EventArgs e)
        {
            //InicializarGridBodega();
            ActualizarMezclasBodega();
            
        }
        private void InicializarGridBodega()
        {
            GridPanel panel = bGrid.PrimaryGrid;
            panel.Columns["movimiento"].EditorType = typeof(MovMezclaExt);
            panel.Columns["movimiento"].EditorParams = new object[] { panel,lstOperarios,db,this };

            panel.Columns["informacion"].EditorType = typeof(InfoMezclaExt);
            panel.Columns["informacion"].EditorParams = new object[] { panel, lstOperarios, db };

            panel.Columns["movimientos"].EditorType = typeof(Movimientos);
            panel.Columns["movimientos"].EditorParams = new object[] { panel, db };

        }
        public void ActualizarMezclasBodega()
        {
            GridPanel panel = bGrid.PrimaryGrid;
            panel.Rows.Clear();

            List<tblMezclasAgrupacionComponente> lstMezclaAgrupada;
            lstMezclaAgrupada = new List<tblMezclasAgrupacionComponente>();
            lstMezclaAgrupada = db.tblMezclasAgrupacionComponentes.ToList();

            var lstCodigos = db.tblMezclasAgrupacionComponentes.Join(db.MTMERCIA, a => a.MezclaBase, m => m.CODIGO, (a, m) => new { a.MezclaBase, m.DESCRIPCIO }).Select(x => new { x.MezclaBase, x.DESCRIPCIO }).ToList();
            

            foreach (tblMezclasAgrupacionComponente item in lstMezclaAgrupada)
            {
                if (string.IsNullOrEmpty(item.MezclaBase))
                    return;

                object[] objDetalle = new object[27];
                objDetalle[0] = "¡";
                objDetalle[1] = "M";
                objDetalle[2] = item.IdReg;
                objDetalle[3] = item.MezclaBase;
                objDetalle[4] = lstCodigos.Where(x => x.MezclaBase == item.MezclaBase.ToString()).Select(x => x.DESCRIPCIO.TrimEnd().ToString()).Take(1).ToList()[0];
                objDetalle[5] = item.Cantidad;
                objDetalle[6] = item.Pigmento;
                objDetalle[7] = item.Factor_Pigmento;
                objDetalle[8] = item.Ayudante;
                objDetalle[9] = item.Factor_Ayudante;
                objDetalle[10] = item.Antiblock;
                objDetalle[11] = item.Factor_Antiblock;
                objDetalle[12] = item.Antioxidante;
                objDetalle[13] = item.Factor_Antioxidante;
                objDetalle[14] = item.Slip;
                objDetalle[15] = item.Factor_Slip;
                objDetalle[16] = item.Otro;
                objDetalle[17] = item.Factor_Otro;
                objDetalle[18] = item.ComponenteBase1;
                objDetalle[19] = item.FactorComponenteBase1;
                objDetalle[20] = item.ComponenteBase2;
                objDetalle[21] = item.FactorComponenteBase2;
                objDetalle[22] = item.ComponenteBase3;
                objDetalle[23] = item.FactorComponenteBase3;
                objDetalle[24] = item.ComponenteBase4;
                objDetalle[25] = item.FactorCOmponenteBase4;
                objDetalle[26] = "h";

                GridRow detalle = new GridRow(objDetalle);
                panel.Rows.Add(detalle);
            }
        }

        private void superTabItem4_GotFocus(object sender, EventArgs e)
        {
            ActualizarMezclasBodega();
        }

        private void bGrid_CellClick(object sender, GridCellClickEventArgs e)
        {
            var senderGrid = (SuperGridControl)sender;

            /*if (e.GridCell.ColumnIndex == senderGrid.PrimaryGrid.Columns["movimiento"].ColumnIndex && e.GridCell.RowIndex >= 0)
            {
                GridCell cell = sGridComp.PrimaryGrid.GetCell(e.GridCell.RowIndex, 1) as GridCell;
                if (Convert.ToBoolean(sGridComp.PrimaryGrid.GetCell(e.GridCell.RowIndex, 4).Value))
                {
                    //MessageBox.Show("Se puede borrar!");
                    //DetalleMezcla detalleMezcla = lstDetalleMezcla.Where(x => x.Codigo_Insumo == sGridComp.PrimaryGrid.GetCell(e.GridCell.RowIndex, 1).Value.ToString()).Single();
                    //lstDetalleMezcla.Remove(detalleMezcla);
                    //Grid.PrimaryGrid.Rows.RemoveAt(e.GridCell.RowIndex);
                    bGrid.Refresh();
                }

            }*/
        }

        private void superTabControlPanel1_Click(object sender, EventArgs e)
        {

        }
    }

    internal class Movimientos: GridButtonEditControl
    {
        private GridPanel bgrid;
        private int idmezcla;
        private OfimaticaDBContext dbcontext;

        public Movimientos(GridPanel BGrid, ref OfimaticaDBContext dbContext)
        {
            bgrid = BGrid;
            dbcontext = dbContext;
            Click += Movimientos_Click;

        }
        void Movimientos_Click(object sender, EventArgs e)
        {
            string s = EditorCell.Value as string;
            if (s != null)
            {
                GridCell celda = bgrid.GetCell(bgrid.RowIndex, 2) as GridCell;
                GridRow linea = bgrid.ActiveRow as GridRow;
                idmezcla = int.Parse(linea["idmezcla"].Value.ToString());
                MovMezclaHistorico form = new MovMezclaHistorico(ref dbcontext,idmezcla);
                form.lblMezclaBase.Text= "Mezcla Base:" + linea["mezclabase"].Value.ToString();
                form.ShowDialog();

            }

        }
    }

    internal class MovMezclaExt:GridButtonEditControl
    {
        private GridPanel bgrid;
        private int idmezcla;
        private List<OPERARIO> lstoperarios;
        private OfimaticaDBContext dbcontext;
        private frMain app;
        public MovMezclaExt(GridPanel BGrid,ref List<OPERARIO> Operarios,ref OfimaticaDBContext dbContext, frMain Aplicacion)
        {
            bgrid = BGrid;
            lstoperarios = Operarios;
            dbcontext = dbContext;
            Click += MovMezclaExt_Click;
            app = Aplicacion;
        }
        void MovMezclaExt_Click(object sender, EventArgs e)
        {
            string s = EditorCell.Value as string;

            if (s != null)
            {
                MovMezclaForm form = new MovMezclaForm() ;
                form.db = dbcontext;
                form.lstOperarios = lstoperarios;
                GridCell celda = bgrid.GetCell(bgrid.RowIndex, 2) as GridCell;
                GridRow linea = bgrid.ActiveRow as GridRow;
                form.lblMezclaBase.Text ="Mezcla Base:" + linea["mezclabase"].Value.ToString();
                form.Cantidad_Disponible = (decimal)linea["cantidad"].Value;
                idmezcla = int.Parse( linea["idmezcla"].Value.ToString());
                form.idMezclaAgrupada = idmezcla;
                form.ShowDialog();
                app.ActualizarMezclasBodega();
                
            }
        }
    }
    internal class InfoMezclaExt:GridButtonEditControl
    {
        private GridPanel bgrid;
        private int idmezcla;
        private List<OPERARIO> lstoperarios;
        private OfimaticaDBContext dbcontext;
        public InfoMezclaExt(GridPanel BGrid, ref List<OPERARIO> Operarios, ref OfimaticaDBContext dbContext)
        {
            bgrid = BGrid;
            lstoperarios = Operarios;
            dbcontext = dbContext;
            Click += InfoMezclaExt_Click;
        }
        void InfoMezclaExt_Click(object sender, EventArgs e)
        {
            string s = EditorCell.Value as string;

            if (s != null)
            {
                InfoMezclaEx form = new InfoMezclaEx();
                //form.db = dbcontext;
                GridCell celda = bgrid.GetCell(bgrid.RowIndex, 2) as GridCell;
                GridRow linea = bgrid.ActiveRow as GridRow;
                form.lblCantidad.Text = string.Format("{0} Kg disponibles", linea["cantidad"].Value.ToString());
                form.txtComponentesMezcla.Text = ConsultarComponentesMezcla(linea).ToString();
                form.lblMezclaBase.Text = "Mezcla Base: " + linea["mezclabase"].Value.ToString();
                idmezcla = int.Parse(linea["idmezcla"].Value.ToString());
                form.ShowDialog();
                
            }
        }
        private StringBuilder ConsultarComponentesMezcla(GridRow linea)
        {
            StringBuilder strBuider = null;
            string strLinea=string.Empty;
            strBuider = new StringBuilder();
            //strLinea = "*Componentes Base:\n\r";
            strBuider.Append("*Componentes Base:\r\n");
            if (!string.IsNullOrEmpty(linea["componente1"].Value.ToString() ))
            {
                strBuider.Append( string.Format("\t{0} --> Factor: {1}\r\n", linea["componente1"].Value.ToString(), linea["fcomponente1"].Value));
            }
            if (!string.IsNullOrEmpty(linea["componente2"].Value.ToString()))
            {
                strBuider.Append( string.Format("\t{0} --> Factor: {1}\r\n", linea["componente2"].Value.ToString(), linea["fcomponente2"].Value));
            }
            if (!string.IsNullOrEmpty(linea["componente3"].Value.ToString()))
            {
                strBuider.Append( string.Format("\t{0} --> Factor: {1}\r\n", linea["componente3"].Value.ToString(), linea["fcomponente3"].Value));
            }
            if (!string.IsNullOrEmpty(linea["componente4"].Value.ToString()))
            {
                strBuider.Append(string.Format("\t{0} --> Factor: {1}\r\n", linea["componente4"].Value.ToString(), linea["fcomponente4"].Value));
            }
            if (!string.IsNullOrEmpty(linea["pigmento"].Value.ToString()))
            {
                strBuider.Append("*Pigmento:\r\n");
                strBuider.Append( string.Format("\t{0} --> Factor: {1}\r\n", linea["pigmento"].Value.ToString(), linea["fpigmento"].Value));
            }
            if (!string.IsNullOrEmpty(linea["ayudante"].Value.ToString()))
            {
                strBuider.Append("*Ayudante de Proceso:\r\n");
                strBuider.Append( string.Format(" \t{0} --> Factor: {1}\r\n", linea["ayudante"].Value.ToString(), linea["fayudante"].Value));
            }
            if (!string.IsNullOrEmpty(linea["antiblock"].Value.ToString()))
            {
                strBuider.Append("*Antiblock:\r\n");
                strBuider.Append( string.Format("\t{0} --> Factor: {1}\r\n", linea["antiblock"].Value.ToString(), linea["fantiblock"].Value));
            }
            if (!string.IsNullOrEmpty(linea["slip"].Value.ToString()))
            {
                strBuider.Append("*Slip:\r\n");
                strBuider.Append( string.Format("\t{0} --> Factor: {1}\r\n", linea["slip"].Value.ToString(), linea["fslip"].Value));
            }
            if (!string.IsNullOrEmpty(linea["otro"].Value.ToString()))
            {
                strBuider.Append("*Otro Aditivo:\r\n");
                strBuider.Append( string.Format("\t{0} --> Factor: {1}\r\n", linea["otro"].Value.ToString(), linea["fotro"].Value));
            }

            return strBuider;
        }

    }
    public class InsumoMezcla
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
    }
    public class Mezcladora
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int capacidad { get; set; }

        public Mezcladora(string Codigo, string Nombre, int Capacidad)
        {
            codigo = Codigo;
            nombre = Nombre;
            capacidad = Capacidad;
        }
    }
}
