namespace desing
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            rbGenderMale = new System.Windows.Forms.RadioButton();
            rbGenderFemale = new System.Windows.Forms.RadioButton();
            btnRegister = new System.Windows.Forms.Button();
            cbBloodGroup = new System.Windows.Forms.ComboBox();
            dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtEMail = new System.Windows.Forms.TextBox();
            txtIdentityNo = new System.Windows.Forms.TextBox();
            txtSurname = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            pBoxReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Gray;
            label2.Location = new System.Drawing.Point(12, 213);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 20);
            label2.TabIndex = 24;
            label2.Text = "Doğum Tarihi";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(345, 158);
            txtPassword.MaxLength = 30;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new System.Drawing.Size(290, 26);
            txtPassword.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Gray;
            label1.Location = new System.Drawing.Point(345, 215);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 20);
            label1.TabIndex = 22;
            label1.Text = "Kan Grubu";
            // 
            // rbGenderMale
            // 
            rbGenderMale.AutoSize = true;
            rbGenderMale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rbGenderMale.Location = new System.Drawing.Point(12, 280);
            rbGenderMale.Name = "rbGenderMale";
            rbGenderMale.Size = new System.Drawing.Size(69, 24);
            rbGenderMale.TabIndex = 16;
            rbGenderMale.TabStop = true;
            rbGenderMale.Text = "Erkek";
            rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // rbGenderFemale
            // 
            rbGenderFemale.AutoSize = true;
            rbGenderFemale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rbGenderFemale.Location = new System.Drawing.Point(231, 280);
            rbGenderFemale.Name = "rbGenderFemale";
            rbGenderFemale.Size = new System.Drawing.Size(71, 24);
            rbGenderFemale.TabIndex = 17;
            rbGenderFemale.TabStop = true;
            rbGenderFemale.Text = "Kadın";
            rbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.Brown;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegister.ForeColor = System.Drawing.Color.White;
            btnRegister.Location = new System.Drawing.Point(345, 270);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(142, 45);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbBloodGroup
            // 
            cbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbBloodGroup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbBloodGroup.ForeColor = System.Drawing.Color.Black;
            cbBloodGroup.FormattingEnabled = true;
            cbBloodGroup.Items.AddRange(new object[] { "0 RH+", "0 RH -", "A RH +", "A RH - ", "B RH +", "B RH -", "AB RH +", "AB RH -" });
            cbBloodGroup.Location = new System.Drawing.Point(345, 236);
            cbBloodGroup.Name = "cbBloodGroup";
            cbBloodGroup.Size = new System.Drawing.Size(290, 28);
            cbBloodGroup.TabIndex = 18;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpDateOfBirth.Location = new System.Drawing.Point(12, 236);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new System.Drawing.Size(290, 28);
            dtpDateOfBirth.TabIndex = 15;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhoneNumber.Location = new System.Drawing.Point(345, 12);
            txtPhoneNumber.MaxLength = 10;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Telefon Numarası";
            txtPhoneNumber.Size = new System.Drawing.Size(290, 26);
            txtPhoneNumber.TabIndex = 19;
            txtPhoneNumber.Tag = "number";
            txtPhoneNumber.KeyPress += txt_KeyPress;
            // 
            // txtEMail
            // 
            txtEMail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEMail.Location = new System.Drawing.Point(345, 85);
            txtEMail.MaxLength = 70;
            txtEMail.Name = "txtEMail";
            txtEMail.PlaceholderText = "E Posta";
            txtEMail.Size = new System.Drawing.Size(290, 26);
            txtEMail.TabIndex = 20;
            // 
            // txtIdentityNo
            // 
            txtIdentityNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIdentityNo.Location = new System.Drawing.Point(12, 158);
            txtIdentityNo.MaxLength = 11;
            txtIdentityNo.Name = "txtIdentityNo";
            txtIdentityNo.PlaceholderText = "T.C Kimlik No";
            txtIdentityNo.Size = new System.Drawing.Size(290, 26);
            txtIdentityNo.TabIndex = 14;
            txtIdentityNo.Tag = "number";
            txtIdentityNo.UseSystemPasswordChar = true;
            txtIdentityNo.KeyPress += txt_KeyPress;
            // 
            // txtSurname
            // 
            txtSurname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSurname.Location = new System.Drawing.Point(12, 85);
            txtSurname.MaxLength = 30;
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Soyad";
            txtSurname.Size = new System.Drawing.Size(290, 26);
            txtSurname.TabIndex = 13;
            txtSurname.Tag = "letter";
            txtSurname.KeyPress += txt_KeyPress;
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(12, 12);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ad";
            txtName.Size = new System.Drawing.Size(290, 26);
            txtName.TabIndex = 12;
            txtName.Tag = "letter";
            txtName.KeyPress += txt_KeyPress;
            // 
            // pBoxReturn
            // 
            pBoxReturn.Image = (System.Drawing.Image)resources.GetObject("pBoxReturn.Image");
            pBoxReturn.Location = new System.Drawing.Point(493, 270);
            pBoxReturn.Name = "pBoxReturn";
            pBoxReturn.Size = new System.Drawing.Size(142, 45);
            pBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBoxReturn.TabIndex = 25;
            pBoxReturn.TabStop = false;
            pBoxReturn.Click += pBoxReturn_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(647, 327);
            Controls.Add(pBoxReturn);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(rbGenderMale);
            Controls.Add(rbGenderFemale);
            Controls.Add(btnRegister);
            Controls.Add(cbBloodGroup);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEMail);
            Controls.Add(txtIdentityNo);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmRegister";
            Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbGenderMale;
        private System.Windows.Forms.RadioButton rbGenderFemale;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbBloodGroup;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtIdentityNo;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.PictureBox pBoxReturn;
    }
}