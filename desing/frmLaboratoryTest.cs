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
    public partial class frmLaboratoryTest : Form
    {
        public frmLaboratoryTest()
        {
            InitializeComponent();
            FormLoad();
        }
        private void FormLoad()
        {
            using (var db = new HospitalContext())
            {
                var test = db.Tests
                    .Where(a => a.doctor_control == 0 && a.result == string.Empty)
                    .ToList();
                dgwTest.DataSource = test;
            }
        }

        private void dgwTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSelectedTest.Text = "Seçili Test Id : " + dgwTest.CurrentRow.Cells[0].Value.ToString();

            if (dgwTest.CurrentRow.Cells[0].Value != null &&
                int.TryParse(dgwTest.CurrentRow.Cells[0].Value.ToString(), out int testId))
            {
                Global.testid = testId;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmLaboratoryResult result = new frmLaboratoryResult();
            result.StartPosition = FormStartPosition.CenterParent;
            result.ShowDialog();
        }
    }
}
