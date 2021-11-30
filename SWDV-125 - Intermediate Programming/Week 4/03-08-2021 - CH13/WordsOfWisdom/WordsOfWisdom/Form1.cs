using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWisdom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.White;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.Black;
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.label2.BackColor = Color.White;
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.label2.BackColor = Color.Black;
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.White;
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.Black;
        }
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.label4.BackColor = Color.White;
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.label4.BackColor = Color.Black;
        }
    }
}
