using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Radio_Station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int NO_COMM_FEE = 10;
        private const int LIMIT_COMM_FEE = 5;
        private const int WITH_COMM_FEE = 0;
        private const int GENRE_FEE = 2;
        //private int price = 0;
        private int total;


        private void noComm_CheckedChanged(object sender, EventArgs e)
        {
            if (noComm.Checked)
                total += NO_COMM_FEE;
            else
                total -= NO_COMM_FEE;
            outputLabel.Text = "Total " + total.ToString("C");

            
        }
        private void limitComm_CheckedChanged(object sender, EventArgs e)
        {
            if (limitComm.Checked)
                total += LIMIT_COMM_FEE;
            else
                total -= LIMIT_COMM_FEE;
            outputLabel.Text = "Total " + total.ToString("C");
        }

        private void withComm_CheckedChanged(object sender, EventArgs e)
        {
            if (withComm.Checked)
                total += WITH_COMM_FEE;
            else
                total -= WITH_COMM_FEE;
            outputLabel.Text = "Total " + total.ToString("C");
        }


        private void classical_CheckedChanged(object sender, EventArgs e)
        {
            if (classical.Checked)
                total += GENRE_FEE;
            else
                total -= GENRE_FEE;
            outputLabel.Text = "Total " + total.ToString("C");
        }

        private void country_CheckedChanged(object sender, EventArgs e)
        {
            if (country.Checked)
                total += GENRE_FEE;
            else
                total -= GENRE_FEE;
            outputLabel.Text = "Total " + total.ToString("C");
        }

        private void jazz_CheckedChanged(object sender, EventArgs e)
        {
            if (jazz.Checked)
                total += GENRE_FEE;
            else
                total -= GENRE_FEE;
            outputLabel.Text = "Total " + total.ToString("C");
        }

        private void rock_CheckedChanged(object sender, EventArgs e)
        {
            if (rock.Checked)
                total += GENRE_FEE;
            else
                total -= GENRE_FEE;
            outputLabel.Text = "Total " + total.ToString("C");
        }
    }
}
