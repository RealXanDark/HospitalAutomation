using desing.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace desing
{
    public partial class frmTestResult : Form
    {
        public frmTestResult()
        {
            InitializeComponent();
            FormLoad();
        }
        private void FormLoad()
        {
            using (var db = new HospitalContext())
            {
                var test = db.Tests
                    .Where(a => a.doctor_control == 0 && a.result != String.Empty)
                    .ToList();
                dgwTestResult.DataSource = test;
            }
        }

        private void dgwTestResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSelectedTestId.Text = "Seçilen Tahlil Id : " + dgwTestResult.CurrentRow.Cells[0].Value.ToString();
            Global.testid = int.Parse(dgwTestResult.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty);
        }

        private void btnSendResult_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Test Sonucunu Göndermek İstediğinize Emin isiniz?", "Test Sonucu Gönder", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (var context = new HospitalContext())
                {
                    var test = context.Tests.FirstOrDefault(e => e.test_id == Global.testid);

                    if (test != null)
                    {
                        test.remarks = txtTestResult.Text;
                        test.doctor_control = 1;
                        context.SaveChanges();
                        this.Close();
                        var frm1 = Application.OpenForms.OfType<frmDoctor>().FirstOrDefault();
                        if (frm1 != null)
                        {
                            frm1.btnTestResults.PerformClick();
                        }
                    }
                }
            }
        }

        private void txtPatientIdentityNo_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtPatientIdentityNo.Text;

            using (var dbContext = new HospitalContext())
            {
                var filteredProducts = dbContext.Tests
                    .Where(p => p.patient_identity_no != null && p.patient_identity_no.Contains(searchText))
                    .ToList();
                dgwTestResult.DataSource = filteredProducts;
            }
        }

        private void txtTestResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSelectedTestId_Click(object sender, EventArgs e)
        {
        }
    }
}
