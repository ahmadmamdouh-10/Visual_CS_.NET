using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day7.Lab4
{
    public partial class OnlyNumber : UserControl
    {
        public OnlyNumber()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label1, "Allow Numeric Values !");
                
            }
            else
            {
                errorProvider1.SetError(label1, "");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label2, "Allow only 14 Numeric Values !");


               
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[0-9]{1,14}$"))
                {
                    textBox2.Text = "";
                }
                errorProvider1.SetError(label2, "");

            }

        }
    }
}
