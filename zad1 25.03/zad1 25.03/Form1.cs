using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1_25._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { double a, b, c, y, x, ans, s, r, c1;
            r = double.Parse(textBox1.Text);
            a = double.Parse(textBox2.Text);
            b = double.Parse(textBox3.Text);
            c = double.Parse(textBox4.Text);
            y = double.Parse(textBox5.Text);
            s = Math.PI * r * r;
            c1 = 2 * Math.PI * r;
            ans = Math.Ceiling((a * b) / c);
            x = Math.Floor(y + 0.5);
            label1.Text = s.ToString();
            label2.Text = c1.ToString();
            label3.Text = ans.ToString();
            label4.Text = x.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
