using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double fedWithTax = 0.15;
            const double stateWithTax = 0.05;

            double grossPay;
            double netPay;
            double fedWith;
            double stateWith;

            string enteredName;
            string enteredSSN;
            double enteredWage;
            int enteredHours;

            enteredName = textBox1.Text;
            enteredSSN = textBox2.Text;
            enteredWage = Convert.ToDouble(textBox3.Text);
            enteredHours = Convert.ToInt32(textBox4.Text);

            grossPay = enteredWage * enteredHours;
            fedWith = grossPay * fedWithTax;
            stateWith = grossPay * stateWithTax;
            netPay = ((grossPay - fedWith) - stateWith);

            label5.Text = "Payroll Summary for: " + enteredName + " SSN: " + enteredSSN +
            "\nYou worked " + enteredHours + " hours at " + enteredWage.ToString("C") + " per hour";

            label6.Text = "Gross pay: " + grossPay.ToString("C");

            label7.Text = "Federal withholding: " + fedWith.ToString("C") +
            "\nState withholding: " + stateWith.ToString("C") +
            "\n----------------------------" +
            "\nNet pay: " + netPay.ToString("C");

        }
    }
}
