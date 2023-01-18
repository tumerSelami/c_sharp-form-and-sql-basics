using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car c = new Car();
            c.model = "Cayanne";
            c.color = "White";
            c.engine = 1600.56;
            c.price = 24000;
            c.YEAR = -2011;
            c.BRAND = "Porsche";
            c.plate = "RCQ 516";
            c.maintenance = 2018;
            c.owner = "Jake Shepherd";
            c.message();

            label1.Text = c.model;
            label2.Text = c.color;
            label3.Text = c.engine.ToString();
            label4.Text = c.price.ToString();
            label5.Text = c.YEAR.ToString();
            label6.Text = c.BRAND.ToString();
            label7.Text = c.plate;
            label8.Text = c.maintenance.ToString();
            label9.Text = c.owner;
        }
    }
}
