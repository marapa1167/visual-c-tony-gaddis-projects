using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip__Tax_and_Total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const decimal TIP = 0.15m;
        const decimal SALES_TAX = 0.07m;
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            decimal inputAmount, tip, salesTax, total;

            inputAmount = decimal.Parse(InputTextBox.Text);

            tip = inputAmount * TIP;
            TipTextBox.Text = tip.ToString("c");

            salesTax = inputAmount * SALES_TAX;
            SalesTaxTextBox.Text = salesTax.ToString("c");

            total = inputAmount + tip + salesTax;
            TotalTextBox.Text = Math.Round(total, 2).ToString("c");
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = "";
            TipTextBox.Text = "";
            SalesTaxTextBox.Text = "";
            TotalTextBox.Text = "";
            InputTextBox.Focus();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
