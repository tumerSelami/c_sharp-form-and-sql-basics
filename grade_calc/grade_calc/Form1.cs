using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grade_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mid, final, grade;
            string status;

            mid = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            grade = (mid * 0.4) + (final * 0.6);
            status = "dummy";

            if (grade <= 35)
            {
                status = "FF";                
            }
            if (grade >= 45)
            {
                status = "DD";
            }
            if (grade >= 50)
            {
                status = "DC";
            }
            if (grade >= 55)
            {
                status = "CC";
            }
            if (grade >= 63)
            {
                status = "CB";
            }
            if (grade >= 71)
            {
                status = "BB";
            }
            if (grade >= 80)
            {
                status = "BA";
            }
            if (grade >= 90)
            {
                status = "AA";
            }
            else
            {
                textBox3.Text = grade.ToString("0.00") + " Invalid Scores ";
            }

            textBox3.Text = grade.ToString("0.00") + " / " + status;
        }
    }
}
