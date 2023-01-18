using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(textBox1.Text);

            switch (month)
            {
                case 1: label2.Text = "January"; break;
                case 2: label2.Text = "February"; break;
                case 3: label2.Text = "March"; break;
                case 4: label2.Text = "April"; break;
                case 5: label2.Text = "May"; break;
                case 6: label2.Text = "June"; break;
                case 7: label2.Text = "July"; break;
                case 8: label2.Text = "August"; break;
                case 9: label2.Text = "September"; break;
                case 10: label2.Text = "October"; break;
                case 11: label2.Text = "November"; break;
                case 12: label2.Text = "December"; break;
                default: label2.Text = "Invalid Number"; break;                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string season = textBox2.Text;

            switch (season)
            {
                case "Winter": label5.Text = "December / January / February";
                    break;
                case "Spring": label5.Text = "March / April / May";
                    break;
                case "Summer": label5.Text = "June / July / August";
                    break;
                case "Autumn": label5.Text = "September / October / November";
                    break;
                default: label5.Text = "Invalid Season Entry";
                    break;
            }
        }
    }
}
