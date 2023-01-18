using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order_progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.SkyBlue;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Sienna;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
                label1.Text = "Step is Done";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value % 20 == 10)
            {
                label2.BackColor = Color.SkyBlue;
            }
            if (progressBar2.Value % 20 == 0)
            {
                label2.BackColor = Color.Sienna;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                label2.Text = "Step is Done";
                timer3.Start();                
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.SkyBlue;
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.Sienna;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                label3.Text = "Step is Done";
                MessageBox.Show("Your Order is Done!");
            }
        }
    }
}
