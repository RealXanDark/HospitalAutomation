namespace desing
{
    partial class frmAppointment
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
            cbProvince = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbDistrict = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cbHospital = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            cbClinic = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            cbDoctor = new System.Windows.Forms.ComboBox();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cbTime = new System.Windows.Forms.ComboBox();
            btnReviewAppointment = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cbProvince
            // 
            cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbProvince.FormattingEnabled = true;
            cbProvince.Location = new System.Drawing.Point(14, 30);
            cbProvince.Name = "cbProvince";
            cbProvince.Size = new System.Drawing.Size(1141, 28);
            cbProvince.TabIndex = 0;
            cbProvince.Tag = "1";
            cbProvince.SelectedIndexChanged += cbProvince_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Gray;
            label1.Location = new System.Drawing.Point(14, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(16, 18);
            label1.TabIndex = 1;
            label1.Text = "İl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Gray;
            label2.Location = new System.Drawing.Point(14, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 18);
            label2.TabIndex = 3;
            label2.Text = "İlçe";
            // 
            // cbDistrict
            // 
            cbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDistrict.FormattingEnabled = true;
            cbDistrict.Location = new System.Drawing.Point(14, 90);
            cbDistrict.Name = "cbDistrict";
            cbDistrict.Size = new System.Drawing.Size(1141, 28);
            cbDistrict.TabIndex = 2;
            cbDistrict.Tag = "2";
            cbDistrict.SelectedIndexChanged += cbDistrict_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Gray;
            label3.Location = new System.Drawing.Point(14, 189);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 18);
            label3.TabIndex = 5;
            label3.Text = "Klinik";
            // 
            // cbHospital
            // 
            cbHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbHospital.FormattingEnabled = true;
            cbHospital.Location = new System.Drawing.Point(14, 150);
            cbHospital.Name = "cbHospital";
            cbHospital.Size = new System.Drawing.Size(1141, 28);
            cbHospital.TabIndex = 4;
            cbHospital.Tag = "3";
            cbHospital.SelectedIndexChanged += cbHospital_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Gray;
            label4.Location = new System.Drawing.Point(14, 129);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 18);
            label4.TabIndex = 7;
            label4.Text = "Hastane";
            // 
            // cbClinic
            // 
            cbClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbClinic.FormattingEnabled = true;
            cbClinic.Location = new System.Drawing.Point(14, 210);
            cbClinic.Name = "cbClinic";
            cbClinic.Size = new System.Drawing.Size(1141, 28);
            cbClinic.TabIndex = 6;
            cbClinic.Tag = "4";
            cbClinic.SelectedIndexChanged += cbClinic_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Gray;
            label5.Location = new System.Drawing.Point(14, 249);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 18);
            label5.TabIndex = 9;
            label5.Text = "Doktor";
            // 
            // cbDoctor
            // 
            cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Location = new System.Drawing.Point(14, 270);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new System.Drawing.Size(1141, 28);
            cbDoctor.TabIndex = 8;
            cbDoctor.Tag = "5";
            cbDoctor.SelectedIndexChanged += cbDoctor_SelectedIndexChanged;
            // 
            // dtpDate
            // 
            dtpDate.Location = new System.Drawing.Point(14, 330);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new System.Drawing.Size(1141, 26);
            dtpDate.TabIndex = 10;
            dtpDate.Tag = "6";
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Gray;
            label6.Location = new System.Drawing.Point(14, 309);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 18);
            label6.TabIndex = 11;
            label6.Text = "Tarih";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Gray;
            label7.Location = new System.Drawing.Point(14, 369);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(40, 18);
            label7.TabIndex = 13;
            label7.Text = "Saat";
            // 
            // cbTime
            // 
            cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbTime.FormattingEnabled = true;
            cbTime.Location = new System.Drawing.Point(14, 390);
            cbTime.Name = "cbTime";
            cbTime.Size = new System.Drawing.Size(616, 28);
            cbTime.TabIndex = 12;
            cbTime.Tag = "7";
            cbTime.SelectedIndexChanged += cbTime_SelectedIndexChanged;
            // 
            // btnReviewAppointment
            // 
            btnReviewAppointment.BackColor = System.Drawing.Color.Brown;
            btnReviewAppointment.FlatAppearance.BorderSize = 0;
            btnReviewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReviewAppointment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReviewAppointment.ForeColor = System.Drawing.Color.White;
            btnReviewAppointment.Location = new System.Drawing.Point(636, 390);
            btnReviewAppointment.Name = "btnReviewAppointment";
            btnReviewAppointment.Size = new System.Drawing.Size(519, 28);
            btnReviewAppointment.TabIndex = 14;
            btnReviewAppointment.Text = "Randevuyu Gözden Geçir";
            btnReviewAppointment.UseVisualStyleBackColor = false;
            btnReviewAppointment.Click += btn_Click;
            // 
            // frmAppointment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 447);
            Controls.Add(btnReviewAppointment);
            Controls.Add(label7);
            Controls.Add(cbTime);
            Controls.Add(label6);
            Controls.Add(dtpDate);
            Controls.Add(label5);
            Controls.Add(cbDoctor);
            Controls.Add(label4);
            Controls.Add(cbClinic);
            Controls.Add(label3);
            Controls.Add(cbHospital);
            Controls.Add(label2);
            Controls.Add(cbDistrict);
            Controls.Add(label1);
            Controls.Add(cbProvince);
            Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmAppointment";
            Text = "frmAppointment";
            Load += frmAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Button btnReviewAppointment;
        public System.Windows.Forms.ComboBox cbProvince;
        public System.Windows.Forms.ComboBox cbDistrict;
        public System.Windows.Forms.ComboBox cbHospital;
        public System.Windows.Forms.ComboBox cbClinic;
        public System.Windows.Forms.ComboBox cbDoctor;
    }
}