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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 2;int p=1;
            int n = int.Parse(textBox1.Text); 
            while (i<=n)
            {
                p = p * i;
                i = i + 2;     }
            label1.Text = p.ToString();
        }
    }
}
