using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teleport_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Traveller: " + textBox1.Text + " L: " + comboBox1.Text + " D: " + comboBox2.Text + " Date: " + dateTimePicker1.Text + " " + maskedTextBox1.Text);
        }
    }
}
