using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poligon1
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
            Pen p = new Pen(Color.Yellow, 2);
            Brush q = new SolidBrush(Color.Yellow);
            Point[] point = { new Point(100, 100), new Point(200, 200), new Point(180, 300), new Point(120, 250) };
            g.DrawPolygon(p, point);
            g.FillPolygon(q,point);
        }
    }
}
