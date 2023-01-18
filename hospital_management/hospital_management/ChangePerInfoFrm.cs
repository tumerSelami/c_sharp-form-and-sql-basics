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
    public partial class ChangePerInfoFrm : Form
    {
        public ChangePerInfoFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect(); 

        public string IDN;

        private void ChangePerInfoFrm_Load(object sender, EventArgs e)
        {
            mskIDN.Text = IDN;
            SqlCommand com = new SqlCommand("select * from Patients_Tbl where PatientIdentity = @p1", con.link());
            com.Parameters.AddWithValue("@p1", mskIDN.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtLast.Text = dr[2].ToString();
                mskPhone.Text = dr[4].ToString();
                cmbGender.Text = dr[6].ToString();
                txtPass.Text = dr[5].ToString();
            }
            con.link().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand com2 = new SqlCommand("update Patients_Tbl set PatientName = @p1, PatientLast = @p2, PatientPhone = @p3, PatientPassword = @p4, PatientGender = @p5 where PatientIdentity = @p6", con.link());
            com2.Parameters.AddWithValue("@p1", txtName.Text);
            com2.Parameters.AddWithValue("@p2", txtLast.Text);
            com2.Parameters.AddWithValue("@p3", mskPhone.Text);
            com2.Parameters.AddWithValue("@p4", txtPass.Text);
            com2.Parameters.AddWithValue("@p5", cmbGender.Text);
            com2.Parameters.AddWithValue("@p6", mskIDN.Text);
            com2.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Your Personal Information has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
