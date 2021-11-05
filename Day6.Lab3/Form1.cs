using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6.Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text Files |*.txt|PNG Image|*.png|JPG Image|*.jpg";

            if (ofd.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);

            }

        }

        public void SetText(string txt)
        {
            textBox1.Text = txt;
        }

        public void SetFont(Font font)
        {
            textBox1.Font = font;
        }

        public void SetColor(Color color)
        {
            textBox1.ForeColor = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var form2 = new Form2(this, textBox1.Text))
            {
                form2.ShowDialog();
            }

          

        }
    }
}
