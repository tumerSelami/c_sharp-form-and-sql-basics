using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; /*Library should be added*/

namespace file_functions_etc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string fileLoc, fileName;
        StreamWriter sw; /*It is used for creating files and StreamReader is used for vica versa. Stream used to indicate ongoing process*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                fileLoc = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = fileLoc;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileName = textBox2.Text;
            sw = File.CreateText(fileLoc + "//" + fileName + ".txt"); /*One slash is for escaping*/
            sw.Close();
        }
    }
}
