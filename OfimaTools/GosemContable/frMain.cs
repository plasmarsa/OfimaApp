using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GosemContable
{
    public partial class frMain : Form
    {
        ctrolMigrarDatosContables _ctrolMigrarDatosContables;
        public frMain()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ActivarControl(string Nombre_Control)
        {
            pControl.Controls.Clear();
            switch (Nombre_Control)
            {
                case "migrar":
                    lblTitulo.Text = "Entrada de Repuestos";
                    _ctrolMigrarDatosContables = new ctrolMigrarDatosContables();
                    pControl.Controls.Add(_ctrolMigrarDatosContables);
                    _ctrolMigrarDatosContables.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolMigrarDatosContables.Location = new System.Drawing.Point(6, 3);
                    this._ctrolMigrarDatosContables.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolMigrarDatosContables.Name = "control";
                    this._ctrolMigrarDatosContables.Size = new System.Drawing.Size(874, 478);
                    this._ctrolMigrarDatosContables.TabIndex = 1;
                    break;
                default:
                    lblTitulo.Text = "Entrada de Repuestos";
                    _ctrolMigrarDatosContables = new ctrolMigrarDatosContables();
                    pControl.Controls.Add(_ctrolMigrarDatosContables);
                    _ctrolMigrarDatosContables.Dock = System.Windows.Forms.DockStyle.Fill;
                    this._ctrolMigrarDatosContables.Location = new System.Drawing.Point(6, 3);
                    this._ctrolMigrarDatosContables.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
                    this._ctrolMigrarDatosContables.Name = "control";
                    this._ctrolMigrarDatosContables.Size = new System.Drawing.Size(874, 478);
                    this._ctrolMigrarDatosContables.TabIndex = 1;
                    break;
            }
        }

        private void btnMigrarDatos_Click(object sender, EventArgs e)
        {
            ActivarControl("migrar");
        }
    }
}
