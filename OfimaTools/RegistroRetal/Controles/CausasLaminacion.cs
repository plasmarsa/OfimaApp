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
    public partial class CausasLaminacion : UserControl
    {
        public short opcion_seleccionada { get; set; }
        public CausasLaminacion()
        {
            InitializeComponent();
            opcion_seleccionada = 0;
        }

        private void rbExtruder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExtruder.Checked)
                opcion_seleccionada = 1;
        }

        private void rbImpresion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImpresion.Checked)
                opcion_seleccionada = 2;
        }

        private void rbLaminacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaminacion.Checked)
                opcion_seleccionada = 3;
        }

        private void rbOtroMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtroMaterial.Checked)
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
