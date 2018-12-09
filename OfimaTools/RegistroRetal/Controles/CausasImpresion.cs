using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroRetal.Controles
{
    public partial class CausasImpresion : UserControl
    {
        public short opcion_seleccionada { get; set; }
        public CausasImpresion()
        {
            InitializeComponent();
            opcion_seleccionada = 0;
        }

        private void rbRetalImpreso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRetalImpreso.Checked)
                opcion_seleccionada = 1;
        }

        private void rbRetalExtrusion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRetalExtrusion.Checked)
                opcion_seleccionada = 2;
        }

        private void rbPicadura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPicadura.Checked)
                opcion_seleccionada = 3;
        }

        private void rbMaterialMontaje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaterialMontaje.Checked)
                opcion_seleccionada = 4;
        }
        public void Resetear_Controles()
        {
            opcion_seleccionada = 0;
            foreach (RadioButton r in this.groupBox4.Controls)
            {
                r.Checked = false;
            }

        }

    }
}
