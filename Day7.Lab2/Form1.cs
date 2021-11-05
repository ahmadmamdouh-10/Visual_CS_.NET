using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day7.Lab2
{
    public partial class Form1 : Form
    {
        private int ballW = 100;
        private int ballH = 100;
        private int ballX = 0;
        private int ballY = 0;

        private int moveStepX = 5;
        private int moveStepY = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void PaintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(BackColor);
            e.Graphics.FillEllipse(Brushes.Blue,
                                   ballX, ballY, 
                                   ballW, ballH);
        }

        private void MoveBall(object sender, EventArgs e)
        {
            //update postion of the ball 
            
            ballX += moveStepX;
            if (ballX < 0 || ballX + ballW > this.ClientSize.Width)
            {
                moveStepX = -moveStepX;
            }
            ballY += moveStepY;
            if (ballY < 0 || ballY + ballH > this.ClientSize.Height)
            {
                moveStepY = -moveStepY;
            }
            //paint again 

            this.Refresh();
        }
    }
}
