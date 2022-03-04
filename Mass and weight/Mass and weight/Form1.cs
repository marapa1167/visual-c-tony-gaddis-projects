using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mass_and_weight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double mass, weight;
            if (double.TryParse (MassTextBox.Text, out mass))
            {
                weight = mass * 9.8;

                if (weight > 1000)
                {
                    WeightLabel.Text = "Object is too heavy";
                }
                else if (weight < 10)
                {
                    WeightLabel.Text = "Object is too light";
                }
                else
                {
                    WeightLabel.Text = weight.ToString();
                }
            }
            else
            {
                MessageBox.Show("Wrong input, try again", "Wrong input");
                MassTextBox.Clear();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MassTextBox.Clear();
            WeightLabel.Text = String.Empty;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MassTextBox.Clear();
                WeightLabel.Text = String.Empty;
            }

        }
    }
}
