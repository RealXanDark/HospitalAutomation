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
    public partial class frmHasta : Form
    {
        public frmHasta()
        {
            InitializeComponent();
        }


        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.Name == "btnAppointments")
            {
                frmRandevularim randevularim = new frmRandevularim();
                Methods.OpenForms(randevularim, pnlMain);
                //btn.BackColor = Color.FromArgb(237, 60, 60);
                Methods.ChangeButtonColorInForm(this, btn);

            }

            else if (btn.Name == "btnMakeAnAppointment")
            {
                frmAppointment appointment = new frmAppointment();
                Methods.OpenForms(appointment, pnlMain);
                //btn.BackColor = Color.FromArgb(198, 50, 50);
                Methods.ChangeButtonColorInForm(this, btn);
            }
            else if (btn.Name == "btnTestResults")
            {
                frmPatientTestResult testResult = new frmPatientTestResult();
                Methods.OpenForms(testResult, pnlMain);
                Methods.ChangeButtonColorInForm(this, btn);
            }
            else if (btn.Name == "btnPrescriptions")
            {
                frmPrescriptions prescriptions = new frmPrescriptions();
                Methods.OpenForms(prescriptions, pnlMain);
                Methods.ChangeButtonColorInForm(this, btn);
            }
            else if (btn == btnVisits)
            {
                frmVisits visits = new frmVisits();
                Methods.OpenForms(visits, pnlMain);
                Methods.ChangeButtonColorInForm(this, btn);
            }
            else if (btn.Name == "btnAccount")
            {
                frmUser User = new frmUser();
                Methods.OpenForms(User, pnlMain);
                Methods.ChangeButtonColorInForm(this, btn);
            }
            else if (btn.Name == "btnLogOut")
            {
                Application.Restart();
                Methods.ChangeButtonColorInForm(this, btn);
            }
        }
        private void frmHasta_Load(object sender, EventArgs e)
        {
            btnAppointments.PerformClick();
        }
    }
}
