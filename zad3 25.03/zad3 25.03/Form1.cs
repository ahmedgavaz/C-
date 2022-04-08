using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3_25._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s,p,a;
            s = double.Parse(textBox1.Text);
            if (s<=0) label1.Text = "Error";
            else
            {
                a = Math.Sqrt(s);
                p = Math.Round(4 * a, 2);

                label1.Text = p.ToString();
            }
           
        }
    }
}
