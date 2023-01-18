using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //count++;
            //label1.Text=count.ToString();
            //if (count == 50)
            //{
            //    timer1.Stop();
            //    this.BackColor = Color.PeachPuff;
            //}

            count++;
            label1.Text = count.ToString();
            if (count == 15)
            {
                this.BackColor = Color.PeachPuff;
            }
            if (count == 30)
            {
                this.BackColor = Color.PapayaWhip;
                count = 0;
            }

            //count++;
            //label1.Text = count.ToString();
            //if (count % 5 == 0)
            //{
            //    this.BackColor = Color.PeachPuff;
            //}
            //if (count % 10 == 0)
            //{
            //    this.BackColor = Color.PapayaWhip;
            //}

        }
    }
}
