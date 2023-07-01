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
    public partial class frmDoctorAppointment : Form
    {
        public frmDoctorAppointment()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Methods.ChangeButtonColorInForm(this, btn);
            if (sender == btnActiveAppointments)
            {
                using (var db = new HospitalContext())
                {
                    var today = DateTime.Today;

                    var appointments = db.Appointments
                        .Where(a => a.status == "active" && a.doctor_identity_no == Global.userIdentityNo && a.date >= today)
                        .ToList();
                    dgwAppointment.DataSource = appointments;
                }
            }
            else if (sender == btnCanceledAppointments)
            {
                using (var db = new HospitalContext())
                {
                    var appointments = db.Appointments
                        .Where(a => a.status == "canceled" && a.doctor_identity_no == Global.userIdentityNo)
                        .ToList();
                    dgwAppointment.DataSource = appointments;
                }
            }
        }

        private void btnCallPatient_Click(object sender, EventArgs e)
        {

            frmExamination examination = new frmExamination();
            examination.StartPosition = FormStartPosition.CenterParent;
            examination.ShowDialog();
        }

        private void dgwAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSelectedPatient.Text = "Seçili Hasta T.C. : " + dgwAppointment.CurrentRow.Cells[1].Value.ToString();
            Global.patientidentityno = dgwAppointment.CurrentRow.Cells[1].Value.ToString();
            Global.appointmentid = dgwAppointment.CurrentRow.Cells[0].Value.ToString();
        }

        private void frmDoctorAppointment_Load(object sender, EventArgs e)
        {
            btnActiveAppointments.PerformClick();
        }
    }
}
