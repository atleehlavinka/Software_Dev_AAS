using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSelector
{
    public partial class Form1 : Form
    {
        string[] times = {"7:05", "7:45", "8:15", "8:40"};
        Color[] color = { Color.Red, Color.PowderBlue, Color.Orange, Color.Yellow };

        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //page 569
            for (int x = 0; x < listBoxMovies.Items.Count; ++x)
                if (listBoxMovies.GetSelected(x))
                {
                    outputMovieTime.Text = "Starting time is " + times[x];
                    BackColor = color[x];
                }
        }
        //page 622 and 626
        private void listBoxMovies_MouseEnter(object sender, EventArgs e)
        {
            string timesString = "\n";
            for (int x = 0; x < times.Length; ++x)
                timesString += times[x] + "\n";
            outputAllTimes.Text = "Times are " + timesString;
        }

        private void listBoxMovies_MouseLeave(object sender, EventArgs e)
        {
            outputAllTimes.Text = "";
        }
    }
}
