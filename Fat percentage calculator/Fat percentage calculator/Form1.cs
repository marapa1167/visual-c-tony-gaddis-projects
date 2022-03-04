using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fat_percentage_calculator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double totalCalories, fatGrams, percentageFromFat, calFromFat;

            if (double.TryParse(textBoxCalories.Text, out totalCalories))
            {
                if (double.TryParse(textBoxFat.Text, out fatGrams))
                {
                    if ((totalCalories >= 0) && (fatGrams >= 0))
                    {
                        calFromFat = fatGrams * 9;
                        percentageFromFat = calFromFat / totalCalories * 100;

                        if ((calFromFat < totalCalories))
                        {
                            labelCalories.Text = calFromFat.ToString();
                            labelPercent.Text = percentageFromFat.ToString() + " %";

                            if (checkBox1.Checked)
                            {
                                if (calFromFat <= 30)
                                {
                                    labelInfo.Text = "The food is considered low fat";
                                }
                                else 
                                {
                                    labelInfo.Text = "The food is considered high fat";
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong input for fat grams. Try again");
                            textBoxCalories.Text = String.Empty;
                            textBoxFat.Text = String.Empty;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Calories and fat grams must be greater or equal to 0. Try again");
                        textBoxCalories.Text = String.Empty;
                        textBoxFat.Text = String.Empty;
                    }

                }
                else
                {
                    MessageBox.Show("Wrong input for fat grams. Try again");
                    textBoxCalories.Text = String.Empty;
                    textBoxFat.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Wrong input for calories. Try again");
                textBoxCalories.Text = String.Empty;
                textBoxFat.Text = String.Empty;
            }
        }
    

        private void buttonClr_Click(object sender, EventArgs e)
        {
            textBoxCalories.Text = String.Empty;
            textBoxFat.Text = String.Empty;
            labelCalories.Text = String.Empty;
            labelPercent.Text = String.Empty;
            labelInfo.Text = String.Empty;
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            string text = "Are you sure ypou want to exit?";
            string title = "Exit";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(text, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                textBoxCalories.Text = String.Empty;
                textBoxFat.Text = String.Empty;
                labelCalories.Text = String.Empty;
                labelPercent.Text = String.Empty;
            }
        }
    }
       
    }
     










































































    