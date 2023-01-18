using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_management
{
    public partial class PatientEntryFrm : Form
    {
        public PatientEntryFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect();

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientSignUpFrm fr = new PatientSignUpFrm();
            fr.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select *  from patients_tbl where PatientIdentity = @p1 and PatientPassword = @p2", con.link());
            com.Parameters.AddWithValue("@p1", mskIDN.Text);
            com.Parameters.AddWithValue("@p2", txtPass.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                PatientFrm fr = new PatientFrm();
                fr.IDN = mskIDN.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Identity Number or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            con.link().Close();
        }
    }
}
