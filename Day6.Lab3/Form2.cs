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
    public partial class Form2 : Form
    {
        public string msg
        {
            get
            {
                return textBox1.Text;
            }
        }

        public System.Drawing.Font fontValue;
        public System.Drawing.Color colorValue;

        //public string fontName
        //{
        //    get
        //    {
        //        return comboBox1.SelectedItem.ToString();
        //    }

        //}

        //public decimal fontSize
        //{
        //    get
        //    {
        //        return numericUpDown1.Value;
        //    }
        //}

        //public string bold
        //{
        //    get
        //    {
        //        return checkBox1.Checked.ToString();
        //    }
        //}

        //public string italic
        //{
        //    get
        //    {
        //        return checkBox2.Checked.ToString();
        //    }
        //}

        private Form1 form1;
        public Form2(Form1 form1,string txt)
        {
            InitializeComponent();
            //loadItems();
            this.form1 = form1;
            textBox1.Text = txt;
        }

        //private void loadItems()
        //{
        //    comboBox1.Items.Clear();
        //    FontFamily[] allFonts = FontFamily.Families;

        //    foreach(FontFamily ff in allFonts)
        //    {
        //        comboBox1.Items.Add(ff.Name);
        //    }
        //}

        

        private void button1_Click(object sender, EventArgs e)
        {
            form1.SetText(textBox1.Text);
            form1.SetColor(colorValue);
            form1.SetFont(fontValue);

        }

     

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Red;

            colorValue = textBox1.ForeColor; 

    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Blue;
            colorValue = textBox1.ForeColor;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = cd.Color;
                colorValue = textBox1.ForeColor;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Font = fd.Font;
                fontValue = textBox1.Font;

            }
        }
    }
}
