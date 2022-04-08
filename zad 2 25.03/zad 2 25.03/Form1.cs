using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_2_25._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint a, b,c;
            a = uint.Parse(textBox1.Text);
            b = uint.Parse(textBox2.Text);

            if (b == Math.Max(a, b)) label1.Text = "Error";
            else
            {
                c = a / b;
                label1.Text = c.ToString();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
