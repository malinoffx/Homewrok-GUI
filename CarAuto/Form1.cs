using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarAuto
{
    public partial class Form1 : Form
    {
        int money = 0;
        int extras = 0;
        int discount1 = 0;
        int discount2 = 0;
        int discount = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Mustang_CheckedChanged(object sender, EventArgs e)
        {
            money = 67500;
            Pic.Image = CarAuto.Properties.Resources.car1;
            Cena.Text = "Money: " + money + " leva";
        }

        private void Dodge_CheckedChanged(object sender, EventArgs e)
        {
            money = 93700;
            Pic.Image = CarAuto.Properties.Resources.car2;
            Cena.Text = "Money: " + money + " leva";
        }

        private void Cheve_CheckedChanged(object sender, EventArgs e)
        {
            money = 78900;
            Pic.Image = CarAuto.Properties.Resources.car3;
            Cena.Text = "Money: " + money + " leva";
        }

        private void Cena_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Abs_CheckedChanged(object sender, EventArgs e)
        {
            if (Abs.Checked)
            {
                extras += 300;
                Extri.Text = "Money: " + extras + " leva";
                
            }
            else
            {
                extras -= 300;
                Extri.Text = "Money: " + extras + " leva";
            }

            if (Abs.Checked && Fog.Checked && Chains.Checked)
            {
                discount1 = 10;
                Discount.Text = "Discount%: " + discount2;
            }
            else
            {
                discount1 = 0;
                Discount.Text = "Discount%: " + discount2;
            }
            
        }

        private void Fog_CheckedChanged(object sender, EventArgs e)
        {
            if (Fog.Checked)
            {
                extras += 250;
                Extri.Text = "Money: " + extras + " leva";
            }
            else
            {
                extras -= 250;
                Extri.Text = "Money: " + extras + " leva";
            }
            if (Abs.Checked && Fog.Checked && Chains.Checked)
            {
                discount1 = 10;
                Discount.Text = "Discount%: " + discount2;

            }
            else
            {
                discount1 = 0;
                Discount.Text = "Discount%: " + discount2;
            }

        }

        private void Chains_CheckedChanged(object sender, EventArgs e)
        {
            if (Chains.Checked)
            {
                extras += 100;
                Extri.Text = "Money: " + extras + " leva";
            }
            else
            {
                extras -= 100;
                Extri.Text = "Money: " + extras + " leva";
            }
            if (Abs.Checked && Fog.Checked && Chains.Checked)
            {
                discount1 = 10;
                Discount.Text = "Discount%: " + discount1;
            }
            else
            {
                discount1 = 0;
                Discount.Text = "Discount%: " + discount1;
            }

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            discount = discount1 + discount2;
            Obsht.Text = "Money without discount: " + (money + extras) + " leva";
            Total.Text = "Total Money: " + ((money + extras) - (money + extras) * discount / 100) + " leva";
            Discount.Text = "Discount%: " + discount;
            
        }

        private void Cash_CheckedChanged(object sender, EventArgs e)
        {
            if (Cash.Checked)
            {
                discount2 = 5;
                Discount.Text = "Discount%: " + discount2;
            }
            else
            {
                discount2 = 0;
                Discount.Text = "Discount%: " + discount2;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}






