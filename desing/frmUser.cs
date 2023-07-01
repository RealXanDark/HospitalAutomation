using desing.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desing
{
    public partial class frmUser : Form
    {
        private HospitalContext dbContext;
        public frmUser()
        {
            InitializeComponent();
            dbContext = new HospitalContext();
            FormLoad();
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            bool hasChanges = false;
            var user = dbContext.Patients.FirstOrDefault(u => u.patient_identity_no == txtIdentityNo.Text);

            if (user != null)
            {
                if (VerifyPassword(user, txtOldPassword.Text.Trim()))
                {
                   
                    if (txtEMail.Text != user.patient_email)
                    {
                        user.patient_email = txtEMail.Text.Trim();
                    }
                    if (txtPhoneNumber.Text != user.patient_phone_number)
                    {
                        user.patient_phone_number = txtPhoneNumber.Text.Trim();
                    }
                    if (txtNewPassword.Text != string.Empty && txtNewPassword.Text == txtConfirmNewPassword.Text)
                    {
                        user.patient_password = Methods.Encrypt(txtNewPassword.Text.Trim());
                    }
                    else if (txtNewPassword.Text != txtConfirmNewPassword.Text)
                    {
                        MessageBox.Show("Şifreler Eşleşmiyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasChanges = true;
                    }
                    if (hasChanges == false)
                    {
                        dbContext.SaveChanges();
                        MessageBox.Show("Bilgiler başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var frmHasta = Application.OpenForms.OfType<frmHasta>().FirstOrDefault();
                        if (frmHasta != null)
                        {
                            frmHasta.btnAccount.PerformClick();
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
                        txtName.Text = patient?.patient_name?.ToUpper();
                        txtSurname.Text = patient?.patient_surname?.ToUpper();
                        txtIdentityNo.Text = patient?.patient_identity_no?.ToUpper();
                        dtpDateOfBirth.Value = patient?.patient_date_of_birth.GetValueOrDefault() ?? DateTime.MinValue;
                        txtBloodGroup.Text = patient?.patient_blood_group;
                        txtEMail.Text = patient?.patient_email;
                        txtPhoneNumber.Text = patient?.patient_phone_number;
                        Global.patientname = patient?.patient_name;
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
        private bool VerifyPassword(Patient patient, string password)
        {
            return patient.patient_password == Methods.Encrypt(password);
        }
    }
}
