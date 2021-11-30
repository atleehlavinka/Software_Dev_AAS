using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoOrderReceipt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double SALESTAX = .07;
            const double PRICE = 39.95;
            int numOrdered;
            double price, tax, amtDue;
            numOrdered = Convert.ToInt32(numBlendersTextBox.Text);
            price = PRICE * numOrdered;
            tax = price * SALESTAX;
            amtDue = price + tax;

            outputLabel.Text = "Receipt for: \n" + nameTextBox.Text +
            "\n" + addTextBox.Text +
            "\n" + cityTextBox.Text + ", " + stateTextBox.Text + " " + zipTextBox.Text +
            "\n" + numOrdered + " blenders ordered @ " + PRICE.ToString("c") + " each" +
            "\n" + "Total: " + price.ToString("c") +
            "\n" + "Tax: " + tax.ToString("c") +
            "\n" + "------------" +
            "\n" + "Due: " + amtDue.ToString("c");
        }
    } 

}
