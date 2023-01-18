using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int question, correct, incorrect = 0;

        void btnEnblF ()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNxt.Enabled = true;
        }

        void btnEnblT ()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
        }

        void answerQuery()
        {
            if (lblAnswer.Text == lblUanswer.Text)
            {
                correct++;
                lblCorrect.Text = correct.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                btnEnblF();
            }
            else
            {
                incorrect++;
                lblIncorrect.Text = incorrect.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                btnEnblF();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            lblUanswer.Text = btnB.Text;
            answerQuery();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblUanswer.Text = btnC.Text;
            answerQuery();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            lblUanswer.Text = btnD.Text;
            answerQuery();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lblUanswer.Text = btnA.Text;
            answerQuery();
        }

        private void btnNxt_Click(object sender, EventArgs e)
        {
            question++;
            lblQuest.Text = question.ToString();    
            btnNxt.Text = "Next!";            
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnNxt.Enabled = false;
            btnEnblT();

            if (question == 1)
            {
                richTextBox1.Text = "When The Republic of Turkey was Founded?";
                btnA.Text = "29 October 1923";
                btnB.Text = "29 September 1926";
                btnC.Text = "29 October 1920";
                btnD.Text = "29 September 1923";
                lblAnswer.Text = btnA.Text;
            }

            if (question == 2)
            {
                richTextBox1.Text = "When Belgium was Founded?";
                btnA.Text = "6 September 1835";
                btnB.Text = "2 October 1825";
                btnC.Text = "4 September 1830";
                btnD.Text = "16 October 1820";
                lblAnswer.Text = btnC.Text;
            }

            if (question == 3)
            {
                lblQuest.Text = "2";
                richTextBox1.Text = "Congrats! You've finished the quiz.\nYou can see your statistics at the right side.";
                btnEnblF();
                btnNxt.Enabled = false;
            }
        }
    }
}
