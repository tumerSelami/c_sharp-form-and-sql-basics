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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] characters = { "Jake", "Sally", "Fry", "Leela", "Emily", "Cecilia" };

        int[] years = { 1996, 1997, 1998, 1999, 2000, 2001 };

        double[] scores = { 9.7, 8.4, 7.7, 9.2, 8.5 };

        char[] chars = { 'J', 'S', 'F', 'L', 'E', 'C' };

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = characters[2];
            label2.Text = years[5].ToString();
            label3.Text = scores[0].ToString();
            label4.Text = chars[3].ToString();

        }
    }
}
