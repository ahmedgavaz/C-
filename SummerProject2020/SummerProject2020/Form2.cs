using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummerProject2020
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox1.Text);
            this.Hide();
            Form3 thirdForm = new Form3();
            thirdForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 firstForm = new Form1();
            firstForm.Show();
        }
    }
}
