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
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace MezclasExt
{
    public partial class MovMezclaHistorico : Office2007Form
    {
        private  int idMezclaAgrupada = 0;
        private  OfimaticaDBContext db;
        public MovMezclaHistorico(ref OfimaticaDBContext DbContext,int IdRegistro)
        {
            db = DbContext;
            idMezclaAgrupada = IdRegistro;
            InitializeComponent();
        }

        private void MovMezclaHistorico_Load(object sender, EventArgs e)
        {
            CargarMovimientos();
        }
        private void CargarMovimientos()
        {
            GridPanel panel = Grid.PrimaryGrid;
            panel.Rows.Clear();


            var movimientos = db.tblMezclasAgrupacionComponentesMovimiento.
                GroupJoin(db.OPERARIOs, m => m.IdResponsable, i => i.OPERARIO1, (m, groupjoin) => new { m = m, groupjoin = groupjoin }).
                SelectMany(temp0 => temp0.groupjoin.DefaultIfEmpty(), (temp0, a) => new
                {
                    IdAgrupacion = temp0.m.IdAgrupacion,
                    FechaHora = temp0.m.FechaHora,
                    Nombre = a.NOMBRE,
                    TipoMvto = temp0.m.TipoMvto,
                    Pedido = temp0.m.Pedido,
                    Cantidad = temp0.m.Cantidad
                }).Where(x=>x.IdAgrupacion== idMezclaAgrupada);


            foreach (var item in movimientos)
            {
                object[] objDetalle = new object[27];
                objDetalle[0] = item.FechaHora;
                objDetalle[1] = item.Nombre;
                objDetalle[2] = item.Pedido;

                if(item.TipoMvto=="E")
                    objDetalle[3] = "Entrada";
                if (item.TipoMvto == "S")
                    objDetalle[3] = "Salida";
                if (item.TipoMvto == "D")
                    objDetalle[3] = "Devolución";

                if (item.TipoMvto == "E")
                    objDetalle[4] = item.Cantidad;

                if (item.TipoMvto == "D")
                    objDetalle[4] = item.Cantidad;

                if (item.TipoMvto == "S")
                    objDetalle[5] = item.Cantidad;

                GridRow detalle = new GridRow(objDetalle);
                panel.Rows.Add(detalle);
            }
        }
    }
    
}
