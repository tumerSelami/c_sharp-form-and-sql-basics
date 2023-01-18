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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[] characters = { "Jake", "Sally", "Fry", "Leela", "Emily", "Cecilia" };
        int[] ints = { 25, 36, 48, 66, 12, 34, 88, 20, 96, 10};
        int fours = 0, sumOfFours = 0, sum = 0;
        int average;

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string c in characters)
            {
                listBox1.Items.Add(c);
            }

            foreach (int x in ints)
            {
                listBox2.Items.Add(x);
                sum = sum + x;
            }

            label1.Text = sum.ToString();
            average = sum / ints.Length;
            label2.Text = average.ToString();

            
            foreach (int i in ints)
            {
                if (i % 4 == 0)
                {
                    listBox3.Items.Add(i);
                    fours++;
                    sumOfFours = sumOfFours + i;        
                }
                
                label4.Text = sumOfFours.ToString();
                label3.Text = fours.ToString();
            }
        }
    }
}
