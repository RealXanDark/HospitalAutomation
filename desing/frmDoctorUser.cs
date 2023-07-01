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

namespace desing
{
    public partial class frmDoctorUser : Form
    {
        private HospitalContext dbContext;
        public frmDoctorUser()
        {
            InitializeComponent();
            dbContext = new HospitalContext();
            FormLoad();
        }
        private void FormLoad()
        {
            try
            {
                using (var ctx = new HospitalContext())
                {
                    var sonuc = from o in ctx.Doctors
                                where o.doctor_identity_no == Global.userIdentityNo
                                select o;
                    var doctor = sonuc.FirstOrDefault();
                    if (doctor != null)
                    {
                        txtName.Text = doctor?.doctor_name?.ToUpper();
                        txtSurname.Text = doctor?.doctor_surname?.ToUpper();
                        txtIdentityNo.Text = doctor?.doctor_identity_no?.ToUpper();
                        dtpDateOfBirth.Value = doctor.doctor_date_of_birth.GetValueOrDefault();
                        txtBloodGroup.Text = doctor.doctor_blood_group;
                        txtEMail.Text = doctor.doctor_email;
                        txtPhoneNumber.Text = doctor.doctor_phone_number;
                        Global.patientname = doctor.doctor_name;
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            bool hasChanges = false;
            // Kullanıcı adına göre veritabanından ilgili kullanıcıyı alın
            var user = dbContext.Doctors.FirstOrDefault(u => u.doctor_identity_no == txtIdentityNo.Text);

            if (user != null)
            {
                // Eski şifreyi doğrula
                if (VerifyPassword(user, txtOldPassword.Text.Trim()))
                {
                    if (txtEMail.Text != user.doctor_email)
                    {
                        user.doctor_email = txtEMail.Text.Trim();
                    }
                    if (txtPhoneNumber.Text != user.doctor_phone_number)
                    {
                        user.doctor_phone_number = txtPhoneNumber.Text.Trim();
                    }
                    // Yeni şifrelerin eşleştiğini kontrol et
                    // Yeni şifreyi güncelle
                    if (txtNewPassword.Text != string.Empty && txtNewPassword.Text == txtConfirmNewPassword.Text)
                    {
                        user.doctor_password = Methods.Encrypt(txtNewPassword.Text.Trim());
                    }
                    else if (txtNewPassword.Text != txtConfirmNewPassword.Text)
                    {
                        MessageBox.Show("Şifreler Eşleşmiyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasChanges = true;
                    }
                    // Değişiklikleri veritabanına kaydet
                    if (hasChanges == false)
                    {
                        dbContext.SaveChanges();
                        MessageBox.Show("Bilgiler başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var frmDoctor = Application.OpenForms.OfType<frmDoctor>().FirstOrDefault();
                        if (frmDoctor != null)
                        {
                            frmDoctor.btnAccount.PerformClick();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Eski şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool VerifyPassword(Doctor doctor, string password)
        {
            return doctor.doctor_password == Methods.Encrypt(password);
        }
    }
}
