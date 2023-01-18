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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        SqlConnection link = new SqlConnection("Data Source=DESKTOP-KVV9CU5\\SQLEXPRESS;Initial Catalog=StaffDB;Integrated Security=True");

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand com1 = new SqlCommand("select count(*) from tbl_staff", link);
            SqlDataReader dr1 = com1.ExecuteReader(); /*It is used with selecet queries*/
            while (dr1.Read()) /*While dr1 finishes reading*/
            {
                LblPerSum.Text = dr1[0].ToString(); /*In Sql the result is in index 0 (row 0 column 0)*/
            }
            link.Close();


            link.Open();
            SqlCommand com2 = new SqlCommand("select count(*) from tbl_staff where perstatus = 1", link);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                LblPerMar.Text = dr2[0].ToString();
            }
            link.Close();


            link.Open();
            SqlCommand com3 = new SqlCommand("select count(*) from tbl_staff where perstatus = 0", link);
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                LblPerBach.Text = dr3[0].ToString();
            }
            link.Close();


            link.Open();
            SqlCommand com4 = new SqlCommand("select count(distinct(perstate)) from tbl_staff", link);
            SqlDataReader dr4 = com4.ExecuteReader();
            while (dr4.Read())
            {
                LblState.Text = dr4[0].ToString();
            }
            link.Close();


            link.Open();
            SqlCommand com5 = new SqlCommand("select sum(perwage) from tbl_staff", link);
            SqlDataReader dr5 = com5.ExecuteReader();
            while (dr5.Read())
            {
                LblSumWage.Text = dr5[0].ToString();
            }
            link.Close();


            link.Open();
            SqlCommand com6 = new SqlCommand("select avg(perwage) from tbl_staff", link);
            SqlDataReader dr6 = com6.ExecuteReader();
            while (dr6.Read())
            {
                LblAveWage.Text = dr6[0].ToString();
            }
            link.Close();
        }
    }
}
