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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int increament = Convert.ToInt16(textBox1.Text);

            for (int i = 1; i <= increament; i++)
            {
                listBox2.Items.Add(i);

                if (increament % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
