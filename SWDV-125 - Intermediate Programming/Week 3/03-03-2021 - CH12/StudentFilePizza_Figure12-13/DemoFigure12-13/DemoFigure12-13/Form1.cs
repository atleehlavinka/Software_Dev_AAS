using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFigure12_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const double BASE_PRICE = 12.00;
        private const double TOPPING_PRICE = 1.25;
        private double price = BASE_PRICE;

        private void checkBoxSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSausage.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;
            outputLabel.Text = "Total is " + price.ToString("C");
        }
    }
}
