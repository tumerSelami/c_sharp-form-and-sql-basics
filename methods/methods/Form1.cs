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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void write()
        {
            textBox1.Text = "Selami";
            textBox2.Text = "TÜMER";
            textBox3.Text = "20";
            textBox4.Text = "Student";
        }

        void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        void addColor()
        {
            textBox1.BackColor = Color.Tan;
            textBox2.BackColor = Color.SpringGreen;
            textBox3.BackColor = Color.Wheat;
            textBox4.BackColor = Color.Salmon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            write();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addColor();
        }
    }
}
