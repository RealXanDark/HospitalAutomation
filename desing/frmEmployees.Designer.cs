namespace desing
{
    partial class frmEmployees
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
            rbGenderMale = new System.Windows.Forms.RadioButton();
            rbGenderFemale = new System.Windows.Forms.RadioButton();
            btnNurses = new System.Windows.Forms.Button();
            btnDoctors = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cbBloodGroup = new System.Windows.Forms.ComboBox();
            dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtEMail = new System.Windows.Forms.TextBox();
            txtIdentityNo = new System.Windows.Forms.TextBox();
            txtSurname = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            dgwEmployees = new System.Windows.Forms.DataGridView();
            btnOtherEmployees = new System.Windows.Forms.Button();
            btnLaborant = new System.Windows.Forms.Button();
            rbProfDr = new System.Windows.Forms.RadioButton();
            rbDocDr = new System.Windows.Forms.RadioButton();
            rbYardDocDr = new System.Windows.Forms.RadioButton();
            rbUzDr = new System.Windows.Forms.RadioButton();
            pnlGrades = new System.Windows.Forms.Panel();
            lblInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgwEmployees).BeginInit();
            pnlGrades.SuspendLayout();
            SuspendLayout();
            // 
            // rbGenderMale
            // 
            rbGenderMale.AutoSize = true;
            rbGenderMale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rbGenderMale.Location = new System.Drawing.Point(753, 200);
            rbGenderMale.Name = "rbGenderMale";
            rbGenderMale.Size = new System.Drawing.Size(69, 24);
            rbGenderMale.TabIndex = 77;
            rbGenderMale.TabStop = true;
            rbGenderMale.Text = "Erkek";
            rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // rbGenderFemale
            // 
            rbGenderFemale.AutoSize = true;
            rbGenderFemale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rbGenderFemale.Location = new System.Drawing.Point(1083, 200);
            rbGenderFemale.Name = "rbGenderFemale";
            rbGenderFemale.Size = new System.Drawing.Size(71, 24);
            rbGenderFemale.TabIndex = 78;
            rbGenderFemale.TabStop = true;
            rbGenderFemale.Text = "Kadın";
            rbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // btnNurses
            // 
            btnNurses.BackColor = System.Drawing.Color.Brown;
            btnNurses.FlatAppearance.BorderSize = 0;
            btnNurses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNurses.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNurses.ForeColor = System.Drawing.Color.White;
            btnNurses.Location = new System.Drawing.Point(197, 12);
            btnNurses.Name = "btnNurses";
            btnNurses.Size = new System.Drawing.Size(179, 32);
            btnNurses.TabIndex = 76;
            btnNurses.Text = "Hemşireler";
            btnNurses.UseVisualStyleBackColor = false;
            btnNurses.Click += btn_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = System.Drawing.Color.Brown;
            btnDoctors.FlatAppearance.BorderSize = 0;
            btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDoctors.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDoctors.ForeColor = System.Drawing.Color.White;
            btnDoctors.Location = new System.Drawing.Point(12, 12);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new System.Drawing.Size(179, 32);
            btnDoctors.TabIndex = 75;
            btnDoctors.Text = "Doktorlar";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btn_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Brown;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(752, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(198, 32);
            btnDelete.TabIndex = 74;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btn_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.Brown;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(956, 405);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(198, 32);
            btnUpdate.TabIndex = 73;
            btnUpdate.Text = "Güncelle/Kaydet";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Gray;
            label2.Location = new System.Drawing.Point(752, 143);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 20);
            label2.TabIndex = 72;
            label2.Text = "Doğum Tarihi";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(753, 294);
            txtPassword.MaxLength = 30;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new System.Drawing.Size(402, 26);
            txtPassword.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Gray;
            label1.Location = new System.Drawing.Point(753, 348);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 20);
            label1.TabIndex = 71;
            label1.Text = "Kan Grubu";
            // 
            // cbBloodGroup
            // 
            cbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbBloodGroup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbBloodGroup.ForeColor = System.Drawing.Color.Black;
            cbBloodGroup.FormattingEnabled = true;
            cbBloodGroup.Items.AddRange(new object[] { "0 RH +", "0 RH -", "A RH +", "A RH - ", "B RH +", "B RH -", "AB RH +", "AB RH -" });
            cbBloodGroup.Location = new System.Drawing.Point(753, 371);
            cbBloodGroup.Name = "cbBloodGroup";
            cbBloodGroup.Size = new System.Drawing.Size(402, 28);
            cbBloodGroup.TabIndex = 67;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpDateOfBirth.Location = new System.Drawing.Point(753, 166);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new System.Drawing.Size(401, 28);
            dtpDateOfBirth.TabIndex = 66;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhoneNumber.Location = new System.Drawing.Point(753, 230);
            txtPhoneNumber.MaxLength = 10;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Telefon Numarası";
            txtPhoneNumber.Size = new System.Drawing.Size(402, 26);
            txtPhoneNumber.TabIndex = 68;
            txtPhoneNumber.Tag = "number";
            // 
            // txtEMail
            // 
            txtEMail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEMail.Location = new System.Drawing.Point(753, 262);
            txtEMail.MaxLength = 70;
            txtEMail.Name = "txtEMail";
            txtEMail.PlaceholderText = "E Posta";
            txtEMail.Size = new System.Drawing.Size(402, 26);
            txtEMail.TabIndex = 69;
            // 
            // txtIdentityNo
            // 
            txtIdentityNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIdentityNo.Location = new System.Drawing.Point(753, 114);
            txtIdentityNo.MaxLength = 11;
            txtIdentityNo.Name = "txtIdentityNo";
            txtIdentityNo.PlaceholderText = "T.C Kimlik No";
            txtIdentityNo.Size = new System.Drawing.Size(402, 26);
            txtIdentityNo.TabIndex = 65;
            txtIdentityNo.Tag = "number";
            // 
            // txtSurname
            // 
            txtSurname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSurname.Location = new System.Drawing.Point(752, 82);
            txtSurname.MaxLength = 30;
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Soyad";
            txtSurname.Size = new System.Drawing.Size(402, 26);
            txtSurname.TabIndex = 64;
            txtSurname.Tag = "letter";
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(753, 50);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ad";
            txtName.Size = new System.Drawing.Size(402, 26);
            txtName.TabIndex = 63;
            txtName.Tag = "letter";
            // 
            // dgwEmployees
            // 
            dgwEmployees.AllowUserToAddRows = false;
            dgwEmployees.AllowUserToDeleteRows = false;
            dgwEmployees.BackgroundColor = System.Drawing.Color.White;
            dgwEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEmployees.Location = new System.Drawing.Point(12, 50);
            dgwEmployees.Name = "dgwEmployees";
            dgwEmployees.ReadOnly = true;
            dgwEmployees.RowHeadersWidth = 51;
            dgwEmployees.RowTemplate.Height = 29;
            dgwEmployees.Size = new System.Drawing.Size(735, 387);
            dgwEmployees.TabIndex = 62;
            dgwEmployees.CellClick += dgwEmployees_CellClick;
            // 
            // btnOtherEmployees
            // 
            btnOtherEmployees.BackColor = System.Drawing.Color.Brown;
            btnOtherEmployees.FlatAppearance.BorderSize = 0;
            btnOtherEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOtherEmployees.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOtherEmployees.ForeColor = System.Drawing.Color.White;
            btnOtherEmployees.Location = new System.Drawing.Point(568, 12);
            btnOtherEmployees.Name = "btnOtherEmployees";
            btnOtherEmployees.Size = new System.Drawing.Size(179, 32);
            btnOtherEmployees.TabIndex = 61;
            btnOtherEmployees.Text = "Diğer Personeller";
            btnOtherEmployees.UseVisualStyleBackColor = false;
            btnOtherEmployees.Click += btn_Click;
            // 
            // btnLaborant
            // 
            btnLaborant.BackColor = System.Drawing.Color.Brown;
            btnLaborant.FlatAppearance.BorderSize = 0;
            btnLaborant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLaborant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLaborant.ForeColor = System.Drawing.Color.White;
            btnLaborant.Location = new System.Drawing.Point(382, 12);
            btnLaborant.Name = "btnLaborant";
            btnLaborant.Size = new System.Drawing.Size(179, 32);
            btnLaborant.TabIndex = 60;
            btnLaborant.Text = "Laborantlar";
            btnLaborant.UseVisualStyleBackColor = false;
            btnLaborant.Click += btn_Click;
            // 
            // rbProfDr
            // 
            rbProfDr.AutoSize = true;
            rbProfDr.Location = new System.Drawing.Point(293, -1);
            rbProfDr.Name = "rbProfDr";
            rbProfDr.Size = new System.Drawing.Size(87, 24);
            rbProfDr.TabIndex = 82;
            rbProfDr.TabStop = true;
            rbProfDr.Tag = "";
            rbProfDr.Text = "Prof. DR.";
            rbProfDr.UseVisualStyleBackColor = true;
            // 
            // rbDocDr
            // 
            rbDocDr.AutoSize = true;
            rbDocDr.Location = new System.Drawing.Point(200, -1);
            rbDocDr.Name = "rbDocDr";
            rbDocDr.Size = new System.Drawing.Size(87, 24);
            rbDocDr.TabIndex = 81;
            rbDocDr.TabStop = true;
            rbDocDr.Tag = "";
            rbDocDr.Text = "Doç. DR.";
            rbDocDr.UseVisualStyleBackColor = true;
            // 
            // rbYardDocDr
            // 
            rbYardDocDr.AutoSize = true;
            rbYardDocDr.Location = new System.Drawing.Point(79, -1);
            rbYardDocDr.Name = "rbYardDocDr";
            rbYardDocDr.Size = new System.Drawing.Size(115, 24);
            rbYardDocDr.TabIndex = 80;
            rbYardDocDr.TabStop = true;
            rbYardDocDr.Tag = "";
            rbYardDocDr.Text = "Yrd. Doç. DR.";
            rbYardDocDr.UseVisualStyleBackColor = true;
            // 
            // rbUzDr
            // 
            rbUzDr.AutoSize = true;
            rbUzDr.Location = new System.Drawing.Point(0, 0);
            rbUzDr.Name = "rbUzDr";
            rbUzDr.Size = new System.Drawing.Size(77, 24);
            rbUzDr.TabIndex = 79;
            rbUzDr.TabStop = true;
            rbUzDr.Tag = "";
            rbUzDr.Text = "Uz. DR.";
            rbUzDr.UseVisualStyleBackColor = true;
            // 
            // pnlGrades
            // 
            pnlGrades.Controls.Add(rbProfDr);
            pnlGrades.Controls.Add(rbDocDr);
            pnlGrades.Controls.Add(rbYardDocDr);
            pnlGrades.Controls.Add(rbUzDr);
            pnlGrades.Location = new System.Drawing.Point(753, 326);
            pnlGrades.Name = "pnlGrades";
            pnlGrades.Size = new System.Drawing.Size(402, 26);
            pnlGrades.TabIndex = 84;
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.ForeColor = System.Drawing.Color.Brown;
            lblInformation.Location = new System.Drawing.Point(752, 18);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new System.Drawing.Size(177, 20);
            lblInformation.TabIndex = 85;
            lblInformation.Text = "Doktor Düzenleme Modu";
            // 
            // frmEmployees
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 449);
            Controls.Add(lblInformation);
            Controls.Add(pnlGrades);
            Controls.Add(rbGenderMale);
            Controls.Add(rbGenderFemale);
            Controls.Add(btnNurses);
            Controls.Add(btnDoctors);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(cbBloodGroup);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEMail);
            Controls.Add(txtIdentityNo);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(dgwEmployees);
            Controls.Add(btnOtherEmployees);
            Controls.Add(btnLaborant);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmEmployees";
            Text = "frmEmployees";
            Load += frmEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dgwEmployees).EndInit();
            pnlGrades.ResumeLayout(false);
            pnlGrades.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton rbGenderMale;
        private System.Windows.Forms.RadioButton rbGenderFemale;
        private System.Windows.Forms.Button btnNurses;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBloodGroup;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtIdentityNo;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgwEmployees;
        private System.Windows.Forms.Button btnOtherEmployees;
        private System.Windows.Forms.Button btnLaborant;
        private System.Windows.Forms.RadioButton rbProfDr;
        private System.Windows.Forms.RadioButton rbDocDr;
        private System.Windows.Forms.RadioButton rbYardDocDr;
        private System.Windows.Forms.RadioButton rbUzDr;
        private System.Windows.Forms.Panel pnlGrades;
        private System.Windows.Forms.Label lblInformation;
    }
}