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
    public partial class frmPasswordChangeVerification : Form
    {
        byte time = 120;
        public frmPasswordChangeVerification()
        {
            InitializeComponent();
            tmrVerification.Start();
            if (Global.usermail != null)
            {
                Task.Run(() => SendMail.Microsoft(Global.usermail));
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button)
                {
                    if (Global.verificationCode == txtVerificationCode.Text)
                    {
                        if (Methods.smallpanel != null)
                        {
                            frmPasswordResetConfirm passwordResetConfirm = new frmPasswordResetConfirm();
                            Methods.OpenForms(passwordResetConfirm, Methods.smallpanel);
                        }
                    }
                    else if (Global.verificationCode != txtVerificationCode.Text)
                    {
                        txtVerificationCode.Text = String.Empty;
                        lblFalseCode.Visible = true;
                    }

                }
                else if (sender is PictureBox)
                {
                    if (Methods.smallpanel != null)
                    {
                        frmPasswordReset passwordReset = new frmPasswordReset();
                        Methods.OpenForms(passwordReset, Methods.smallpanel);
                    }
                }
                else if (sender is Label)
                {
                    time = 120;
                    tmrVerification.Start();
                    lblResendVerificationCode.Enabled = false;
                    if (Global.usermail != null)
                    {
                        SendMail.Microsoft(Global.usermail);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void tmrVerification_Tick(object sender, EventArgs e)
        {
            time--;
            lblRemainingTime.Text = "Kalan Süre : " + TimeSpan.FromSeconds(time).ToString(@"mm\:ss");
            if (time == 0)
            {
                tmrVerification.Stop();
                lblResendVerificationCode.Enabled = true;
            }
        }

        private void txtVerificationCode_TextChanged(object sender, EventArgs e)
        {
            if (txtVerificationCode.Text != String.Empty)
            {
                lblFalseCode.Visible = false;
            }
        }
    }
}
