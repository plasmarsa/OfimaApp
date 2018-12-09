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

namespace MezclasExt
{
    public partial class InfoMezclaEx : Office2007Form
    {
        public InfoMezclaEx()
        {
            InitializeComponent();
        }

        private void bntAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
