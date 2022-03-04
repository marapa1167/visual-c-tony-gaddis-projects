using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double weight, height, bmi;
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                weight = double.Parse(weightTextBox.Text);
                height = double.Parse(heightTextBox.Text);
                bmi = weight / Math.Pow((height/100), 2);
                bmiTextBox.Text = Math.Round(bmi,2).ToString();

                if (bmi < 18.5)
                {
                    bmiLabel.Text = "Underweight";
                }
                else if (bmi > 18.5 && bmi < 24.9)
                {
                    bmiLabel.Text = "Normal weight";
                }
                else if (bmi > 25.0 && bmi < 29.9)
                {
                    bmiLabel.Text = "Pre-obesity";
                }
                else if (bmi > 30 && bmi < 34.9)
                {
                    bmiLabel.Text = "Obesity class I";
                }
                else if (bmi > 35.0 && bmi < 39.9)
                {
                    bmiLabel.Text = "Obesity class II";
                }
                else
                {
                    bmiLabel.Text = "Obesity class III";
                }
            }
            catch 
            {
                MessageBox.Show("Wrong input. Try again", "Error");
                weightTextBox.Text = "";
                heightTextBox.Text = "";
                weightTextBox.Focus();
            }

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            weightTextBox.Text = "";
            heightTextBox.Text = "";
            bmiTextBox.Text = "";
            weightTextBox.Focus();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
