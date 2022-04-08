using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6_01._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text; 
            int number = int.Parse(s); 
            int ed, des, sto, swap; 
            ed = number % 10;  //цифрата на единицитe
            des= (number / 10) % 10; //цифрата на десетиците
            sto = number / 100;   //цифрата на стотицитеint swap;   //размяна на цифрите
            swap = ed; ed = sto; sto = swap;int newNumber;newNumber = sto * 100 + des * 10 + ed; //новото число
            label2.Text   =   String.Format("Новото число е {0}", newNumber);

        }
    }
}
