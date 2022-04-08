using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5
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
            Random r = new Random(); 
            int h = 50, red, green, blue; 
            for (int i = 1; i <= 10; i++)
            {
                int w = r.Next() % 20 + 10; 
                red = r.Next() % 64;
                green = r.Next() % 128; blue = r.Next() % 32;
                Pen p = new Pen(Color.FromArgb(red, green, blue), w); 
                g.DrawLine(p, 100, h, 400, h); h = h + w / 2;
            }
        }
    }
}
