using desing.Model;
using Microsoft.Data.SqlClient;
using ServiceReference1;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace desing
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            Form1 frm = new Form1();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> emptyFields = new List<string>();
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    emptyFields.Add("Ad");
                }
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    emptyFields.Add("Soyad");
                }
                if (string.IsNullOrEmpty(txtEMail.Text))
                {
                    emptyFields.Add("E-posta");
                }
                if (txtPhoneNumber.Text.Length != 10)
                {
                    emptyFields.Add("Telefon Numarası");
                }
                if (txtPassword.Text.Length < 5)
                {
                    emptyFields.Add("Şifre");
                }
                if (!Methods.Verification(txtIdentityNo.Text))
                {
                    emptyFields.Add("T.C. Kimlik No");
                }
                if (cbBloodGroup.SelectedIndex == -1)
                {
                    emptyFields.Add("Kan Grubu");
                }
                if (!rbGenderMale.Checked && !rbGenderFemale.Checked)
                {
                    emptyFields.Add("Cinsiyet");
                }
                if (emptyFields.Count > 0)
                {
                    string message = "Lütfen Aşağıdaki Alanları Doğru Şekilde Doldurunuz !\n";
                    foreach (string field in emptyFields)
                    {
                        message += "- " + field + "\n";
                    }

                    MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                    var result = client.TCKimlikNoDogrulaAsync(long.Parse(txtIdentityNo.Text), txtName.Text, txtSurname.Text, dtpDateOfBirth.Value.Date.Year).Result;
                    if (result.Body.TCKimlikNoDogrulaResult)
                    {
                        string gender = rbGenderMale.Checked ? "ERKEK" : rbGenderFemale.Checked ? "KADIN" : "null";
                        using (var ctx = new HospitalContext())
                        {
                            var patient = new Patient { patient_identity_no = txtIdentityNo.Text, patient_name = txtName.Text.Trim(), patient_surname = txtSurname.Text.Trim(), patient_date_of_birth = dtpDateOfBirth.Value, patient_gender = gender, patient_blood_group = cbBloodGroup.Text, patient_email = txtEMail.Text.Trim(), patient_phone_number = txtPhoneNumber.Text, patient_password = Methods.Encrypt(txtPassword.Text.Trim()) };
                            ctx.Patients.Add(patient);
                            int sonuc = ctx.SaveChanges();
                            MessageBox.Show(sonuc > 0 ? "Kayıt Başarılı" : "Kayıt Sırasında Hata Oluştu Lütfen Tekrar Dene :(");
                            if (sonuc > 0)
                            {
                                if (Methods.smallpanel != null)
                                {
                                    Methods.Verification(txtIdentityNo.Text);
                                    frmLogin frm = new frmLogin();
                                    Methods.OpenForms(frm, Methods.smallpanel);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kimlik Doğrulama Başarısız!");
                    }
                    
                }
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException)
            {
                MessageBox.Show("Girilen Bilgilerle Mevcut Bir Kayıt Zaten Var!");
            }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb != null && tb.Tag is string)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (string)tb.Tag == "number")
                {
                    e.Handled = true;
                }
                else if (!char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsLetter(e.KeyChar) && (string)tb.Tag == "letter")
                {
                    e.Handled = true;
                }
            }
        }

        private void pBoxReturn_Click(object sender, EventArgs e)
        {
            if (Methods.smallpanel != null)
            {
                frmLogin frm = new frmLogin();
                Methods.OpenForms(frm, Methods.smallpanel);
            }
        }
    }
}

