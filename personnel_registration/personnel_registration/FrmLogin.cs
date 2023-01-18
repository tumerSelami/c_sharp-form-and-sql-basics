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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection link = new SqlConnection("Data Source=DESKTOP-KVV9CU5\\SQLEXPRESS;Initial Catalog=StaffDB;Integrated Security=True");

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand ComLog = new SqlCommand("select * from tbl_users where username = @p1 and password = @p2", link);
            ComLog.Parameters.AddWithValue("@p1", TxtUser.Text);
            ComLog.Parameters.AddWithValue("@p2", TxtPass.Text);
            SqlDataReader drlog = ComLog.ExecuteReader();
            if (drlog.Read())
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Denied");
            }
            link.Close();
        }
    }
}
