namespace cevre_alan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar, alan, cevre;
            birkenar = Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            cevre = 4 * birkenar;

            label6.Text = alan.ToString();
            label7.Text = cevre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label8.Text = "Karenin Alan ve Çevresi";
            label3.Visible = false;
            textBox2.Visible = false;
            button5.Visible = false;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label8.Text = "Dikdörtgenin Alan ve Çevresi";
            label2.Text = "Uzun kenarı giriniz:";
            label3.Text = "Kısa kenarı giriniz:";
            label3.Visible = true;
            textBox2.Visible = true;
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int uzun, kisa;
            int dikalan, dikcevre;
            uzun = Convert.ToInt32(textBox1.Text);
            kisa = Convert.ToInt32(textBox2.Text);
            dikalan = uzun * kisa;
            dikcevre = (uzun * 2) + (kisa * 2);

            label6.Text = dikalan.ToString();
            label7.Text = dikcevre.ToString();
        }
    }
}