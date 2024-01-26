using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Assessment_Part_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Remove selected item from the ListBox
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add item to the ListBox from TextBox
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear all items from the ListBox
            listBox1.Items.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Change selected item in the ListBox with TextBox value
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
                textBox1.Clear();
            }
        }
    }
}
