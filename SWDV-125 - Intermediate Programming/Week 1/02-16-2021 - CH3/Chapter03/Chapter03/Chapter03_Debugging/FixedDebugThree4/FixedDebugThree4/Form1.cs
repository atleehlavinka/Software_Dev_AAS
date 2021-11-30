using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            birth = birthyear;
            year = current;
            age = year - birth;
            outputLabel.Text = String.Format("On your birthday this year, \nyou were or will be " +
                "years old", age);
        }
    }
}
