using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicBookSelector
{
    public partial class Form1 : Form
    {
        string[] synop = { "Catcher", "A WWII soldier endures a nightmare existence.", "War and Peace", "A Tale of Two Cities", "Four sisters share adventures" };
        Color[] color = { Color.Red, Color.PowderBlue, Color.Orange, Color.Blue, Color.Yellow };
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < listBox1.Items.Count; ++x)
                if (listBox1.GetSelected(x))
                {
                    label2.Text = "Synopsis: " + synop[x];
                    BackColor = color[x];
                }
        }
        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            this.label3.Text = "Quote: \"This is a quote.\" -Some Person";
        }
        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            this.label3.Text = "";
        }
    }
}
