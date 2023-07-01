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
using System.Xml.Linq;

namespace desing
{
    public partial class frmAppointmentConfirmation : Form
    {
        public frmAppointmentConfirmation()
        {
            InitializeComponent();
            lblAppointmenDateTime.Text = Global.appointmentdatetime;
            lblClinic.Text = Global.appointmentclinic;
            lblHospital.Text = Global.appointmenthospital;
            lblDoctor.Text = Global.appointmentdoctor;
            using (var ctx = new HospitalContext())
            {
                var sonuc = from o in ctx.Patients
                            where o.patient_identity_no == Global.patientidentityno
                            select o;
                var patient = sonuc.FirstOrDefault();
                if (patient != null)
                {
                    lblAppointmentOwner.Text = patient?.patient_name?.ToUpper() + " " + patient?.patient_surname?.ToUpper(); ;
                }
                else
                {
                    MessageBox.Show("Böyle Bir Kayıt Bulunamadı!");
                }
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button == btnReturn)
            {
                this.Close();
            }
            else if (button == btnConfirm)
            {
                try
                {
                    using (var db = new HospitalContext())
                    {
                        var appointment = new Appointment
                        {
                            patient_identity_no = Global.patientidentityno, // Hastanın TC kimlik numarası
                            doctor_identity_no = Global.appointmentdoctoridentityno, // Doktorun TC kimlik numarası
                            date = Global.appointmentdate, // Randevu tarihi (günün tarihi)
                            time = Global.appointmenttime, // Randevu saati
                            status = "active" // Durum ("active" veya "inactive" olarak belirlenebilir)
                        };

                        db.Appointments.Add(appointment);
                        db.SaveChanges();
                    }


                    MessageBox.Show("Randevunuz Başarıyla Onaylandı. Sağlıklı Günler Dileriz.");
                    this.Close();
                    var frm1 = Application.OpenForms.OfType<frmHasta>().FirstOrDefault();
                    if (frm1 != null)
                    {
                        frm1.btnMakeAnAppointment.PerformClick();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Dene :(");
                }
                

            }
        }
    }
}
