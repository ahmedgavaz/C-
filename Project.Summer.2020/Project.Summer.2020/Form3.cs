using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Summer._2020
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            this.Hide();
            secondForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fourForm = new Form4();
            this.Hide();
            fourForm.Show();
        }
    }
}
