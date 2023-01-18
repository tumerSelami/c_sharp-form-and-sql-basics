using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Reading"].Points.AddXY("Mars", 6.6);
            chart1.Series["Reading"].Points.AddXY("Jupiter", 7.2);
            chart1.Series["Reading"].Points.AddXY("Earth", 6);
            chart1.Series["Reading"].Points.AddXY("Uranus", 8.2);
        }
    }
}
