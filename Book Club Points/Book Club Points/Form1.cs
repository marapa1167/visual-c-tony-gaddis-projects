using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Club_Points
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int input;

            if (int.TryParse(inputTextBox.Text, out input))
            {
                if (input == 0)
                {
                    MessageBox.Show("Sorry, no bonus points!");
                }
                else if (input == 1)
                {
                    MessageBox.Show("You earned 5 bonus points!");
                }
                else if (input == 2)
                {
                    MessageBox.Show("You earned 15 bonus points!");
                }
                else if (input == 3)
                {
                    MessageBox.Show("You earned 30 bonus points!");
                }
                else if (input >= 4)
                {
                    MessageBox.Show("You earned 60 bonus points!");
                }
            }
            else
            {
                MessageBox.Show("Enter the number of books you have purchased!");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = String.Empty;
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
                inputTextBox.Text = String.Empty;
            }
            
        }
    }
}
