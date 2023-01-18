using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiple_forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string sender1;
        public string message1;
        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = sender1;
            label4.Text = message1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.sender2 = textBox1.Text;
            f2.message2 = textBox2.Text;
            f2.Show();
            this.Close();
        }
    }
}
