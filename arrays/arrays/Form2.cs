using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] characters = { "Jake", "Sally", "Fry", "Leela", "Emily", "Cecilia" };
        int[] ints = { 25, 36, 48, 3, 4, 9, 66, 12, 34, 88, 20, 8, 3, 15, 73};

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                listBox1.Items.Add(characters[i]);
            }

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0 && ints[i] >= 10)
                {
                    listBox2.Items.Add(ints[i]);
                }
            }
        }
    }
}
