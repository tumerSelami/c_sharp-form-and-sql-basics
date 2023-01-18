using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamic_tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnLoc = new Point(20, 10);
            btn.Location = btnLoc;
            btn.Name = "button2";
            btn.Text = "Click!";
            btn.Height = 50;
            btn.Width= 50;
            btn.BackColor = Color.Blue;
            btn.ForeColor= Color.AliceBlue;
            this.Controls.Add(btn);

            Label lbl = new Label();
            Point lblLoc = new Point(80, 20);
            lbl.Location = lblLoc;
            lbl.Name = "label1";
            lbl.Text = "Helloww";
            lbl.BackColor = Color.DarkSeaGreen;
            lbl.AutoSize= true;
            this.Controls.Add(lbl);

            for (int i = 1; i < 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtLoc = new Point(300, i * 35);
                txt.Location = txtLoc;
                txt.Name = "textBox" + i;
                txt.Text = i.ToString();
                txt.BackColor = Color.GhostWhite;
                this.Controls.Add(txt);
            }
        }
    }
}
