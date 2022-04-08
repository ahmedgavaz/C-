using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3
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
            Brush w = new SolidBrush(Color.CadetBlue);
            Brush r = new SolidBrush(Color.DarkKhaki);
            Brush r1 = new SolidBrush(Color.Khaki);
            Brush r2 = new SolidBrush(Color.Green);
            Pen r3 = new Pen(Color.Red,3);
            Brush r4 = new SolidBrush(Color.DarkRed);
            Brush r5 = new SolidBrush(Color.Black) ;
            Brush r6 = new SolidBrush(Color.DarkGreen);
            Brush r7 = new SolidBrush(Color.Red);
            Brush r8 = new SolidBrush(Color.Purple);
            Brush r9 = new SolidBrush(Color.BlueViolet);
            Brush r10 = new SolidBrush(Color.DeepPink);
            Brush r11 = new SolidBrush(Color.Aquamarine);
            int x = 20, y = 20, a = 60, b = 60;
            Point m = new Point ( 290, 225);
            Point m1 = new Point(100, 225);
            Point m2 = new Point(195, 140);
            Point[] curvePoints = { m,m1,m2 };
            g.Clear(Color.SkyBlue);
            g.FillEllipse(w, x+100, y+15, a+30, b-30);
            g.FillEllipse(w, x + 20, y + 45, a + 30, b - 30);
            g.FillEllipse(w, x + 300, y + 46, a + 30, b - 30);
            g.FillEllipse(w, x + 40, y + 145, a + 30, b - 30);
            g.FillEllipse(w, x + 264, y + 115, a + 30, b - 30);
            g.FillEllipse(w, x + 450, y + 105, a + 30, b - 30);
            g.FillEllipse(q, x, y, a, b);
            g.FillPolygon(r, curvePoints);
            g.FillRectangle(r1, 140, 225,120,120);
            g.FillRectangle(r2, 0, 345, 990, 990);
            g.FillRectangle(r, 145, 145, 22, 45);
            g.DrawRectangle(r3, 160, 245, 30, 30);
            g.DrawRectangle(r3, 210, 245, 30, 30);
            g.DrawLine(r3, 175, 245, 175, 275);
            g.DrawLine(r3, 225, 245, 225, 275);
            g.DrawLine(r3, 160, 260, 190, 260);
            g.DrawLine(r3, 210, 260, 240, 260);
            g.FillRectangle(r4, 180, 305, 30, 40);
            g.FillEllipse(r5, 185, 325, 6, 6);
            g.FillRectangle(r4, 430, 245, 40, 100);
            g.FillEllipse(r6, 397, 155, 100, 100);
            g.FillEllipse(r7, 411, 172, 13, 13);
            g.FillEllipse(r7, 449, 157, 13, 13);
            g.FillEllipse(r7, 480, 197, 13, 13);
            g.FillEllipse(r7, 420, 217, 13, 13);
            g.FillEllipse(r7, 460, 217, 13, 13);
            g.FillEllipse(r7, 437, 196, 13, 13);
            g.FillEllipse(q, 34, 353, 13, 13);
            g.FillEllipse(r7, 134, 363, 13, 13);
            g.FillEllipse(r8, 94, 371, 13, 13);
            g.FillEllipse(r8, 164, 353, 13, 13);
            g.FillEllipse(r9, 234, 363, 13, 13);
            g.FillEllipse(r9,284, 363, 13, 13);
            g.FillEllipse(r10, 414, 363, 13, 13);
            g.FillEllipse(r9, 314, 363, 13, 13);
            g.FillEllipse(r11, 484, 363, 13, 13);
        }
    }
}
