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
    public partial class PatientSignUpFrm : Form
    {
        public PatientSignUpFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into patients_tbl (PatientName, PatientLast, PatientIdentity, PatientPhone, PatientPassword, PatientGender) values (@p1, @p2, @p3, @p4, @p5, @p6)", con.link());
            com.Parameters.AddWithValue("@p1", txtName.Text);
            com.Parameters.AddWithValue("@p2", txtLast.Text);
            com.Parameters.AddWithValue("@p3", mskIDN.Text);
            com.Parameters.AddWithValue("@p4", mskPhone.Text);
            com.Parameters.AddWithValue("@p5", txtPass.Text);
            com.Parameters.AddWithValue("@p6", cmbGender.Text);
            com.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Sign Up is successful and your password is: " + txtPass.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
