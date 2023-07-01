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
    public partial class frmPasswordReset : Form
    {
        public frmPasswordReset()
        {
            InitializeComponent();
            txtIdentityNo.Text = Global.userIdentityNo;
            txtPhoneNumber.Text = Global.userPhoneNumber;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button)
                {
                    if (Methods.smallpanel != null)
                    {
                        using (var ctx = new HospitalContext())
                        {
                            var sonuc = from o in ctx.Users
                                        where o.user_identity_no == txtIdentityNo.Text
                                        where o.user_phone_number == txtPhoneNumber.Text
                                        select o;
                            var user = sonuc.FirstOrDefault();
                            if (user != null)
                            {
                                if (user.user_email != null)
                                {
                                    Global.usermail = user.user_email;
                                }
                                Global.userIdentityNo = txtIdentityNo.Text;
                                Global.userPhoneNumber = txtPhoneNumber.Text;
                                frmPasswordChangeVerification passwordChangeVerification = new frmPasswordChangeVerification();
                                Methods.OpenForms(passwordChangeVerification, Methods.smallpanel);
                            }
                            else
                            {
                                MessageBox.Show("Böyle Bir Kayıt Bulunamadı!");
                            }
                        }
                        
                    }
                }

                else if (sender is PictureBox)
                {
                    if (Methods.smallpanel != null)
                    {
                        frmLogin frm = new frmLogin();
                        Methods.OpenForms(frm, Methods.smallpanel);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
