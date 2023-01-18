using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conditions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Jake")
            {
                label1.Text = "Welcome!";
            }
            else
            {
                label1.Text = "Unauthorized User";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(textBox2.Text);
            if (num == 5)
            {
                label2.Text = "Correct Number";
            }
            else
            {
                label2.Text = "False Number";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num2 = Convert.ToInt16(textBox3.Text);
            if (num2 % 2 == 0)
            {
                label6.Text = "Even";
            }
            else
            {
                label6.Text = "Odd";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num3 = Convert.ToInt16(textBox4.Text);
            if (num3 % 2 == 0 && num3 >=10)
            {
                label8.Text = "Even and bigger than ten";
            }
            else
            {
                label8.Text = "Not even or not bigger than ten.";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num4 = Convert.ToInt16(textBox5.Text);
            if (num4 % 2 == 0 || num4 >= 10)
            {
                label10.Text = "Even or bigger than ten";
            }
            else
            {
                label10.Text = "Not even and not bigger than ten";
            }
        }
    }
}
