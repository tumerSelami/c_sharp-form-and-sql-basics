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
    public partial class MajorPanelFrm : Form
    {

        Connect con = new Connect();

        public MajorPanelFrm()
        {
            InitializeComponent();
        }

        private void MajorPanelFrm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Majors_Tbl", con.link());
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenCell = dataGridView1.SelectedCells[0].RowIndex;
            txtMajorID.Text = dataGridView1.Rows[chosenCell].Cells[0].Value.ToString();
            txtMajor.Text = dataGridView1.Rows[chosenCell].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into Majors_Tbl (MajorName) values (@p1)", con.link());
            com.Parameters.AddWithValue("@p1", txtMajor.Text);
            com.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Major has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlCommand com1 = new SqlCommand("delete from Majors_Tbl where MajorID = @p1", con.link());
            com1.Parameters.AddWithValue("@p1", txtMajorID.Text);
            com1.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Major has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand com2 = new SqlCommand("update Majors_Tbl set MajorName = @p1 where MajorID = @p2", con.link());
            com2.Parameters.AddWithValue("@p1", txtMajor.Text);
            com2.Parameters.AddWithValue("@p2", txtMajorID.Text);
            com2.ExecuteNonQuery();
            con.link().Close();
            MessageBox.Show("Major has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
