using desing.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace desing
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Init_Data();
        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.IdentityNo != string.Empty)
            {
                txtIdentityNo.Text = Properties.Settings.Default.IdentityNo.ToString();
                txtPassword.Text = Properties.Settings.Default.Password.ToString();
                cbRememberMe.Checked = true;
            }
        }
        private void Save_Data()
        {
            if (cbRememberMe.Checked)
            {
                Properties.Settings.Default.IdentityNo = txtIdentityNo.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Checked = true;
                Properties.Settings.Default.Save();
            }
            else if (cbRememberMe.Checked == false)
            {
                Properties.Settings.Default.IdentityNo = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Checked = false;
                Properties.Settings.Default.Save();
            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button)
                {
                    Button btn = (Button)sender;
                    if (btn.Name == "btnLogin" && Methods.bigpanel != null && txtIdentityNo.Text.Length == 11)
                    {
                        using (var context = new HospitalContext())
                        {
                            var user = context.Users.FirstOrDefault(u => u.user_identity_no == txtIdentityNo.Text.Trim() && u.user_password == Methods.Encrypt(txtPassword.Text));
                            if (user != null)
                            {
                                Global.patientidentityno = txtIdentityNo.Text;
                                Global.userIdentityNo = txtIdentityNo.Text;
                                if (user.user_group_id == 0)
                                {
                                    frmAdmin admin = new frmAdmin();
                                    Methods.OpenForms(admin, Methods.bigpanel);
                                    Save_Data();
                                }
                                else if (user.user_group_id == 1)
                                {
                                    frmDoctor doctor = new frmDoctor();
                                    Methods.OpenForms(doctor, Methods.bigpanel);
                                    Save_Data();
                                }
                                else if (user.user_group_id == 2)
                                {
                                    frmLaboratory laboratory = new frmLaboratory();
                                    Methods.OpenForms(laboratory, Methods.bigpanel);
                                    Save_Data();
                                }
                                else if (user.user_group_id == 3)
                                {
                                    frmHasta hasta = new frmHasta();
                                    Methods.OpenForms(hasta, Methods.bigpanel);
                                    Save_Data();
                                }
                                else
                                {
                                    MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Dene :(");
                                }
                            }
                            else if (user == null)
                            {
                                lblInformation.Visible = true;
                            }
                        }
                    }
                }
                else if (sender is Label)
                {
                    Label lbl = (Label)sender;
                    if (lbl == lblForgetPassword && Methods.smallpanel != null)
                    {
                        frmPasswordReset passwordReset = new frmPasswordReset();
                        Methods.OpenForms(passwordReset, Methods.smallpanel);
                    }
                    else if (lbl.Name == "lblRegister" && Methods.smallpanel != null)
                    {
                        frmRegister frm = new frmRegister();
                        Methods.OpenForms(frm, Methods.smallpanel);
                    }
                }
                else if (sender is PictureBox)
                {
                    if (Methods.smallpanel != null)
                    {
                        frmRegister frm = new frmRegister();
                        Methods.OpenForms(frm, Methods.smallpanel);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Dene :(");
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txtIdentityNo.Text != String.Empty || txtPassword.Text != String.Empty)
            {
                lblInformation.Visible = false;
            }
        }
    }
}
