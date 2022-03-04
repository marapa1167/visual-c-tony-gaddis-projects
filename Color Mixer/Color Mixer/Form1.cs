using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            if ((RedRadioButtonFirst.Checked) && (redRadioButtonSecond.Checked))
            {
                this.BackColor = Color.Red;
            }
            else if ((RedRadioButtonFirst.Checked) && (blueRadioButtonSecond.Checked))
            {
                this.BackColor = Color.Purple;
            }
            else if ((RedRadioButtonFirst.Checked) && (yellowRadioButtonSecond.Checked))
            {
                this.BackColor = Color.Orange;
            }
            else if ((BlueRadioButtonFirst.Checked) && (redRadioButtonSecond.Checked))
            {
                this.BackColor = Color.Purple;
            }
            else if ((BlueRadioButtonFirst.Checked) && (blueRadioButtonSecond.Checked))
            {
                this.BackColor = Color.Blue;
            }
            else if ((BlueRadioButtonFirst.Checked) && (yellowRadioButtonSecond.Checked))
            {
                this.BackColor = Color.Green;
            }
            else if ((yellowRadioButtonFirst.Checked) && (redRadioButtonSecond.Checked))
            {
                this.BackColor = Color.Orange;
            }
            else if ((yellowRadioButtonFirst.Checked) && (blueRadioButtonSecond.Checked))
            {
                this.BackColor = Color.Green;
            }
            else if ((yellowRadioButtonFirst.Checked) && (yellowRadioButtonSecond.Checked))
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("You must select two colors");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
