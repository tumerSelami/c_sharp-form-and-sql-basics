using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] symbol1 = { "a", "b", "c", "d", "e"};
            string[] symbol2 = { "A", "B", "C", "D", "E" };
            string[] symbol3 = {"+", "-", "*", "/", "#" };
            int symbol4;

            Random r = new Random();
            int num1, num2, num3;
            num1 = r.Next(0, symbol1.Length);
            num2 = r.Next(0, symbol2.Length);
            num3 = r.Next(0, symbol3.Length);
            symbol4 = r.Next(0, 10);

            label1.Text = symbol1[num1].ToString() + symbol2[num2].ToString() + symbol3[num3].ToString() + symbol4.ToString();
        }
    }
}
