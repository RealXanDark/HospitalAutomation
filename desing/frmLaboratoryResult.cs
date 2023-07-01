using desing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace desing
{
    public partial class frmLaboratoryResult : Form
    {
        public frmLaboratoryResult()
        {
            InitializeComponent();
            FormLoad();
        }
        private void FormLoad()
        {
            using (var db = new HospitalContext())
            {
                var test = db.Tests
                    .Where(a => a.test_id == Global.testid)
                    .ToList();
                dgwTest.DataSource = test;
            }
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
                        // Verileri güncelle
                        test.result = txtTestResult.Text;
                        context.SaveChanges();
                        this.Close();
                        var frm1 = Application.OpenForms.OfType<frmLaboratory>().FirstOrDefault();
                        if (frm1 != null)
                        {
                            frm1.btnTests.PerformClick();
                        }
                    }
                }
            }
            
        }
    }
}
