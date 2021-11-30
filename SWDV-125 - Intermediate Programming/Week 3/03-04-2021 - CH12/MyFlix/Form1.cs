using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double PRICE = 1.99;
            double costShows;
            int count;
            count = listBox.SelectedItems.Count;
            costShows = count * PRICE;
            outputLabel.Text = count + " items were selected, you owe " + costShows.ToString("c");
        }
    }
}
