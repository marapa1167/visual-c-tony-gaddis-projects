using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double input, output;
            string selectedItemFrom, selectedItemTo;

            if (double.TryParse(distanceTextBox.Text, out input))
            {
                if (fromListBox.SelectedIndex != -1)
                {
                    if (toListBox.SelectedIndex != -1)
                    {
                        selectedItemFrom = fromListBox.SelectedItem.ToString();
                        selectedItemTo = toListBox.SelectedItem.ToString();
                    }
                    if ((fromListBox.SelectedIndex == 0) && (toListBox.SelectedIndex == 0))
                    {
                        output = input;
                        convertedDistanceLbl.Text = output.ToString();
                    }
                    else if ((fromListBox.SelectedIndex == 0) && (toListBox.SelectedIndex == 1))
                    {
                        output = input / 12;
                        convertedDistanceLbl.Text = output.ToString();
                    }
                    else if ((fromListBox.SelectedIndex == 0) && (toListBox.SelectedIndex == 2))
                    {
                        output = input / 36;
                        convertedDistanceLbl.Text = output.ToString();
                    }
                    else if ((fromListBox.SelectedIndex == 1) && (toListBox.SelectedIndex == 0))
                    {
                        output = input * 12;
                        convertedDistanceLbl.Text = output.ToString();
                    }
                    else if ((fromListBox.SelectedIndex == 1) && (toListBox.SelectedIndex == 1))
                    {
                        output = input;
                        convertedDistanceLbl.Text = output.ToString();
                    }
                    else if ((fromListBox.SelectedIndex == 1) && (toListBox.SelectedIndex == 2))
                    {
                        output = input / 3;
                        convertedDistanceLbl.Text = output.ToString();
                    }
                    else if ((fromListBox.SelectedIndex == 2) && (toListBox.SelectedIndex == 0))
                    {
                        output = input * 36;
                        convertedDistanceLbl.Text = output.ToString();
                    }
                    else if ((fromListBox.SelectedIndex == 2) && (toListBox.SelectedIndex == 1))
                    {
                        output = input * 3;
                        convertedDistanceLbl.Text = output.ToString();
                    }
                    else if ((fromListBox.SelectedIndex == 2) && (toListBox.SelectedIndex == 2))
                    {
                        output = input;
                        convertedDistanceLbl.Text = output.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Select second item");
                    }
                }
                else
                {
                MessageBox.Show("Select the first item");
                }
            }
            else
            {
                MessageBox.Show("Enter the disctance you want to convert");
            }
        }



            private void exitButton_Click(object sender, EventArgs e)
            {
                string text = "Are you sure you want to exit?";
                string title = "Exit";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(text, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                fromListBox.SelectedIndex = -1;
                toListBox.SelectedIndex = -1;
                distanceTextBox.Text = String.Empty;
                convertedDistanceLbl.Text = String.Empty;
                }
            }
        }
    }

