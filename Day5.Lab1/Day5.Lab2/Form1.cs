using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5.Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int error = 0;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            
            string name = textBox1.Text;
            string email = textBox2.Text;
            if (name.Length < 5)
            {
                label5.Visible = true;
                error = 1;
            }
            if (!email.Contains("@")){ 
                label6.Visible = true;
                error = 1;
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                label7.Visible = true;
                error = 1;
            }
            if (error ==0)
            {
                label8.Visible = true;
                
            }
        }
    }
}
