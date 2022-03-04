using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_and_Fahrenhite_Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double input, celsius, fahrenheit;

        private void buttonFahrenheit_Click(object sender, EventArgs e)
        {
            input = double.Parse(textBoxInput.Text);
            fahrenheit = (input * 9 / 5) + 32;
            textBoxOutput.Text = fahrenheit.ToString();
        }

        private void buttonCelsius_Click(object sender, EventArgs e)
        {
            input = double.Parse(textBoxInput.Text);
            celsius = (input - 32) * 5 / 9;
            textBoxOutput.Text = celsius.ToString();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
            textBoxInput.Focus();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
