using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketButtonManager
{
    public partial class Form1 : Form
    {
        int cena = 0;
        int choweka;
        public Form1()
        {
            InitializeComponent();
        }

        private void Detski_CheckedChanged(object sender, EventArgs e)
        {
            cena = 3;
        }

        private void Uchenici_CheckedChanged(object sender, EventArgs e)
        {
            cena = 4;
        }

        private void Studenti_CheckedChanged(object sender, EventArgs e)
        {
            cena = 5;
        }

        private void Bileti_TextChanged(object sender, EventArgs e)
        {
            choweka = Convert.ToInt32(Bileti.Text);
        }

        private void Presmetni_Click(object sender, EventArgs e)
        {
            Label.Text = "" + choweka*cena +" leva.";
        }
    }
}
