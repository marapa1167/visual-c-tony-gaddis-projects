using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int BANANA_KCAL = 115, CHERRY_KCAL = 80, ORANGE_KCAL = 90, PEAR_KCAL = 120;
        int totalCalories = 0;

        private void pearPictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += PEAR_KCAL;
            outputLabel.Text = totalCalories.ToString();
        }
        private void orangePictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += ORANGE_KCAL;
            outputLabel.Text = totalCalories.ToString();
        }
        private void cherryPictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += CHERRY_KCAL;
            outputLabel.Text = totalCalories.ToString(); ;
        }
        private void bananaPictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += BANANA_KCAL;
            outputLabel.Text = totalCalories.ToString();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            totalCalories = 0;
            outputLabel.Text = totalCalories.ToString();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
