using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5.Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                double res = double.Parse(ValueBox.Text) / 1000;
                ResultBox.Text = res.ToString();
            }
            else if (radioButton2.Checked==true)
            {
                double res = double.Parse(ValueBox.Text) * 100;
                ResultBox.Text = res.ToString();
            }
            else if (radioButton3.Checked == true)
            {
                double res = double.Parse(ValueBox.Text) * 1000;
                ResultBox.Text = res.ToString();
            }

        }
    }
}
