using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methods
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int multiply(int num1, int num2, int num3)
        {
            return (num1 * num2 * num3); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = multiply(1, 2, 3).ToString();
            label2.Text = multiply(4, 5, 6).ToString();
            label3.Text = multiply(7, 8, 9).ToString();
        }

        int cubing(int num)
        {
            return (num * num * num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox1.Text);
            label4.Text = cubing(n).ToString();
        }

        int add(int num1, int mum2)
        {
            return (num1 + mum2);
        }

        int substract(int num1, int mum2)
        {
            return (num1 - mum2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            label5.Text = add(n, n2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            label5.Text = substract(n, n2).ToString();
        }
    }
}
