using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5_01._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s; 
            s = textBox1.Text; 
            int number; number = int.Parse(s); 
            int pr;
            pr = (number % 10) * (number / 10);
            label2.Text = String.Format("Произведението е {0}", pr);
        }
    }
}
