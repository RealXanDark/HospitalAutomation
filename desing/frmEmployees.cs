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
    public partial class frmEmployees : Form
    {
        string? identity;
        //string? nurseidentity;
        //string? labidentity;
        //string? employeeidentity;
        string? lastbutton;
        public frmEmployees()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Methods.ChangeButtonColorInForm(this, btn);
            if (btn == btnDoctors)
            {
                lastbutton = "doctor";
                lblInformation.Text = "Doktor Düzenleme Modu";
                pnlGrades.Visible = true;
                LoadDoctor();
            }
            else if (btn == btnNurses)
            {
                lastbutton = "nurse";
                lblInformation.Text = "Hemşire Düzenleme Modu";
                using (var db = new HospitalContext())
                {
                    var doctors = db.Nurses.ToList();
                    dgwEmployees.DataSource = doctors;
                }
                pnlGrades.Visible = false;
            }
            else if (btn == btnLaborant)
            {
                lastbutton = "lab";
                lblInformation.Text = "Laborant Düzenleme Modu";
                using (var db = new HospitalContext())
                {
                    var doctors = db.Labs.ToList();
                    dgwEmployees.DataSource = doctors;
                }
                pnlGrades.Visible = false;
            }
            else if (btn == btnOtherEmployees)
            {
                lastbutton = "employee";
                lblInformation.Text = "Diğer Çalışan Düzenleme Modu";
                using (var db = new HospitalContext())
                {
                    var doctors = db.Employees.ToList();
                    dgwEmployees.DataSource = doctors;
                }
                pnlGrades.Visible = false;
            }
            else if (btn == btnUpdate)
            {
                if (lastbutton == "doctor")
                {
                    using (var context = new HospitalContext()) // DbContext sınıfının bir örneğini oluşturun
                    {
                        string gender = rbGenderMale.Checked ? "ERKEK" : rbGenderFemale.Checked ? "KADIN" : "null";
                        string specialization = rbUzDr.Checked ? "Uz. DR." : rbYardDocDr.Checked ? "Yrd. Doç. DR." : rbDocDr.Checked ? "Doç. DR." : rbProfDr.Checked ? "Prof. DR." : "null";
                        var doctor = context.Doctors.FirstOrDefault(d => d.doctor_identity_no == identity);

                        if (doctor != null)
                        {
                            // Verileri güncelle
                            doctor.doctor_identity_no = txtIdentityNo.Text;
                            doctor.doctor_name = txtName.Text;
                            doctor.doctor_surname = txtSurname.Text;
                            doctor.doctor_date_of_birth = dtpDateOfBirth.Value;
                            doctor.doctor_gender = gender;
                            doctor.doctor_blood_group = cbBloodGroup.Text;
                            doctor.doctor_email = txtEMail.Text;
                            doctor.doctor_phone_number = txtPhoneNumber.Text;
                            doctor.doctor_password = Methods.Encrypt(txtPassword.Text);
                            doctor.doctor_specialization_name = specialization;
                            context.SaveChanges(); // Değişiklikleri kaydet
                            MessageBox.Show("Doktor kaydı başarıyla güncellendi.");
                            btnDoctors.PerformClick();
                        }
                    }
                }
                else if (lastbutton == "nurse")
                {
                    using (var context = new HospitalContext())
                    {
                        string gender = rbGenderMale.Checked ? "ERKEK" : rbGenderFemale.Checked ? "KADIN" : "null";
                        var nurse = context.Nurses.FirstOrDefault(n => n.nurse_identity_no == identity);

                        if (nurse != null)
                        {
                            // Verileri güncelle
                            nurse.nurse_identity_no = txtIdentityNo.Text;
                            nurse.nurse_name = txtName.Text;
                            nurse.nurse_surname = txtSurname.Text;
                            nurse.nurse_date_of_birth = dtpDateOfBirth.Value;
                            nurse.nurse_gender = gender;
                            nurse.nurse_blood_group = cbBloodGroup.Text;
                            nurse.nurse_email = txtEMail.Text;
                            nurse.nurse_phone_number = txtPhoneNumber.Text;
                            nurse.nurse_password = Methods.Encrypt(txtPassword.Text);
                            context.SaveChanges();
                            MessageBox.Show("Hemşire kaydı başarıyla güncellendi.");
                            btnNurses.PerformClick();
                        }
                    }
                }
                else if (lastbutton == "lab")
                {
                    using (var context = new HospitalContext())
                    {
                        string gender = rbGenderMale.Checked ? "ERKEK" : rbGenderFemale.Checked ? "KADIN" : "null";
                        var lab = context.Labs.FirstOrDefault(l => l.lab_identity_no == identity);

                        if (lab != null)
                        {
                            // Verileri güncelle
                            lab.lab_identity_no = txtIdentityNo.Text;
                            lab.lab_name = txtName.Text;
                            lab.lab_surname = txtSurname.Text;
                            lab.lab_date_of_birth = dtpDateOfBirth.Value;
                            lab.lab_gender = gender;
                            lab.lab_blood_group = cbBloodGroup.Text;
                            lab.lab_email = txtEMail.Text;
                            lab.lab_phone_number = txtPhoneNumber.Text;
                            lab.lab_password = Methods.Encrypt(txtPassword.Text);
                            context.SaveChanges();
                            MessageBox.Show("Laborant kaydı başarıyla güncellendi.");
                            btnLaborant.PerformClick();
                        }
                    }
                }
                else if (lastbutton == "employee")
                {
                    using (var context = new HospitalContext())
                    {
                        string gender = rbGenderMale.Checked ? "ERKEK" : rbGenderFemale.Checked ? "KADIN" : "null";
                        var employee = context.Employees.FirstOrDefault(e => e.employee_identity_no == identity);

                        if (employee != null)
                        {
                            // Verileri güncelle
                            employee.employee_identity_no = txtIdentityNo.Text;
                            employee.employee_name = txtName.Text;
                            employee.employee_surname = txtSurname.Text;
                            employee.employee_date_of_birth = dtpDateOfBirth.Value;
                            employee.employee_gender = gender;
                            employee.employee_blood_group = cbBloodGroup.Text;
                            employee.employee_email = txtEMail.Text;
                            employee.employee_phone_number = txtPhoneNumber.Text;
                            employee.employee_password = Methods.Encrypt(txtPassword.Text);
                            context.SaveChanges();
                            MessageBox.Show("Diğer çalışan kaydı başarıyla güncellendi.");
                            btnOtherEmployees.PerformClick();
                        }
                    }
                }

            }
            else if (btn == btnDelete)
            {
                using (var context = new HospitalContext()) // DbContext sınıfının bir örneğini oluşturun
                {
                    var doctor = context.Doctors.FirstOrDefault(d => d.doctor_identity_no == txtIdentityNo.Text);

                    if (doctor != null)
                    {
                        DialogResult result = MessageBox.Show("Doktor kaydını silmek istediğinize emin misiniz?", "Doktor Silme", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            context.Doctors.Remove(doctor); // Doktoru sil
                            context.SaveChanges(); // Değişiklikleri kaydet

                            MessageBox.Show("Doktor kaydı başarıyla silindi.");
                            LoadDoctor();
                        }
                    }
                }
            }
        }

        private void dgwEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır tıklandığında
            {
                if (lastbutton != null)
                {
                    DataGridViewRow row = dgwEmployees.Rows[e.RowIndex];
                    txtName.Text = row.Cells[$"{lastbutton}_name"].Value.ToString();
                    txtSurname.Text = row.Cells[$"{lastbutton}_surname"].Value.ToString();
                    txtIdentityNo.Text = row.Cells[$"{lastbutton}_identity_no"].Value.ToString();
                    identity = row.Cells[$"{lastbutton}_identity_no"].Value.ToString();
                    dtpDateOfBirth.Text = row.Cells[$"{lastbutton}_date_of_birth"].Value.ToString();
                    string gender = row.Cells[$"{lastbutton}_gender"].Value?.ToString() ?? string.Empty;
                    if (lastbutton == "doctor")
                    {
                        string specialization = row.Cells[$"{lastbutton}_specialization_name"].Value.ToString() ?? string.Empty;
                        if (specialization == "Uz. DR.")
                        {
                            rbUzDr.Checked = true;
                        }
                        else if (specialization == "Yrd. Doç. DR.")
                        {
                            rbYardDocDr.Checked = true;
                        }
                        else if (specialization == "Doç. DR.")
                        {
                            rbDocDr.Checked = true;
                        }
                        else if (specialization == "Prof. DR.")
                        {
                            rbProfDr.Checked = true;
                        }
                    }

                    // Cinsiyet
                    if (gender == "ERKEK")
                    {
                        rbGenderMale.Checked = true;
                    }
                    else if (gender == "KADIN")
                    {
                        rbGenderFemale.Checked = true;
                    }
                    txtPhoneNumber.Text = row.Cells[$"{lastbutton}_phone_number"].Value.ToString();
                    txtEMail.Text = row.Cells[$"{lastbutton}_email"].Value.ToString();
                    txtPassword.Text = Methods.Decrypt(row.Cells[$"{lastbutton}_password"].Value?.ToString() ?? string.Empty);
                    cbBloodGroup.Text = row.Cells[$"{lastbutton}_blood_group"].Value.ToString();
                    // vb. diğer TextBox'ları güncelleyebilirsiniz
                }
                //else if (lastbutton == "nurse")
                //{
                //    DataGridViewRow row = dgwEmployees.Rows[e.RowIndex];
                //    txtName.Text = row.Cells["nurse_name"].Value.ToString();
                //    txtSurname.Text = row.Cells["nurse_surname"].Value.ToString();
                //    txtIdentityNo.Text = row.Cells["nurse_identity_no"].Value.ToString();
                //    nurseidentity = row.Cells["nurse_identity_no"].Value.ToString();
                //    dtpDateOfBirth.Text = row.Cells["nurse_date_of_birth"].Value.ToString();
                //    string gender = row.Cells["nurse_gender"].Value.ToString();

                //    // Cinsiyet
                //    if (gender == "ERKEK")
                //    {
                //        rbGenderMale.Checked = true;
                //    }
                //    else if (gender == "KADIN")
                //    {
                //        rbGenderFemale.Checked = true;
                //    }

                //    txtPhoneNumber.Text = row.Cells["nurse_phone_number"].Value.ToString();
                //    txtEMail.Text = row.Cells["nurse_email"].Value.ToString();
                //    txtPassword.Text = Methods.Decrypt(row.Cells["nurse_password"].Value.ToString());
                //    cbBloodGroup.Text = row.Cells["nurse_blood_group"].Value.ToString();
                //}
                //else if (lastbutton == "lab")
                //{
                //    DataGridViewRow row = dgwEmployees.Rows[e.RowIndex];
                //    txtName.Text = row.Cells["lab_name"].Value.ToString();
                //    txtSurname.Text = row.Cells["lab_surname"].Value.ToString();
                //    txtIdentityNo.Text = row.Cells["lab_identity_no"].Value.ToString();
                //    labidentity = row.Cells["lab_identity_no"].Value.ToString();
                //    dtpDateOfBirth.Text = row.Cells["lab_date_of_birth"].Value.ToString();
                //    string gender = row.Cells["lab_gender"].Value.ToString();

                //    // Cinsiyet
                //    if (gender == "ERKEK")
                //    {
                //        rbGenderMale.Checked = true;
                //    }
                //    else if (gender == "KADIN")
                //    {
                //        rbGenderFemale.Checked = true;
                //    }

                //    txtPhoneNumber.Text = row.Cells["lab_phone_number"].Value.ToString();
                //    txtEMail.Text = row.Cells["lab_email"].Value.ToString();
                //    txtPassword.Text = Methods.Decrypt(row.Cells["lab_password"].Value.ToString());
                //    cbBloodGroup.Text = row.Cells["lab_blood_group"].Value.ToString();

                //}
                //else if (lastbutton == "employee")
                //{
                //    DataGridViewRow row = dgwEmployees.Rows[e.RowIndex];
                //    txtName.Text = row.Cells["employee_name"].Value.ToString();
                //    txtSurname.Text = row.Cells["employee_surname"].Value.ToString();
                //    txtIdentityNo.Text = row.Cells["employee_identity_no"].Value.ToString();
                //    employeeidentity = row.Cells["employee_identity_no"].Value.ToString();
                //    dtpDateOfBirth.Text = row.Cells["employee_date_of_birth"].Value.ToString();
                //    string gender = row.Cells["employee_gender"].Value.ToString();

                //    // Cinsiyet
                //    if (gender == "ERKEK")
                //    {
                //        rbGenderMale.Checked = true;
                //    }
                //    else if (gender == "KADIN")
                //    {
                //        rbGenderFemale.Checked = true;
                //    }

                //    txtPhoneNumber.Text = row.Cells["employee_phone_number"].Value.ToString();
                //    txtEMail.Text = row.Cells["employee_email"].Value.ToString();
                //    txtPassword.Text = Methods.Decrypt(row.Cells["employee_password"].Value.ToString());
                //    cbBloodGroup.Text = row.Cells["employee_blood_group"].Value.ToString();

                //}

            }
        }
        private void LoadDoctor()
        {
            using (var db = new HospitalContext())
            {
                var doctors = db.Doctors.ToList();
                dgwEmployees.DataSource = doctors;
            }
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            btnDoctors.PerformClick();
        }
    }
}
