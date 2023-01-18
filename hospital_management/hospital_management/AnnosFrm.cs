using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_management
{
    public partial class AnnosFrm : Form
    {
        public AnnosFrm()
        {
            InitializeComponent();
        }

        Connect con = new Connect();

        private void AnnosFrm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Annos_Tbl", con.link());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
