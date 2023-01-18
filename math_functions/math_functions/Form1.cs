using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            //label1.Text = Math.Abs(num).ToString();
            //label1.Text = Math.Ceiling(num).ToString();
            //label1.Text = Math.Floor(num).ToString();
            //label1.Text = Math.Pow(num, 3).ToString();
            label1.Text = Math.Sqrt(num).ToString();
        }
    }
}