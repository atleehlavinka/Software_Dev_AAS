using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree1
{
    public partial class Debug01 : Form
    {
        public Debug01()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double product;
            num1 = Convert.ToDouble(textBox1);
            num2 = Convert.ToDouble(textBox2);
            product = num1 + num2;
            outputLabel = WriteLine("{0} times {1} is {2}", num1, num2, product);
        }
    }
}
