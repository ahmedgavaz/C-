using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            if (a > b && a > c)
            {
                label4.Text = a.ToString();
                if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2)) label5.Text = "Ne";
                else label5.Text = "Da";
            }
            else if (b > a && b > c)
            {
                label4.Text = b.ToString();
                if (Math.Pow(b, 2) > Math.Pow(a, 2) + Math.Pow(c, 2)) label5.Text = "NE";
                else label5.Text = "Da";
            }
            else if (c > b && c > a)
            {
                label4.Text = c.ToString();
                if (Math.Pow(c, 2) > Math.Pow(b, 2) + Math.Pow(a, 2)) label5.Text = "NE";
                else label5.Text = "Da";
            }



            }
    }
}
