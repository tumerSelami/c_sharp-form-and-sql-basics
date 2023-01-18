using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace file_functions_etc
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save Text File";
            saveFileDialog1.ShowDialog();

            StreamWriter sw2 = new StreamWriter(saveFileDialog1.FileName);
            sw2.WriteLine(richTextBox1.Text);
            sw2.Close();
            MessageBox.Show("File has been created!");
        }
    }
}
