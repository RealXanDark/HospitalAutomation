using desing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desing
{
    public partial class frmRandevularim : Form
    {
        public frmRandevularim()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Methods.ChangeButtonColorInForm(this, btn);
            if (sender == btnActiveAppointments)
            {
                delete.Visible = true;
                //Methods.LoadDGW<User>(dataGridView1, "patient_gender", "kadın");
                //Methods.DataGridViewDoldur("Doktor", "user_group_id", "6", dataGridView1);
                //using (var context = new HospitalContext())
                //{
                //    Methods.DataGridViewDoldur("Doktor", 6, dataGridView1, "user_group_id");
                //}
                //using (var db = new HospitalContext())
                //{
                //    var appointments = db.Appointments
                //        .Where(a => a.status == "active" && a.patient_identity_no == Global.patientidentityno)
                //        //.Select(a => new
                //        //{
                //        //    a.patient_identity_no,
                //        //    a.status
                //        //})
                //        .ToList();

                //    dataGridView1.DataSource = appointments;
                //}
                using (var db = new HospitalContext())
                {
                    var today = DateTime.Today;

                    var appointments = db.Appointments
                        .Where(a => a.status == "active" && a.patient_identity_no == Global.patientidentityno && a.date >= today)
                        .ToList();

                    dgwAppointments.DataSource = appointments;
                }
            }
            else if (sender == btnCanceledAppointments)
            {
                delete.Visible = false;
                using (var db = new HospitalContext())
                {
                    var appointments = db.Appointments
                        .Where(a => a.status == "canceled" && a.patient_identity_no == Global.patientidentityno)
                        //.Select(a => new
                        //{
                        //    a.patient_identity_no,
                        //    a.status
                        //})
                        .ToList();
                    dgwAppointments.DataSource = appointments;
                    
                }
            }



        }

        private void frmRandevularim_Load(object sender, EventArgs e)
        {
            btnActiveAppointments.PerformClick();
        }

        private void dgwAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwAppointments.Columns[e.ColumnIndex].Name == "delete")
            {
                DialogResult result = MessageBox.Show("Seçili Randevuyu İptal Etmek İstediğinize Emin Misiniz?", "Randevu İptali", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var selectedCellValue = dgwAppointments.CurrentRow.Cells[1].Value;
                    if (selectedCellValue != null && int.TryParse(selectedCellValue.ToString(), out int appointmentId))
                    {
                        using (var dbContext = new HospitalContext())
                        {
                            var appointment = dbContext.Appointments.FirstOrDefault(a => a.appointment_id == appointmentId);
                            if (appointment != null)
                            {
                                appointment.status = "canceled";
                                dbContext.SaveChanges();
                                btnActiveAppointments.PerformClick();
                            }
                        }
                    }
                }
            }
        }
    }
}
