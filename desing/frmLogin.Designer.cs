namespace desing
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtIdentityNo = new System.Windows.Forms.TextBox();
            lblRegister = new System.Windows.Forms.Label();
            lblForgetPassword = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnLogin = new System.Windows.Forms.Button();
            txtPassword = new System.Windows.Forms.TextBox();
            cbRememberMe = new System.Windows.Forms.CheckBox();
            lblInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtIdentityNo
            // 
            txtIdentityNo.BackColor = System.Drawing.Color.White;
            txtIdentityNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIdentityNo.Location = new System.Drawing.Point(10, 93);
            txtIdentityNo.MaxLength = 11;
            txtIdentityNo.Name = "txtIdentityNo";
            txtIdentityNo.PlaceholderText = "T.C. Kimlik No";
            txtIdentityNo.Size = new System.Drawing.Size(627, 26);
            txtIdentityNo.TabIndex = 17;
            txtIdentityNo.UseSystemPasswordChar = true;
            txtIdentityNo.TextChanged += txt_TextChanged;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = System.Drawing.Color.Transparent;
            lblRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRegister.ForeColor = System.Drawing.Color.FromArgb(88, 169, 255);
            lblRegister.Location = new System.Drawing.Point(294, 220);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new System.Drawing.Size(58, 20);
            lblRegister.TabIndex = 22;
            lblRegister.Text = "Üye Ol";
            lblRegister.Click += login_Click;
            // 
            // lblForgetPassword
            // 
            lblForgetPassword.AutoSize = true;
            lblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            lblForgetPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblForgetPassword.ForeColor = System.Drawing.Color.FromArgb(88, 169, 255);
            lblForgetPassword.Location = new System.Drawing.Point(500, 156);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Size = new System.Drawing.Size(137, 20);
            lblForgetPassword.TabIndex = 20;
            lblForgetPassword.Text = "Parolamı Unuttum";
            lblForgetPassword.Click += login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(358, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(20, 20);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += login_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.Brown;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(10, 185);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(625, 32);
            btnLogin.TabIndex = 19;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += login_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.White;
            txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(10, 125);
            txtPassword.MaxLength = 30;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new System.Drawing.Size(627, 26);
            txtPassword.TabIndex = 18;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txt_TextChanged;
            // 
            // cbRememberMe
            // 
            cbRememberMe.AutoSize = true;
            cbRememberMe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbRememberMe.Location = new System.Drawing.Point(10, 155);
            cbRememberMe.Name = "cbRememberMe";
            cbRememberMe.Size = new System.Drawing.Size(112, 24);
            cbRememberMe.TabIndex = 21;
            cbRememberMe.Text = "Beni Hatırla";
            cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.ForeColor = System.Drawing.Color.Brown;
            lblInformation.Location = new System.Drawing.Point(10, 70);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new System.Drawing.Size(202, 20);
            lblInformation.TabIndex = 24;
            lblInformation.Text = "Kullanıcı Adı Veya Şifre Yanlış";
            lblInformation.Visible = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(647, 327);
            Controls.Add(lblInformation);
            Controls.Add(txtIdentityNo);
            Controls.Add(lblRegister);
            Controls.Add(lblForgetPassword);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(cbRememberMe);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentityNo;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblForgetPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private System.Windows.Forms.Label lblInformation;
    }
}