using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_snackbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int regSum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int water, tea, corn, ticket, orSum;
            water = Convert.ToInt16(txtWater.Text);
            tea = Convert.ToInt16(txtTea.Text);
            corn = Convert.ToInt16(txtCorn.Text);
            ticket = Convert.ToInt16(txtTicket.Text);
            orSum = water * 1 + tea * 2 + corn * 4 + ticket * 6;

            txtOrSum.Text = "Order Sum: " + orSum;

            regSum = orSum + regSum;
            txtRegSum.Text = "Register Sum: " + regSum;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtWater.Text = "";
            txtTea.Text = "";
            txtCorn.Text = "";
            txtTicket.Text = "";
            txtWater.Focus();
        }
    }
}
