using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enum_usage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum cities { dummy, Adana, Adıyaman, Afyon, Ağrı, Amasya, Ankara, Antalya, Artvin, Aydın}

        private void button1_Click(object sender, EventArgs e)
        {
            int plate = Convert.ToInt16(textBox1.Text);
            cities c;
            c = (cities)plate;
            label1.Text = c.ToString();
        }
    }
}
