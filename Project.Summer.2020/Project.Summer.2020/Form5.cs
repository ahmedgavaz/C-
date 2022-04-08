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
    public partial class Form5 : Form
    {
        public Form5()
        {
            
            int x = 0;label2.Text = "";  
            Form2 secondForm = new Form2();
            Form3 thirdForm = new Form3();
            Form4 fourForm =  new Form4();
            if (fourForm.radioButton1.Checked) x = 0;
            if (fourForm.radioButton2.Checked) x = 1;
            if (fourForm.radioButton3.Checked) x = 2;
            if (fourForm.radioButton4.Checked) x = 3;
            // double a = double.Parse(secondForm.textBox1.Text);
            // double b = double.Parse(secondForm.textBox2.Text);
            bool isNum = Double.TryParse(Convert.ToString(secondForm.textBox1.Text), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out double retNum);
            bool isNum1 = Double.TryParse(Convert.ToString(secondForm.textBox2.Text), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out double retNum1);
            if ((retNum == 0) && (retNum1 == 0))
            {
                string s = secondForm.textBox1.Text;
                string s1 = secondForm.textBox2.Text;
                double a = double.Parse(s);
                double g = double.Parse(s1);
                double b = g;
                double c = 1;
                if ((thirdForm.radioButton1.Checked) && (x == 0)) { c = Math.Round(a + b, 0); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton1.Checked) && (x == 1)) { c = Math.Round(a + b, 1); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton1.Checked) && (x == 2)) { c = Math.Round(a + b, 2); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton1.Checked) && (x == 3)) { c = Math.Round(a + b, 3); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton2.Checked) && (x == 0)) { c = Math.Round(a - b, 0); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton2.Checked) && (x == 1)) { c = Math.Round(a - b, 1); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton2.Checked) && (x == 2)) { c = Math.Round(a - b, 2); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton2.Checked) && (x == 3)) { c = Math.Round(a - b, 3); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton3.Checked) && (x == 0)) { c = Math.Round(a * b, 0); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton3.Checked) && (x == 1)) { c = Math.Round(a * b, 1); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton3.Checked) && (x == 2)) { c = Math.Round(a * b, 2); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton3.Checked) && (x == 3)) { c = Math.Round(a * b, 3); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton4.Checked) && (x == 0)) { c = Math.Round(a / b, 0); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton4.Checked) && (x == 1)) { c = Math.Round(a / b, 1); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton4.Checked) && (x == 2)) { c = Math.Round(a / b, 2); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton4.Checked) && (x == 3)) { c = Math.Round(a / b, 3); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton5.Checked) && (x == 0)) { c = Math.Round(a % b, 0); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton5.Checked) && (x == 1)) { c = Math.Round(a % b, 1); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton5.Checked) && (x == 2)) { c = Math.Round(a % b, 2); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton5.Checked) && (x == 3)) { c = Math.Round(a % b, 3); label2.Text = c.ToString(); }
                if ((thirdForm.radioButton6.Checked) && (x == 0))
                {
                    while (a != b)
                    {
                        if (a > b) a = a - b; 
                    
                        if (b > a) b = b - a;
                    }
                    c = Math.Round(a, 0);
                    label2.Text = c.ToString();
                }
                if ((thirdForm.radioButton6.Checked) && (x == 1))
                {
                    while (a != b)
                    {
                        if (a > b) a = a - b;
                        if (b > a) b = b - a;
                    }
                    c = Math.Round(a, 1);
                    label2.Text = c.ToString();
                }
                if ((thirdForm.radioButton6.Checked) && (x == 2))
                {
                    while (a != b)
                    {
                        if (a > b) a = a - b;
                        if (b > a) b = b - a;
                    }
                    c = Math.Round(a, 2);
                    label2.Text = c.ToString();
                }
                if ((thirdForm.radioButton6.Checked) && (x == 3))
                {
                    while (a != b)
                    {
                        if (a > b) a = a - b;
                        if (b > a) b = b - a;
                    }
                    c = Math.Round(a, 3);
                    label2.Text = c.ToString();
                }

            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fourForm = new Form4();
            fourForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 sixForm = new Form6();
            sixForm.Show();
        }

        
    }
}