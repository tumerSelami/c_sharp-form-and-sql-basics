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
    public partial class SecretaryFrm : Form
    {
        public SecretaryFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect();
        public string IDN;

        private void SecretaryFrm_Load(object sender, EventArgs e)
        {
            //Extracts Officer Information
            lblIDNumber.Text = IDN;
            SqlCommand com = new SqlCommand("select OfficerNameLast from Officers_Tbl where OfficerIdentity = @p1", con.link());
            com.Parameters.AddWithValue("@p1", lblIDNumber.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblNameLast.Text = dr[0].ToString();
            }
            con.link().Close();

            //Extracts Majors to DataGrid
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Majors_Tbl", con.link());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Extracts Doctors to DataGrid
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (DoctorName + ' ' + DoctorLast) as 'Doctors', DoctorMajor from Doctors_Tbl", con.link());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //Extracts Majors to Combobox
            SqlCommand com2 = new SqlCommand("select MajorName from Majors_Tbl", con.link());
            SqlDataReader dr1 = com2.ExecuteReader();
            while (dr1.Read())
            {
                cmbMajor.Items.Add(dr1[0]);
            }
            con.link().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand com1 = new SqlCommand("insert into Appoints_Tbl (AppointDate, AppointHour, AppointMajor, AppointDoctor) values (@p1, @p2, @p3, @p4)", con.link());
            com1.Parameters.AddWithValue("@p1", mskDate.Text);
            com1.Parameters.AddWithValue("@p2", mskHour.Text);
            com1.Parameters.AddWithValue("@p3", cmbMajor.Text);
            com1.Parameters.AddWithValue("@p4", cmbDoctor.Text);
            com1.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Appointment has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cmbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand com3 = new SqlCommand("select DoctorName, DoctorLast from Doctors_Tbl where DoctorMajor = @p1", con.link());
            com3.Parameters.AddWithValue("@p1", cmbMajor.Text);
            SqlDataReader dr2 = com3.ExecuteReader();
            while (dr2.Read())
            {
                cmbDoctor.Items.Add(dr2[0] + " " + dr2[1]);
            }
            con.link().Close();
        }

        private void btnCreateAnno_Click(object sender, EventArgs e)
        {
            SqlCommand com4 = new SqlCommand("insert into Annos_Tbl (AnnoText) values (@p1)", con.link());
            com4.Parameters.AddWithValue("@p1", rchAnno.Text);
            com4.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Announcment has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDocPan_Click(object sender, EventArgs e)
        {
            DoctorPanelFrm fr = new DoctorPanelFrm();
            fr.Show();
        }

        private void btnMajPan_Click(object sender, EventArgs e)
        {
            MajorPanelFrm fr = new MajorPanelFrm();
            fr.Show();
        }

        private void btnAppoints_Click(object sender, EventArgs e)
        {
            AppointListFrm fr = new AppointListFrm();
            fr.Show();
        }

        private void btnAnnos_Click(object sender, EventArgs e)
        {
            AnnosFrm fr = new AnnosFrm();
            fr.Show();
        }
    }
}
