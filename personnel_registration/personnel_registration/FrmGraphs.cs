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

namespace personnel_registration
{
    public partial class FrmGraphs : Form
    {
        public FrmGraphs()
        {
            InitializeComponent();
        }

        SqlConnection link = new SqlConnection("Data Source=DESKTOP-KVV9CU5\\SQLEXPRESS;Initial Catalog=StaffDB;Integrated Security=True");

        private void FrmGraphs_Load(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand comg1 = new SqlCommand("select perstate, count(*) from tbl_staff group by perstate", link);
            SqlDataReader drg1 = comg1.ExecuteReader();
            while (drg1.Read())
            {
                chart1.Series["States"].Points.AddXY(drg1[0], drg1[1]);
            }
            link.Close();


            link.Open();
            SqlCommand comg2 = new SqlCommand("select perline, avg(perwage) from tbl_staff group by perline", link);
            SqlDataReader drg2 = comg2.ExecuteReader();
            while (drg2.Read())
            {
                chart2.Series["Line - Wage"].Points.AddXY(drg2[0], drg2[1]);
            }
            link.Close();
        }
    }
}
