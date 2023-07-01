using desing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desing
{
    public partial class frmDoctorVisit : Form
    {
        public frmDoctorVisit()
        {
            InitializeComponent();
        }

        private void txtPatientIdentityNo_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtPatientIdentityNo.Text;

            using (var dbContext = new HospitalContext())
            {
                var filteredProducts = dbContext.Visits
                    .Where(p => p.patient_identity_no.Contains(searchText))
                    .ToList();
                dgwTestResult.DataSource = filteredProducts;
            }
        }
    }
}
