using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6.Lab1
{
    public partial class Form1 : Form
    {
        string[] trainees = { "Ahmed", "Ali", "Mahmoud", "Moataz", "Nawal", "Amany", "Medhat", "Badr", "Karim" };


        public Form1()
        {
            InitializeComponent();
            LoadTrainees();
        }

        private void LoadTrainees()
        {
            TraineeCheckedListBox.Items.AddRange(trainees);
        }

    
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage1)
            {
                foreach (string item in TraineeCheckedListBox.CheckedItems.OfType<string>().ToArray())
                {
                    checkedListBox1.Items.Add(item);
                    TraineeCheckedListBox.Items.Remove(item);
                }

            }
            else
            {
                foreach (string item in TraineeCheckedListBox.CheckedItems.OfType<string>().ToArray())
                {
                    checkedListBox2.Items.Add(item);
                    TraineeCheckedListBox.Items.Remove(item);
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage1)
            {
                foreach (string item in TraineeCheckedListBox.Items.OfType<string>().ToArray())
                {
                    checkedListBox1.Items.Add(item);
                    TraineeCheckedListBox.Items.Remove(item);
                }
            }else
            {
                foreach (string item in TraineeCheckedListBox.Items.OfType<string>().ToArray())
                {
                    checkedListBox2.Items.Add(item);
                    TraineeCheckedListBox.Items.Remove(item);
                }
            }
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage1)
            {
                foreach (string item in checkedListBox1.CheckedItems.OfType<string>().ToArray())
                {
                    TraineeCheckedListBox.Items.Add(item);
                    checkedListBox1.Items.Remove(item);
                }
            } else
            {
                foreach (string item in checkedListBox2.CheckedItems.OfType<string>().ToArray())
                {
                    TraineeCheckedListBox.Items.Add(item);
                    checkedListBox2.Items.Remove(item);
                }
            }
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage1)
            {
                foreach (string item in checkedListBox1.Items.OfType<string>().ToArray())
                {
                    TraineeCheckedListBox.Items.Add(item);
                    checkedListBox1.Items.Remove(item);
                }
            }
            else
            {
                foreach (string item in checkedListBox2.Items.OfType<string>().ToArray())
                {
                    TraineeCheckedListBox.Items.Add(item);
                    checkedListBox2.Items.Remove(item);
                }


            }


        }

       
    }
}
