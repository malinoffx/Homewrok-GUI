using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickButton
{
    public partial class Form1 : Form
    {
        int click = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void TouchMe_Click(object sender, EventArgs e)
        {
            click++;
            Label.Text = "" + click;
            if (click == 5)
            {
                BackColor = Color.Blue;
            }
            else if (click == 10)
            {
                BackColor = Color.DarkRed;
            }
            else if (click == 15)
            {
                BackColor = Color.MediumPurple;
            }
        }

        private void TouchforReset_Click(object sender, EventArgs e)
        {
            click = 0;
            Label.Text = "" + click;
            BackColor = SystemColors.Control;
        }
    }
}
