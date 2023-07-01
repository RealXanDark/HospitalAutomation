namespace desing
{
    partial class frmPasswordResetConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordResetConfirm));
            pBoxReturn = new System.Windows.Forms.PictureBox();
            txtNewPassword = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            lblInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).BeginInit();
            SuspendLayout();
            // 
            // pBoxReturn
            // 
            pBoxReturn.Image = (System.Drawing.Image)resources.GetObject("pBoxReturn.Image");
            pBoxReturn.Location = new System.Drawing.Point(578, 185);
            pBoxReturn.Name = "pBoxReturn";
            pBoxReturn.Size = new System.Drawing.Size(59, 32);
            pBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBoxReturn.TabIndex = 34;
            pBoxReturn.TabStop = false;
            pBoxReturn.Click += btn_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = System.Drawing.Color.White;
            txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNewPassword.Location = new System.Drawing.Point(10, 93);
            txtNewPassword.MaxLength = 11;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Yeni Şifre";
            txtNewPassword.Size = new System.Drawing.Size(627, 26);
            txtNewPassword.TabIndex = 31;
            txtNewPassword.TextChanged += txt_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Brown;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(10, 185);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(559, 32);
            btnSave.TabIndex = 33;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btn_Click;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.BackColor = System.Drawing.Color.White;
            txtConfirmNewPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtConfirmNewPassword.Location = new System.Drawing.Point(10, 125);
            txtConfirmNewPassword.MaxLength = 30;
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PlaceholderText = "Yeni Şifre (Tekrar)";
            txtConfirmNewPassword.Size = new System.Drawing.Size(627, 26);
            txtConfirmNewPassword.TabIndex = 32;
            txtConfirmNewPassword.TextChanged += txt_TextChanged;
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.ForeColor = System.Drawing.Color.Brown;
            lblInformation.Location = new System.Drawing.Point(10, 154);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new System.Drawing.Size(177, 20);
            lblInformation.TabIndex = 35;
            lblInformation.Text = "Girilen Şifreler Eşleşmiyor";
            lblInformation.Visible = false;
            // 
            // frmPasswordResetConfirm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(647, 327);
            Controls.Add(lblInformation);
            Controls.Add(pBoxReturn);
            Controls.Add(txtNewPassword);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmNewPassword);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmPasswordResetConfirm";
            Text = "frmPasswordResetConfirm";
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.PictureBox pBoxReturn;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label lblInformation;
    }
}