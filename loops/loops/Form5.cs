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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;

            while (i <= 5)
            {
                listBox1.Items.Add(i + " Hello World!");
                i++;
            }

            int j = 0;
            int sum = 0;

            while (j <= 10)
            {
                sum = sum + j;
                listBox2.Items.Add(sum);
                j++;
            }

        }
    }
}
