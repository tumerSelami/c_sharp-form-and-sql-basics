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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int hour, min, sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label1.Text = sec.ToString();
            if (sec == 60)
            {
                sec = 0;
                min++;
                label2.Text = min.ToString();
                if (min == 5)
                {
                    min = 0;
                    hour++;
                    label3.Text = hour.ToString();
                }
            }
        }
    }
}
