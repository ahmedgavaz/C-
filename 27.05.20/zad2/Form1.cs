using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        { base.OnPaint(e);
            Graphics g = e.Graphics;
            int red = 255, green = 0, blue = 0;
            int x = 20, y = 20, a = 250, b = 200;
            Pen p = new Pen(Color.FromArgb(red, green, blue), 3);
            while (a > 1)
            { g.DrawEllipse(p, x, y, a, b);
                x = x + 1; y = y + 1; a = a - 10; b = b - 10;
                red = red - 10; blue = blue + 10;green = green + 10;
                p.Color = Color.FromArgb(red, green, blue);
            }
        }
    }
}

