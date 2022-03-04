using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonItalian_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Buongiorno";
        }

        private void buttonSpanish_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Buenos dias";
        }

        private void buttonGerman_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Guten Morgen";
        }
    }
}
