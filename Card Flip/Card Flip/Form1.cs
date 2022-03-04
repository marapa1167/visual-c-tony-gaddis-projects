using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Flip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ShowBackButton_Click(object sender, EventArgs e)
        {
            CardFacePictureBox.Visible = false;
            CardBackPictureBox.Visible = true;
        }

        private void ShowFaceButton_Click(object sender, EventArgs e)
        {
            CardBackPictureBox.Visible = false;
            CardFacePictureBox.Visible = true;
        }

        private void CardBackPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press any button to see the card", "Press the button");
        }

        private void CardFacePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press any button to see the card", "Press the button");
        }
    }
}
 