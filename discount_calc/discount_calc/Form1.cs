using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discount_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int book = Convert.ToInt16(maskedTextBox1.Text) * 8;

            if (book >= 0 && book <= 24)
            {
                sum = book * 0.80;
            }
            if (book >= 25 && book <= 40)
            {
                sum = book * 0.70;
            }
            if (book >= 40)
            {
                sum = book * 0.50;
            }

            label8.Text = sum.ToString();

        }
    }
}
