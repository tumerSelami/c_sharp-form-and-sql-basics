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
    public partial class ChangeDocInfoFrm : Form
    {
        public ChangeDocInfoFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect();
        public string IDN;


        private void ChangeDocInfoFrm_Load(object sender, EventArgs e)
        {
            mskIDN.Text = IDN;

            SqlCommand com1 = new SqlCommand("select * from Doctors_Tbl where DoctorIdentity = @p1", con.link());
            com1.Parameters.AddWithValue("@p1", mskIDN.Text);
            SqlDataReader dr = com1.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtLast.Text = dr[2].ToString();
                cmbMajor.Text = dr[3].ToString();
                txtPass.Text = dr[5].ToString();
            }
            con.link().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand com2 = new SqlCommand("update Doctors_Tbl set DoctorName = @p1, DoctorLast = @p2, DoctorMajor = @p3, DoctorPassword = @p4 where DoctorIdentity = @p5", con.link());
            com2.Parameters.AddWithValue("@p1", txtName.Text);
            com2.Parameters.AddWithValue("@p2", txtLast.Text);
            com2.Parameters.AddWithValue("@p3", cmbMajor.Text);
            com2.Parameters.AddWithValue("@p4", txtPass.Text);
            com2.Parameters.AddWithValue("@p5", mskIDN.Text);
            com2.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Your Personal Information has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
