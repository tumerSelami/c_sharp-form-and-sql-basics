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
    public partial class DoctorFrm : Form
    {
        public DoctorFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect();

        public string IDN;

        private void DoctorFrm_Load(object sender, EventArgs e)
        {
            lblIDNumber.Text = IDN;

            SqlCommand com = new SqlCommand("select DoctorName, DoctorLast from Doctors_Tbl where DoctorIdentity = @p1", con.link());
            com.Parameters.AddWithValue("@p1", lblIDNumber.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblNameLast.Text = dr[0] + " " + dr[1];
            }
            con.link().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Appoints_Tbl where AppointDoctor = '" + lblNameLast.Text + "'", con.link());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            ChangeDocInfoFrm fr = new ChangeDocInfoFrm();
            fr.IDN = lblIDNumber.Text;
            fr.Show();
        }

        private void btnAnno_Click(object sender, EventArgs e)
        {
            AnnosFrm fr = new AnnosFrm();
            fr.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
        }
    }
}
