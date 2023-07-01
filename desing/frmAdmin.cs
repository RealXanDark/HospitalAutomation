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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
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
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }

            else if (btn.Name == "btnMakeAnAppointment")
            {
                frmAppointment appointment = new frmAppointment();
                Methods.OpenForms(appointment, pnlMain);
                //btn.BackColor = Color.FromArgb(198, 50, 50);
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
            else if (btn.Name == "btnTestResults")
            {
                frmTestResult testResult = new frmTestResult();
                Methods.OpenForms(testResult, pnlMain);
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
            else if (btn.Name == "btnEmployees")
            {
                frmEmployees employees = new frmEmployees();
                Methods.OpenForms(employees, pnlMain);
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
            else if (btn.Name == "btnAccount")
            {
                frmUser User = new frmUser();
                Methods.OpenForms(User, pnlMain);
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
            else if (btn.Name == "btnLogOut")
            {
                Application.Restart();
                Methods.ChangeButtonColorInPanel(panel2, btn);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            btnEmployees.PerformClick();
        }
    }
}
