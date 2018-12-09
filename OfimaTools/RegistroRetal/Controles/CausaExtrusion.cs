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
    public partial class CausaExtrusion : UserControl
    {
        public short opcion_seleccionada { get; set; }
        public CausaExtrusion()
        {
            InitializeComponent();
            opcion_seleccionada = 0;
        }

        public  void Resetear_Controles()
        {
            opcion_seleccionada = 0;
            foreach(RadioButton r in this.groupBox4.Controls)
            {
                r.Checked = false  ;
            }

        }
        private void rbMontaje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMontaje.Checked)
                opcion_seleccionada = 1;
        }

        private void rbCuchillas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuchillas.Checked)
                opcion_seleccionada = 2;
        }

        private void rbTratado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTratado.Checked)
                opcion_seleccionada = 3;
        }

        private void rbProgramacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProgramacion.Checked)
                opcion_seleccionada = 4;
        }

        private void rbCambioMallas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCambioMallas.Checked)
                opcion_seleccionada = 5;
        }

        private void rbApagon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbApagon.Checked)
                opcion_seleccionada = 6;
        }

        private void rbLimpiezaBoquilla_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLimpiezaBoquilla.Checked)
                opcion_seleccionada = 7;
        }

        private void rbCambioGrano_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCambioGrano.Checked)
                opcion_seleccionada = 8;
        }

        private void rbEnsayo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnsayo.Checked)
                opcion_seleccionada = 9;
        }

        private void rbDañoMecanico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDañoMecanico.Checked)
                opcion_seleccionada = 10;
        }

        private void rbDañoElectrico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDañoElectrico.Checked)
                opcion_seleccionada = 11;
        }

        private void rbFaltaFlecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFaltaFlecha.Checked)
                opcion_seleccionada = 12;
        }

        private void rbDesinfle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDesinfle.Checked)
                opcion_seleccionada = 13;
        }

        private void rbTorta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTorta.Checked)
                opcion_seleccionada = 14;
        }

        private void rbCalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCalidad.Checked)
                opcion_seleccionada = 15;
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked)
                opcion_seleccionada = 16;
        }
    }
}
