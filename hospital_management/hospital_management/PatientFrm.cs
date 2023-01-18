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
    public partial class PatientFrm : Form
    {
        public PatientFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect();

        public string IDN;

        private void PatientFrm_Load(object sender, EventArgs e)
        {
            //Extracts Patients Information
            lblIDNumber.Text = IDN;
            SqlCommand com = new SqlCommand("select PatientName, PatientLast from Patients_Tbl where PatientIdentity = @p1", con.link());
            com.Parameters.AddWithValue("@p1", lblIDNumber.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblNameLast.Text = dr[0] + " " + dr[1];
            }
            con.link().Close();

            //Extracts Appointment History
            DataTable dt = new DataTable();
            SqlDataAdapter da = new  SqlDataAdapter("select * from Appoints_Tbl where PatientIdentity = " + IDN, con.link());
            da.Fill(dt);
            dataGridView1.DataSource = dt;//No need for closing link

            //Extracts Majors
            SqlCommand com2 = new SqlCommand("select MajorName from Majors_Tbl", con.link());
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                cmbMajor.Items.Add(dr2[0]);
            }
            con.link().Close();
        }

        private void cmbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand com3 = new SqlCommand("select DoctorName, DoctorLast from Doctors_Tbl where DoctorMajor = @p1", con.link());
            com3.Parameters.AddWithValue("@p1", cmbMajor.Text);
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            con.link().Close();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Appoints_Tbl where AppointMajor='" + cmbMajor.Text + "'" + "and AppointDoctor='" + cmbDoctor.Text + "' and AppointStatus = 0", con.link());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void lnkChangeInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePerInfoFrm fr = new ChangePerInfoFrm();
            fr.IDN = lblIDNumber.Text;
            fr.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand com4 = new SqlCommand("update Appoints_Tbl set AppointStatus = 1, PatientIdentity = @p1, PatientStiuation = @p2 where AppointID = @p3", con.link());
            com4.Parameters.AddWithValue("@p1", lblIDNumber.Text);
            com4.Parameters.AddWithValue("@p2", rchSituation.Text);
            com4.Parameters.AddWithValue("@p3", txtID.Text);
            com4.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Appointment has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
        }
    }
}
