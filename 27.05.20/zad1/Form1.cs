using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue, 3);
            int i, x = 10, y = 10, a = 200, b = 150;
            for (i=1; i<=5; i++)
            { g.DrawRectangle(p, x, y, a, b);
                x = x + 5;y = y + 5;
                a = a - 10;b = b - 10;
            }
        }
    }
}
