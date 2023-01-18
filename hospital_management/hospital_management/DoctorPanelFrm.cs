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
    public partial class DoctorPanelFrm : Form
    {
        public DoctorPanelFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect();

        private void DoctorPanelFrm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Doctors_Tbl", con.link());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Extracts Majors to Combobox
            SqlCommand com3 = new SqlCommand("select MajorName from Majors_Tbl", con.link());
            SqlDataReader dr1 = com3.ExecuteReader();
            while (dr1.Read())
            {
                cmbMajor.Items.Add(dr1[0]);
            }
            con.link().Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into Doctors_Tbl (DoctorName, DoctorLast, DoctorMajor, DoctorIdentity, DoctorPassword) values (@p1, @p2, @p3, @p4, @p5)", con.link());
            com.Parameters.AddWithValue("@p1", txtName.Text);
            com.Parameters.AddWithValue("@p2", txtLast.Text);
            com.Parameters.AddWithValue("@p3", cmbMajor.Text);
            com.Parameters.AddWithValue("@p4", mskIDNumber.Text);
            com.Parameters.AddWithValue("@p5", txtPass.Text);
            com.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Doctor has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenCell = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[chosenCell].Cells[1].Value.ToString();
            txtLast.Text = dataGridView1.Rows[chosenCell].Cells[2].Value.ToString();
            cmbMajor.Text = dataGridView1.Rows[chosenCell].Cells[3].Value.ToString();
            mskIDNumber.Text = dataGridView1.Rows[chosenCell].Cells[4].Value.ToString();
            txtPass.Text = dataGridView1.Rows[chosenCell].Cells[5].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlCommand com1 = new SqlCommand("delete from Doctors_Tbl where DoctorIdentity = @p1", con.link());
            com1.Parameters.AddWithValue("@p1", mskIDNumber.Text);
            com1.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Doctor has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand com2 = new SqlCommand("update Doctors_Tbl set DoctorName = @p1, DoctorLast = @p2, DoctorMajor = @p3, DoctorPassword = @p5 where DoctorIdentity = @p4", con.link());
            com2.Parameters.AddWithValue("@p1", txtName.Text);
            com2.Parameters.AddWithValue("@p2", txtLast.Text);
            com2.Parameters.AddWithValue("@p3", cmbMajor.Text);
            com2.Parameters.AddWithValue("@p4", mskIDNumber.Text);
            com2.Parameters.AddWithValue("@p5", txtPass.Text);
            com2.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Doctor has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
