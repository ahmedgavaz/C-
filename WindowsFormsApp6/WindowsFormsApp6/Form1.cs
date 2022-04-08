using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text; 
            int hours = int.Parse(s); 
            s = textBox2.Text; 
            int minutes = int.Parse(s);
            s = textBox3.Text;
            int x = int.Parse(s); 
            int allMinutes = hours * 60 + minutes + x;
            int newHours = allMinutes / 60; 
            int newMinutes = allMinutes % 60; 
            label4.Text = String.Format("Времето за кацане е {0}h {1}min", newHours, newMinutes);

        }
    }
}
