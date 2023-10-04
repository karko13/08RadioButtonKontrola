using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08RadioButtonKontrolaIvanoKarkovic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AvionRadio_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Rezerviraj_Click(object sender, EventArgs e)
        {
            kutija.Clear();

            if (AvionRadio.Checked)
            {
                kutija.AppendText("Odabrali ste prijevoz avionom. ");
            }
            if (BusRadio.Checked)
            {
                kutija.AppendText("Odabrali ste prijevoz busom. ");
            }
            if (VlastitoVozilo.Checked)
            {
                kutija.AppendText("Odabrali ste prijevoz vlastitim vozilom. ");
            }
        }
    }
}