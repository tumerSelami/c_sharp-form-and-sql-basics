using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num1, num2, num3, num4;
            num1 = rnd.Next(1, 5); /*10 is not included*/
            num2 = rnd.Next(1, 5);
            num3 = rnd.Next(1, 5);
            num4 = rnd.Next(1, 5);
            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();
            label4.Text = num4.ToString();

            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                textBox1.BackColor = Color.Red; 
            }

            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            //this.Hide();
        }
    }
}
