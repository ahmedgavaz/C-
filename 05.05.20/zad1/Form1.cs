using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
            private void Form1_Load(object sender, System.EventArgs e)

            {
                listBox1.Items.Add("One");

                listBox1.Items.Add("Two");

                listBox1.Items.Add("Three");
            }
            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                string Element = listBox1.SelectedItem.ToString();

                if (Element == "Two")

                {
                    MessageBox.Show(Element);

                }
            }
        } 
    } 
