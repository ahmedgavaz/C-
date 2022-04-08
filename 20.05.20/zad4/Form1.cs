using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            int side = 100, x1 = 0, y1 = 100, x2, y2, x3, y3;
            for (; x1 <= 800; x1 += 100)
            {
                x2 = x1 + side; y2 = y1;
                x3 = (x1 + x2) / 2;
                int h = (int)(side * Math.Sqrt(3) / 2);
                y3 = y1 - h;
                g.DrawLine(p, x1, y1, x2, y2);
                g.DrawLine(p, x2, y2, x3, y3);
                g.DrawLine(p, x3, y3, x1, y1);
            }
        }
    }
}
