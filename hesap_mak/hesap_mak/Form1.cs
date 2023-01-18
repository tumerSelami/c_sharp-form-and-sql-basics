namespace hesap_mak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            label7.Text = Convert.ToString(sayi1 + sayi2);
            label8.Text = Convert.ToString(sayi1 - sayi2);
            label9.Text = Convert.ToString(sayi1 * sayi2);
            label10.Text = Convert.ToString(sayi1 / sayi2);
        }
    }
}