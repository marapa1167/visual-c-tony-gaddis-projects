using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            const int MINUTE = 60;
            const int HOUR = 3600;
            const int DAY = 86400;
            int input, output;

            if (int.TryParse(inputTextBox.Text, out input)) ;
            {
                if ((input >= 60) && (input < 3600))
                {
                    output = input / MINUTE;
                    lbloutput.Text = output.ToString() + " minutes";
                }
                else if (((input >= 3600) && (input < 86400)))
                {
                    output = input / HOUR;
                    lbloutput.Text = output.ToString() + " hours";
                }
                else if (input >= 86400)
                {
                    output = input / DAY;
                    lbloutput.Text = output.ToString() + " days";
                }
                else
                {
                    MessageBox.Show("Wrong input, try again");
                    inputTextBox.Text = String.Empty;
                }
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = String.Empty;
            lbloutput.Text = String.Empty;
        }

        private void exitBtn_Click(object sender, EventArgs e)
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
                inputTextBox.Text = String.Empty;
            }
        }
    }
}
