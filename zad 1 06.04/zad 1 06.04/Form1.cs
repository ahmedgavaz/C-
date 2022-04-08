using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_1_06._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int students = int.Parse(textBox1.Text); 
            double excellentStudents = double.Parse(textBox2.Text); 
            double percent = excellentStudents / students * 100;
            //percent = Math.Round(percent, 2); 
            label3.Text = String.Format("Процентът на  отличниците е  {0:#.##} %", percent);
        }
    }
}
