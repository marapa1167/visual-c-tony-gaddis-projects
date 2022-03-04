using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int A_CLASS_SEAT = 15, B_CLASS_SEAT = 12, C_CLASS_SEAT = 9;
        private void calculateButton_Click(object sender, EventArgs e)
        {
             int revenueA = 0, revenueB = 0, revenueC = 0, total = 0;
            try
            {
                
                int classAseat = 0;
                int.TryParse(aClassTextBox.Text, out classAseat);

                int classBseat = 0;
                int.TryParse(bClassTextBox.Text, out classBseat);

                int classCseat = 0;
                int.TryParse(cClassTextBox.Text, out classCseat);

                revenueA = classAseat * A_CLASS_SEAT;
                revenueAclassLabel.Text = revenueA.ToString();

                revenueB = classBseat * B_CLASS_SEAT;
                revenueBclassLabel.Text = revenueB.ToString();

                revenueC = classCseat * C_CLASS_SEAT;
                revenueCclassLabel.Text = revenueC.ToString();

                total = revenueA + revenueB + revenueC;
                revenueTotalLabel.Text = total.ToString();

                clearButton.Focus();
            }
            catch
            {
                MessageBox.Show("Wrong input.TryAgain");
                inputGroupBox.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
                revenueAclassLabel.Text = "";
                revenueBclassLabel.Text = "";
                revenueCclassLabel.Text = "";
                revenueTotalLabel.Text = "";
           }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            inputGroupBox.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            revenueAclassLabel.Text = "";
            revenueBclassLabel.Text = "";
            revenueCclassLabel.Text = "";
            revenueTotalLabel.Text = "";
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
