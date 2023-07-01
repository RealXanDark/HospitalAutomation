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
    public partial class frmLabUser : Form
    {
        public frmLabUser()
        {
            InitializeComponent();
            FormLoad();
        }
        private void FormLoad()
        {
            try
            {
                using (var ctx = new HospitalContext())
                {
                    var sonuc = from o in ctx.Labs
                                where o.lab_identity_no == Global.userIdentityNo
                                select o;
                    var lab = sonuc.FirstOrDefault();
                    if (lab != null)
                    {
                        txtName.Text = lab?.lab_name?.ToUpper();
                        txtSurname.Text = lab?.lab_surname?.ToUpper();
                        txtIdentityNo.Text = lab?.lab_identity_no?.ToUpper();
                        dtpDateOfBirth.Value = lab?.lab_date_of_birth ?? DateTime.MinValue;
                        txtBloodGroup.Text = lab?.lab_blood_group;
                        txtEMail.Text = lab?.lab_email;
                        txtPhoneNumber.Text = lab?.lab_phone_number;
                        Global.patientname = lab?.lab_name;
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
