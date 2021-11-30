using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animated
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_MouseEnter( object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(@"\\Remote-School\G\School\SWDV-125\Week 4\03-08-2021 - CH13\Animated\two.png");
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(@"\\Remote-School\G\School\SWDV-125\Week 4\03-08-2021 - CH13\Animated\one.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "LABEL1")
            {
                this.label1.Text = "EXERCISE 4, PAGE 641";
            }
            else
                this.label1.Text = "LABEL1";
        }
    }
}
