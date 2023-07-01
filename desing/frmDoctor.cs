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
    public partial class frmDoctor : Form
    {
        public static Form form;
        public frmDoctor()
        {
            InitializeComponent();
            form = this;

        }
        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.Name == "btnAppointments")
            {
                frmDoctorAppointment appointment = new frmDoctorAppointment();
                Methods.OpenForms(appointment, pnlMain);
                //btn.BackColor = Color.FromArgb(237, 60, 60);
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
            else if (btn.Name == "btnTestResults")
            {
                frmTestResult testResult = new frmTestResult();
                Methods.OpenForms(testResult, pnlMain);
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
            else if (btn.Name == "btnPastTreatments")
            {
                frmDoctorVisit examination = new frmDoctorVisit();
                Methods.OpenForms(examination, pnlMain);
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
            else if (btn.Name == "btnAccount")
            {
                frmDoctorUser User = new frmDoctorUser();
                Methods.OpenForms(User, pnlMain);
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
            else if (btn.Name == "btnLogOut")
            {
                Application.Restart();
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            btnAppointments.PerformClick();
        }
    }
}
