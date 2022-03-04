using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double originalPrice, discountPercentage, salePrice, discountAmount;

            originalPrice = double.Parse(OriginalPriceTextBox.Text);
            discountPercentage = double.Parse(DiscountPercentageTextBox.Text);
            discountAmount = discountPercentage / 100;
            salePrice = originalPrice - (originalPrice * discountAmount);
            SalePriceLabel.Text = salePrice.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
