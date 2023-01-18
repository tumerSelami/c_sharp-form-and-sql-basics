using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int sum2 = 0;

            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;
            }
            label1.Text = sum.ToString();

            for (int i = 2; i <= 10; i += 2)
            {
                sum2 = sum2 + i;
            }
            label2.Text = sum2.ToString();
        }
    }
}
