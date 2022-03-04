using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_for_a_dollar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chceckButton_Click(object sender, EventArgs e)
        {
                double output, penny, nickle, dime, quarter;
                const double PENNY = 0.01;
                const double NICKLE = 0.05;
                const double DIME = 0.10;
                const double QUARTER = 0.25;

            penny = double.Parse(pennytextBox.Text);
            nickle = double.Parse(nickletextBox.Text);
            dime = double.Parse(dimetextBox.Text);
            quarter = double.Parse(quartertextBox.Text);

            output = penny * PENNY + nickle * NICKLE + dime * DIME + quarter * QUARTER;
            totalLabel.Text = output.ToString();
            
            if (output ==1)
            {
                MessageBox.Show("Congratulations! You won the game");
            }
            else
            {
                MessageBox.Show("Sorry, try again");
            }



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pennytextBox.Text = String.Empty;
            nickletextBox.Text = String.Empty;
            dimetextBox.Text = String.Empty;
            quartertextBox.Text = String.Empty;
            totalLabel.Text = String.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string text = "Are you sure you want to exit?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(text, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                pennytextBox.Text = String.Empty;
                nickletextBox.Text = String.Empty;
                dimetextBox.Text = String.Empty;
                quartertextBox.Text = String.Empty;
                totalLabel.Text = String.Empty;
            }

        }
    }
}
