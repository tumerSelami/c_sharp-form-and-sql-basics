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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Car c = new Car();
            c.model = "911";
            c.color = "Black";
            c.engine = 1850.56;
            c.price = 28000;
            c.YEAR = -2009;
            c.BRAND = "Porsche";
            c.plate = "WRX 218";
            c.maintenance = 2019;
            c.owner = "Desmond Hume";
            c.message();

            label1.Text = c.model;
            label2.Text = c.color;
            label3.Text = c.engine.ToString();
            label4.Text = c.price.ToString();
            label5.Text = c.YEAR.ToString();
            label6.Text = c.BRAND;
            label7.Text = c.plate;
            label8.Text = c.maintenance.ToString();
            label9.Text = c.owner;
        }
    }
}
