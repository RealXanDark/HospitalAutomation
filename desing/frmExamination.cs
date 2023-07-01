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
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace desing
{

    public partial class frmExamination : Form
    {
        frmTestResultWindow resultWindow = new frmTestResultWindow();
        public frmExamination()
        {
            InitializeComponent();
            label13.Text = "kronik baş ağrısı, burun kanaması, miğde bulantısı, baş dönmesi, kronik baş ağrısı, burun kanaması, miğde bulantısı, baş dönmesi";
            FormLoad();
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmTestResultWindow>().Any() == false)
            {
                resultWindow.Show();
            }
            else if (Application.OpenForms.OfType<frmTestResultWindow>().Any() == true)
            {
                resultWindow.Activate();
            }
        }

        private void cbTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTests.Items.Contains(cbTests.Text) == false)
            {
                lbTests.Items.Add(cbTests.Text);
            }
            else
            {
                MessageBox.Show("Bu Testi Zaten Eklediniz!");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbTests.SelectedItems != null)
            {
                lbTests.Items.Remove(lbTests.SelectedItem);
            }
        }

        private void lbTests_MouseDown(object sender, MouseEventArgs e)
        {
            lbTests.SelectedIndex = lbTests.IndexFromPoint(e.X, e.Y);
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            using (var context = new HospitalContext()) // DbContext sınıfının bir örneğini oluşturun
            {
                foreach (var item in lbTests.Items)
                {
                    // Yeni LabTest örneği oluşturun ve verileri doldurun
                    LabTest labTest = new LabTest()
                    {
                        patient_identity_no = Global.patientidentityno, // Örnek bir hastanın kimlik numarası
                        test_name = item.ToString(), // Listbox öğesinin adını test_name alanına ata
                        date = DateTime.Now, // Şu anki tarihi kullan
                        result = "", // Sonucu boş olarak bırak
                        remarks = "", // Yorumları boş olarak bırak
                        doctor_control = 0 // Doctor control değerini 0 olarak ayarla
                    };

                    // LabTest örneğini veritabanına ekleyin
                    context.Tests.Add(labTest);
                }

                // Değişiklikleri kaydet
                context.SaveChanges();
                MessageBox.Show("Testler başarıyla eklendi.");
                cbTests.SelectedIndex = -1;
                lbTests.Items.Clear();
            }
        }

        private void btnEndExamination_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Muayeneyi Bitirmek İstediğinizden Emin Misiniz?", "Muayene Bitir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (var dbContext = new HospitalContext())
                {
                    var appointment = dbContext.Appointments.FirstOrDefault(a => a.appointment_id == int.Parse(Global.appointmentid));
                    if (appointment != null)
                    {
                        appointment.status = "completed";

                        var visit = new Visit()
                        {
                            patient_identity_no = Global.patientidentityno,// Appointment'dan hasta kimlik numarası alınıyor
                            visit_date = DateTime.Now.Date, // Örnek ziyaret tarihi (bugünün tarihi)
                            diagnosis = txtDiagnosis.Text, // Örnek teşhis
                            medication = txtPrescriptions.Text, // Örnek ilaç
                        };

                        dbContext.Visits.Add(visit);
                        dbContext.SaveChanges();
                        this.Close();
                        var frm1 = Application.OpenForms.OfType<frmDoctor>().FirstOrDefault();
                        if (frm1 != null)
                        {
                            frm1.btnAppointments.PerformClick();
                        }
                    }
                }
            }

        }
        private void FormLoad()
        {
            try
            {
                using (var ctx = new HospitalContext())
                {
                    var sonuc = from o in ctx.Patients
                                where o.patient_identity_no == Global.patientidentityno
                                select o;
                    var patient = sonuc.FirstOrDefault();
                    if (patient != null)
                    {
                        lblName.Text = patient?.patient_name?.ToUpper();
                        lblSurname.Text = patient?.patient_surname?.ToUpper();
                        lblIdentityNo.Text = patient?.patient_identity_no?.ToUpper();
                        if (patient.patient_date_of_birth.HasValue)
                        {
                            lblDateOfBirth.Text = patient.patient_date_of_birth.Value.ToShortDateString();
                        }
                        lblBloodGroup.Text = patient.patient_blood_group;
                        lblGender.Text = patient.patient_gender;
                    }
                    else
                    {
                        MessageBox.Show("Böyle Bir Kayıt Bulunamadı!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Deneyin :(");
            }
        }
    }
}
