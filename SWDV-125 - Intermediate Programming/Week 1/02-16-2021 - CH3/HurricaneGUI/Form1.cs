using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HurricaneGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int cat5 = 157;
            const int cat4 = 130;
            const int cat3 = 111;
            const int cat2 = 96;
            const int cat1 = 74;

            int num1;
            num1 = Convert.ToInt32(textBox1.Text);

            if (num1 >= cat5)
                label1.Text = "This is category 5 hurricane";
            else 
            if (num1 >= cat4)
                label1.Text = "This is category 4 hurricane";
            else
            if (num1 >= cat3)
                label1.Text = "This is category 3 hurricane";
            else
            if (num1 >= cat2)
                label1.Text = "This is category 2 hurricane";
            else
            if (num1 >= cat1)
                label1.Text = "This is category 1 hurricane";
            else
                label1.Text = "This is not a hurricane";

        }
    }
}
