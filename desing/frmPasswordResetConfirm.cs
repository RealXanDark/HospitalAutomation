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
    public partial class frmPasswordResetConfirm : Form
    {
        public frmPasswordResetConfirm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button)
                {
                    if (txtNewPassword.Text == txtConfirmNewPassword.Text && txtNewPassword.Text != String.Empty && txtConfirmNewPassword.Text != String.Empty)
                    {
                        using (var context = new HospitalContext())
                        {
                            var user = context.Users.FirstOrDefault(u => u.user_identity_no == Global.userIdentityNo); 

                            if (user != null)
                            {
                                user.user_password = Methods.Encrypt(txtNewPassword.Text.Trim()); 
                                context.SaveChanges();
                            }
                            else
                            {
                                Console.WriteLine("Kullanıcı bulunamadı.");
                            }
                        }
                        MessageBox.Show("Şifreniz Başarıyla Güncellendi!");
                        if (Methods.smallpanel != null)
                        {
                            frmLogin frm = new frmLogin();
                            Methods.OpenForms(frm, Methods.smallpanel);
                        }
                    }
                    else if (txtNewPassword.Text == String.Empty || txtConfirmNewPassword.Text == String.Empty)
                    {
                        lblInformation.Text = "Şifreler Boş Geçilemez";
                        lblInformation.Visible = true;
                    }
                    else if (txtNewPassword.Text != txtConfirmNewPassword.Text)
                    {
                        lblInformation.Text = "Girilen Şifreler Aynı Değil";
                        lblInformation.Visible = true;
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

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != String.Empty)
            {
                lblInformation.Visible = false;
            }
        }

    }
}
