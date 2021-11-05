using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day7.Lab1
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen1;
        Pen pen2; 
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            pen1 = new Pen(Color.Black, 5);
            pen2 = new Pen(Color.White, 5); 
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            g.DrawLine(pen2, new Point(x, y), e.Location);
            x = -1;
            y = -1; 

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x!=-1 && y != -1)
            {
                if(e.Button == MouseButtons.Left)
                {
                    g.DrawLine(pen1, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                }
                else
                {
                    g.DrawLine(pen2, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                }

               
            }
        }
    }
}
