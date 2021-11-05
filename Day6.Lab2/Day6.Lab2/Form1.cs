using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6.Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem viewItem = new ListViewItem(textBox1.Text);
            viewItem.SubItems.Add(textBox2.Text);
            viewItem.SubItems.Add(dateTimePicker1.Text);

            listView1.Items.Add(viewItem);
            clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text        = listView1.SelectedItems[0].Text;
                textBox2.Text        = listView1.SelectedItems[0].SubItems[1].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             listView1.SelectedItems[0].Text = textBox1.Text;
             listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
             listView1.SelectedItems[0].SubItems[2].Text = dateTimePicker1.Text;

             clear();
        }
    }
}
