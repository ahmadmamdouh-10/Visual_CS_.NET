using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day7.Lab3
{
    public partial class Form1 : Form
    {
        private Point MouseDownLocatation;
      

        public Form1()
        {
            InitializeComponent();
        }

        Rectangle rec = new Rectangle(0, 0, 0, 0);

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Aquamarine, rec);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                rec = new Rectangle(e.X, e.Y, 0, 0);
                Invalidate();
            }
            if(e.Button == MouseButtons.Right)
            {
                MouseDownLocatation = e.Location;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rec.Width = e.X - rec.X;
                rec.Height = e.Y - rec.Y;
                this.Invalidate();
            }

            if (e.Button == MouseButtons.Right)
            {
                rec.Location = new Point((e.X - MouseDownLocatation.X) + rec.Left, (e.Y - MouseDownLocatation.Y) + rec.Top);
                MouseDownLocatation = e.Location;
                this.Invalidate();
            }
        }




    }
}
