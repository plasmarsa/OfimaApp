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

    public partial class CausaRefilado : UserControl
    {
        public short opcion_seleccionada { get; set; }
        public CausaRefilado()
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

        private void rbLaminacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaminacion.Checked)
                opcion_seleccionada = 3;
        }

        private void rbCola_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCola.Checked)
                opcion_seleccionada = 4;
        }

        private void rbMaquina_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaquina.Checked)
                opcion_seleccionada = 5;
        }

        private void rbTiraTTE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTiraTTE.Checked)
                opcion_seleccionada = 6;
        }


        private void rbTiraImpresa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbTiraImpresa.Checked)
                opcion_seleccionada = 7;
        }
    }
}
