using System;
using System.Windows.Forms;

namespace Demo_AddList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.One;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //page 568
            string[] optionInBox = { "One", "Two", "Three", "Four" };
            for (int x = 0; x < optionInBox.Length; ++x)
                listBox1.Items.Add(optionInBox[x]);
            listBox1.SetSelected(0, true);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(editTextBox.Text);
            editTextBox.Text = null;
            listBox1.SetSelected(listBox1.Items.Count - 1, true);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
                if (listBox1.Items.Count > 0)
                    listBox1.SetSelected(0, true);
                else
                    MessageBox.Show("No items are avaiable in the list");
            }
            else
                MessageBox.Show("The list is empty");

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
