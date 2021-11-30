using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void elite_CheckedChanged(object sender, EventArgs e)
        {
            if(elite.Checked)
            {
                Elite eliteform = new Elite();
                eliteform.ShowDialog();
                elite.Checked = false;
            }
        }

        private void cheetah_CheckedChanged(object sender, EventArgs e)
        {
            if (cheetah.Checked)
            {
                CheetahForm cheetahform = new CheetahForm();
                cheetahform.ShowDialog();
                cheetah.Checked = false;
            }
        }

        private void centsible_CheckedChanged(object sender, EventArgs e)
        {
            if (centsible.Checked)
            {
                CentsibleForm centsibleForm = new CentsibleForm();
                centsibleForm.ShowDialog();
                centsible.Checked = false;
            }
        }
    }
}
