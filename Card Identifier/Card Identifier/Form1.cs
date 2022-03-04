using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TwoOfSpadesPictureBox_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Two of Clubs";
        }

        private void KingOfDiamondsPictureBox_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "King of Diamonds";
        }

        private void JackOfSpadesPictureBox_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Jack of Spades";
        }

        private void AceOfHeatrsPictureBox_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Ace of Hearts";
        }

        private void JokerPictureBox_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Joker";
        }
    }
}
