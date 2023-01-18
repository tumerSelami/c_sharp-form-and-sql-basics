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
    public partial class AppointListFrm : Form
    {
        public AppointListFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect();

        private void AppointListFrm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Appoints_Tbl", con.link());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
