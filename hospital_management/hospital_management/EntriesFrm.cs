using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management
{
    public partial class EntriesFrm : Form
    {
        public EntriesFrm()
        {
            InitializeComponent();
        }

        private void btnPatientEntry_Click(object sender, EventArgs e)
        {
            PatientEntryFrm fr = new PatientEntryFrm();
            fr.Show();
            this.Hide();
        }

        private void btnDoctorEntry_Click(object sender, EventArgs e)
        {
            DoctorEntryFrm fr = new DoctorEntryFrm();
            fr.Show();
            this.Hide();
        }

        private void btnSecretaryEntry_Click(object sender, EventArgs e)
        {
            /*We can use multiple fr objects because of the scope*/
            SecretaryEntryFrm fr = new SecretaryEntryFrm();
            fr.Show();
            this.Hide();
        }
    }
}
