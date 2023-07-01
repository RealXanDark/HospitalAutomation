namespace desing
{
    partial class frmHospitals
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
            lblInformation = new System.Windows.Forms.Label();
            btnUpdateMode = new System.Windows.Forms.Button();
            btnSaveMode = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnSaveUpdate = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtAdress = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cbProvince = new System.Windows.Forms.ComboBox();
            dtpOpeningDate = new System.Windows.Forms.DateTimePicker();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtEMail = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            dgwHospitals = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            cbDistrict = new System.Windows.Forms.ComboBox();
            lblInformationUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgwHospitals).BeginInit();
            SuspendLayout();
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.ForeColor = System.Drawing.Color.Brown;
            lblInformation.Location = new System.Drawing.Point(752, 17);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new System.Drawing.Size(177, 20);
            lblInformation.TabIndex = 106;
            lblInformation.Text = "Hastane Kaydetme Modu";
            // 
            // btnUpdateMode
            // 
            btnUpdateMode.BackColor = System.Drawing.Color.Brown;
            btnUpdateMode.FlatAppearance.BorderSize = 0;
            btnUpdateMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateMode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdateMode.ForeColor = System.Drawing.Color.White;
            btnUpdateMode.Location = new System.Drawing.Point(197, 11);
            btnUpdateMode.Name = "btnUpdateMode";
            btnUpdateMode.Size = new System.Drawing.Size(179, 32);
            btnUpdateMode.TabIndex = 102;
            btnUpdateMode.Text = "Güncelleme";
            btnUpdateMode.UseVisualStyleBackColor = false;
            btnUpdateMode.Click += btnUpdateMode_Click;
            // 
            // btnSaveMode
            // 
            btnSaveMode.BackColor = System.Drawing.Color.Brown;
            btnSaveMode.FlatAppearance.BorderSize = 0;
            btnSaveMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveMode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSaveMode.ForeColor = System.Drawing.Color.White;
            btnSaveMode.Location = new System.Drawing.Point(12, 11);
            btnSaveMode.Name = "btnSaveMode";
            btnSaveMode.Size = new System.Drawing.Size(179, 32);
            btnSaveMode.TabIndex = 101;
            btnSaveMode.Text = "Kaydetme";
            btnSaveMode.UseVisualStyleBackColor = false;
            btnSaveMode.Click += btnSaveMode_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Brown;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(752, 404);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(198, 32);
            btnDelete.TabIndex = 100;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.BackColor = System.Drawing.Color.Brown;
            btnSaveUpdate.FlatAppearance.BorderSize = 0;
            btnSaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSaveUpdate.ForeColor = System.Drawing.Color.White;
            btnSaveUpdate.Location = new System.Drawing.Point(956, 404);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new System.Drawing.Size(198, 32);
            btnSaveUpdate.TabIndex = 99;
            btnSaveUpdate.Text = "Kaydet/Güncelle";
            btnSaveUpdate.UseVisualStyleBackColor = false;
            btnSaveUpdate.Click += btnSaveUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Gray;
            label2.Location = new System.Drawing.Point(752, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 20);
            label2.TabIndex = 98;
            label2.Text = "Açılış Tarihi";
            // 
            // txtAdress
            // 
            txtAdress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAdress.Location = new System.Drawing.Point(753, 199);
            txtAdress.MaxLength = 30;
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.PlaceholderText = "Adres";
            txtAdress.Size = new System.Drawing.Size(402, 91);
            txtAdress.TabIndex = 96;
            txtAdress.Tag = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Gray;
            label1.Location = new System.Drawing.Point(751, 293);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 20);
            label1.TabIndex = 97;
            label1.Text = "İl";
            // 
            // cbProvince
            // 
            cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbProvince.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbProvince.ForeColor = System.Drawing.Color.Black;
            cbProvince.FormattingEnabled = true;
            cbProvince.Items.AddRange(new object[] { "0 RH +", "0 RH -", "A RH +", "A RH - ", "B RH +", "B RH -", "AB RH +", "AB RH -" });
            cbProvince.Location = new System.Drawing.Point(751, 316);
            cbProvince.Name = "cbProvince";
            cbProvince.Size = new System.Drawing.Size(402, 28);
            cbProvince.TabIndex = 93;
            cbProvince.Tag = "1";
            cbProvince.SelectedIndexChanged += cbProvince_SelectedIndexChanged;
            // 
            // dtpOpeningDate
            // 
            dtpOpeningDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpOpeningDate.Location = new System.Drawing.Point(752, 101);
            dtpOpeningDate.Name = "dtpOpeningDate";
            dtpOpeningDate.Size = new System.Drawing.Size(401, 28);
            dtpOpeningDate.TabIndex = 92;
            dtpOpeningDate.Tag = "1";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhoneNumber.Location = new System.Drawing.Point(753, 135);
            txtPhoneNumber.MaxLength = 10;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Telefon Numarası";
            txtPhoneNumber.Size = new System.Drawing.Size(402, 26);
            txtPhoneNumber.TabIndex = 94;
            txtPhoneNumber.Tag = "1";
            // 
            // txtEMail
            // 
            txtEMail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEMail.Location = new System.Drawing.Point(753, 167);
            txtEMail.MaxLength = 70;
            txtEMail.Name = "txtEMail";
            txtEMail.PlaceholderText = "E Posta";
            txtEMail.Size = new System.Drawing.Size(402, 26);
            txtEMail.TabIndex = 95;
            txtEMail.Tag = "1";
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(753, 49);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ad";
            txtName.Size = new System.Drawing.Size(402, 26);
            txtName.TabIndex = 89;
            txtName.Tag = "1";
            // 
            // dgwHospitals
            // 
            dgwHospitals.AllowUserToAddRows = false;
            dgwHospitals.AllowUserToDeleteRows = false;
            dgwHospitals.BackgroundColor = System.Drawing.Color.White;
            dgwHospitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwHospitals.Location = new System.Drawing.Point(12, 49);
            dgwHospitals.Name = "dgwHospitals";
            dgwHospitals.ReadOnly = true;
            dgwHospitals.RowHeadersWidth = 51;
            dgwHospitals.RowTemplate.Height = 29;
            dgwHospitals.Size = new System.Drawing.Size(735, 387);
            dgwHospitals.TabIndex = 88;
            dgwHospitals.CellClick += dgwHospitals_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Gray;
            label3.Location = new System.Drawing.Point(751, 347);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 20);
            label3.TabIndex = 108;
            label3.Text = "İlçe";
            // 
            // cbDistrict
            // 
            cbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDistrict.Enabled = false;
            cbDistrict.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbDistrict.ForeColor = System.Drawing.Color.Black;
            cbDistrict.FormattingEnabled = true;
            cbDistrict.Items.AddRange(new object[] { "0 RH +", "0 RH -", "A RH +", "A RH - ", "B RH +", "B RH -", "AB RH +", "AB RH -" });
            cbDistrict.Location = new System.Drawing.Point(751, 370);
            cbDistrict.Name = "cbDistrict";
            cbDistrict.Size = new System.Drawing.Size(402, 28);
            cbDistrict.TabIndex = 107;
            cbDistrict.Tag = "1";
            cbDistrict.SelectedIndexChanged += cbDistrict_SelectedIndexChanged;
            // 
            // lblInformationUpdate
            // 
            lblInformationUpdate.AutoSize = true;
            lblInformationUpdate.ForeColor = System.Drawing.Color.Brown;
            lblInformationUpdate.Location = new System.Drawing.Point(1016, 17);
            lblInformationUpdate.Name = "lblInformationUpdate";
            lblInformationUpdate.Size = new System.Drawing.Size(139, 20);
            lblInformationUpdate.TabIndex = 109;
            lblInformationUpdate.Text = "Güncelleme Başarılı";
            // 
            // frmHospitals
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 447);
            Controls.Add(lblInformationUpdate);
            Controls.Add(label3);
            Controls.Add(cbDistrict);
            Controls.Add(lblInformation);
            Controls.Add(btnUpdateMode);
            Controls.Add(btnSaveMode);
            Controls.Add(btnDelete);
            Controls.Add(btnSaveUpdate);
            Controls.Add(label2);
            Controls.Add(txtAdress);
            Controls.Add(label1);
            Controls.Add(cbProvince);
            Controls.Add(dtpOpeningDate);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEMail);
            Controls.Add(txtName);
            Controls.Add(dgwHospitals);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmHospitals";
            Text = "Güncelleme Başarılı";
            Load += frmHospitals_Load;
            ((System.ComponentModel.ISupportInitialize)dgwHospitals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnUpdateMode;
        private System.Windows.Forms.Button btnSaveMode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.DateTimePicker dtpOpeningDate;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgwHospitals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label lblInformationUpdate;
    }
}