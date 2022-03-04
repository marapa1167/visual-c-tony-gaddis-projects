using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += aBtn.Text;
        }
        private void anBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += anBtn.Text;
        }
        private void mBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += mBtn.Text;
        }
        private void woBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += woBtn.Text;
        }
        private void waBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += waBtn.Text;
        }
        private void cBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += cBtn.Text;
        }
        private void agBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += agBtn.Text;
        }
        private void wiBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += wiBtn.Text;
        }
        private void yBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += yBtn.Text;
        }
        private void awBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += awBtn.Text;
        }
        private void sBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += sBtn.Text;
        }
        private void oBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text += oBtn.Text;
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
