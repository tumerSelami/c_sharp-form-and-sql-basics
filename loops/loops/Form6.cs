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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i <= 5)
            {
                listBox1.Items.Add("Hello User!");
                i++;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 6;

            do
            {
                listBox2.Items.Add("Hello User!");
                j++;
            }
            while (j <= 5);
        }
    }
}
