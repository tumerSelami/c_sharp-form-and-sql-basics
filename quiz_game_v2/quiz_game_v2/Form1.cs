using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_game_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo, dogru, yanlıs = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonra.Enabled = true;

            lblKullaniciCevap.Text = btnB.Text;
            if (lblKullaniciCevap.Text == lblCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonra.Enabled = true;

            lblKullaniciCevap.Text = btnC.Text;
            if (lblKullaniciCevap.Text == lblCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonra.Enabled = true;

            lblKullaniciCevap.Text = btnD.Text;
            if (lblKullaniciCevap.Text == lblCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonra.Enabled = true;
           
            lblKullaniciCevap.Text = btnA.Text;
            if (lblKullaniciCevap.Text == lblCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonra_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonra.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo++;
            lblSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Türkiye cumhuriyeti kaç yılında kurulmuştur?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                lblCevap.Text= btnD.Text;
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi ilimiz Ege bölgesinde bulunmaz?";
                btnA.Text = "İzmir";
                btnB.Text = "Manisa";
                btnC.Text = "Balıkesir";
                btnD.Text = "Aydın";
                lblCevap.Text = btnC.Text;
            }

            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar kitabı hangi yazarımıza aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Reşat Nuri";
                lblCevap.Text = btnA.Text;
                btnSonra.Text = "Sonuçlar";
            }

            if (soruNo == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonra.Enabled = false;

                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlıs);
            }
        }
    }
}
