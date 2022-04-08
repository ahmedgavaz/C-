using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics; Pen pen = new Pen(Color.Blue, 2);
            int n, m, x1, y1, side,x,y;
            n = 1; m = 30; x1 = 100; y1 = 100; side = 200;
            int x2 = x1 + side, y2 = y1 + side; 
            g.DrawLine(pen, x1, y1, x1, y2);
            g.DrawLine(pen, x1, y1, x2, y1);
            g.DrawLine(pen, x2, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x1, y2);
            for (int i = 1; i <= 80; i++)
            {
                x = x1; y = y1; 
                x1 = (n * x1 + m *x2) / (n + m);
                y1 = (n * y1 + m *y2) / (n + m);
                x2 = (n * x2 + m *x) / (n + m);
                y2 = (n * y2 + m *y) / (n + m);
                g.DrawLine(pen, x1, y1, x1, y2);
                g.DrawLine(pen, x1, y1, x2, y1);
                g.DrawLine(pen, x2, y1, x2, y2);
                g.DrawLine(pen, x2, y2, x1, y2);
            }
        }
    }
}

