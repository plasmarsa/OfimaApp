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
    public partial class CausaSellado : UserControl
    {
        public short opcion_seleccionada { get; set; }
        public CausaSellado()
        {
            InitializeComponent();
            opcion_seleccionada = 0;
        }
        public void Resetear_Controles()
        {
            opcion_seleccionada = 0;
            foreach (RadioButton r in this.groupBox4.Controls)
            {
                r.Checked = false;
            }
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

        private void rbMaquina_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaquina.Checked)
                opcion_seleccionada = 3;
        }

        private void rbTroquel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTroquel.Checked)
                opcion_seleccionada = 4;
        }

        private void rbTira_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTira.Checked)
                opcion_seleccionada = 5;
        }

        private void rbEnfuellado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnfuellado.Checked)
                opcion_seleccionada = 6;
        }

        private void rbRefilado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRefilado.Checked)
                opcion_seleccionada = 7;
        }
    }
}
