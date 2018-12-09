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

namespace CtrolAlmacenMantenimiento
{
    public partial class frmSaldoDetalle : Form
    {
        private OfimaticaDBContext _dbconexion;
        private string _repuesto,_descripcionrepuesto,_codlinea,_linea;
        public bool Movimientos_actualizados=false;
                
        public frmSaldoDetalle()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSaldoDetalle_Activated(object sender, EventArgs e)
        {
            if (Movimientos_actualizados)
                frmSaldoDetalle_Load(null,null);

        }

        public frmSaldoDetalle(ref OfimaticaDBContext dbConexion,string codlinea,string linea, string repuesto,string descripcionrepuesto)
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            _dbconexion = dbConexion;
            _repuesto = repuesto;
            _descripcionrepuesto = descripcionrepuesto;
            _codlinea = codlinea;
            _linea = linea;
        }

        private void frmSaldoDetalle_Load(object sender, EventArgs e)
        {
            Movimientos_actualizados = false;
            string sqlQuery;
            gridMov.Rows.Clear();
            sqlQuery = "";
            sqlQuery += "SELECT t.idmov,t.Fecha_Hora as fecha,ISNULL(r.Nombre_Completo,ISNULL(e.OtroNombre,'')) AS Tecnico,t.OrdenCompra as Orden,t.FacturaProveedor as Factura,t.TipoMvto, ";
            sqlQuery += "CASE t.Tipo WHEN 'E' THEN t.Cantidad else cast(0 as decimal(12,4)) END AS Entrada,CASE t.Tipo WHEN 'S' THEN t.Cantidad else cast(0 as decimal(12,4)) END AS Salida ";
            sqlQuery += "FROM dbo.tblMantenMovRepuesto t LEFT JOIN dbo.tblMantenTecnico e ON e.IdTecnico = t.IdTecnico ";
            sqlQuery += "LEFT JOIN dbo.vUsrGosem_ghPlasmar_rhRecursos r ON r.cod_recurso=t.IdTecnico ";
            sqlQuery += string.Format("WHERE t.CodProducto = '{0}' Order by t.Fecha_Hora", _repuesto);

            lblLinea.Text = _codlinea + "  |  " + _linea;
            lblRepuesto.Text = _repuesto + "  |  " + _descripcionrepuesto;
            List<DetalleConsumo> entrada_salidas;
            entrada_salidas = _dbconexion.ExecuteQuery<DetalleConsumo>(sqlQuery).ToList();
            foreach(DetalleConsumo detalle in entrada_salidas)
            {
                gridMov.Rows.Add(new object[] { detalle.idmov, detalle.fecha,detalle.tecnico, detalle.orden, detalle.factura, detalle.tipomvto, detalle.entrada, detalle.salida,"Modificar" });
               
            }
        }

        private void gridMov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["modificar"].Index && e.RowIndex >= 0)
            {
                string idreg = senderGrid.Rows[e.RowIndex].Cells["idmvto"].Value.ToString().TrimEnd();
                string tecnico = senderGrid.Rows[e.RowIndex].Cells["tecnico"].Value.ToString().TrimEnd();
                

                if (!string.IsNullOrWhiteSpace(idreg))
                {
                    tblMantenMovRepuesto movimiento = _dbconexion.tblMantenMovRepuestos.Where(x => x.IdMov == int.Parse(idreg)).SingleOrDefault();
                    frModificarMov obj = new frModificarMov(ref _dbconexion, movimiento,tecnico,this);
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.Show();
                }



            }
        }
    }
}
