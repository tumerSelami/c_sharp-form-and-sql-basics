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
/*Don't forget to add the library!!*/

namespace personnel_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection link = new SqlConnection("Data Source=DESKTOP-KVV9CU5\\SQLEXPRESS;Initial Catalog=StaffDB;Integrated Security=True");

        void Clean()
        {
            txtPerID.Text = "";
            txtName.Text = "";
            txtLast.Text = "";
            cmbState.Text = "";
            mskWage.Text = "";
            txtLine.Text = "";
            lblState.Text = "";
            radioButton1.Checked= false;
            radioButton2.Checked= false;
            txtName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDBDataSet.Tbl_Staff' table. You can move, or remove it, as needed.
            this.tbl_StaffTableAdapter.Fill(this.staffDBDataSet.Tbl_Staff);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.tbl_StaffTableAdapter.Fill(this.staffDBDataSet.Tbl_Staff);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand com = new SqlCommand("insert into tbl_staff (PerName, PerLast, PerState, PerWage, PerLine, PerStatus) values (@p1, @p2, @p3, @p4, @p5, @p6)", link);
            com.Parameters.AddWithValue("@p1", txtName.Text);
            com.Parameters.AddWithValue("@p2", txtLast.Text);
            com.Parameters.AddWithValue("@p3", cmbState.Text);
            com.Parameters.AddWithValue("@p4", mskWage.Text);
            com.Parameters.AddWithValue("@p5", txtLine.Text);
            com.Parameters.AddWithValue("@p6", lblState.Text);
            com.ExecuteNonQuery(); /*It is used with insert, update and delete*/
            link.Close();

            MessageBox.Show("Changes has been saved");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                lblState.Text = "True";
            }            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblState.Text = "False";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand ComDelete = new SqlCommand("delete from tbl_staff where perID = @d1", link);
            ComDelete.Parameters.AddWithValue("@d1", txtPerID.Text);
            ComDelete.ExecuteNonQuery();
            link.Close();

            MessageBox.Show("Registry has been deleted");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenCell = dataGridView1.SelectedCells[0].RowIndex;
            txtPerID.Text = dataGridView1.Rows[chosenCell].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[chosenCell].Cells[1].Value.ToString();
            txtLast.Text = dataGridView1.Rows[chosenCell].Cells[2].Value.ToString();
            cmbState.Text = dataGridView1.Rows[chosenCell].Cells[3].Value.ToString();
            mskWage.Text = dataGridView1.Rows[chosenCell].Cells[4].Value.ToString();
            lblState.Text = dataGridView1.Rows[chosenCell].Cells[5].Value.ToString();
            txtLine.Text = dataGridView1.Rows[chosenCell].Cells[6].Value.ToString();
        }

        private void lblState_TextChanged(object sender, EventArgs e)
        {
            if (lblState.Text == "True")
            {
                radioButton1.Checked = true;
            }

            if (lblState.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand ComUpdate = new SqlCommand("update tbl_staff set pername = @u1, perlast = @u2, perstate = @u3, perwage = @u4, perstatus = @u5, perline = @u6 where perID = @u7", link);
            ComUpdate.Parameters.AddWithValue("@u1", txtName.Text);
            ComUpdate.Parameters.AddWithValue("@u2", txtLast.Text);
            ComUpdate.Parameters.AddWithValue("@u3", cmbState.Text);
            ComUpdate.Parameters.AddWithValue("@u4", mskWage.Text);
            ComUpdate.Parameters.AddWithValue("@u5", lblState.Text);
            ComUpdate.Parameters.AddWithValue("@u6", txtLine.Text);
            ComUpdate.Parameters.AddWithValue("@u7", txtPerID.Text);
            ComUpdate.ExecuteNonQuery();
            link.Close();

            MessageBox.Show("Registry has been updated");
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            FrmStatistics stats = new FrmStatistics();
            stats.Show();
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            FrmGraphs grphs = new FrmGraphs();
            grphs.Show();
        }
    }
}
