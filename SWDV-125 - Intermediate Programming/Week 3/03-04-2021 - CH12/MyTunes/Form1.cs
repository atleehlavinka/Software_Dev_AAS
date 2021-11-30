using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTunes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //songsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            songsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            //songsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            //songsListBox.SelectionMode = System.Windows.Forms.SelectionMode.One;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            const double PRICE = .99;
            double costSongs;
            int count;
            count = songsListBox.SelectedItems.Count;
            costSongs = count * PRICE;
            outputLabel.Text = "Your selection will cost " + costSongs.ToString("c");
        }

        private void songsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            const double PRICE = .99;
                double costSongs;
            int count = 0;
            count = songsListBox.SelectedItems.Count;
            costSongs = count * PRICE;
            outputLabel.Text = "Your selection will cost " + costSongs.ToString("c");
        }
    }
}
