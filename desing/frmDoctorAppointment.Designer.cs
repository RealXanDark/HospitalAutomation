namespace desing
{
    partial class frmDoctorAppointment
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
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblSelectedPatient = new System.Windows.Forms.Label();
            btnCallPatient = new System.Windows.Forms.Button();
            btnCanceledAppointments = new System.Windows.Forms.Button();
            btnActiveAppointments = new System.Windows.Forms.Button();
            dgwAppointment = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Durum";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 273;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tarih";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 273;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Hasta T.C.";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 272;
            // 
            // Durum
            // 
            Durum.DataPropertyName = "status";
            Durum.HeaderText = "Durum";
            Durum.MinimumWidth = 6;
            Durum.Name = "Durum";
            Durum.Width = 272;
            // 
            // Saat
            // 
            Saat.DataPropertyName = "time";
            Saat.HeaderText = "Saat";
            Saat.MinimumWidth = 6;
            Saat.Name = "Saat";
            Saat.Width = 273;
            // 
            // Tarih
            // 
            Tarih.DataPropertyName = "date";
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 6;
            Tarih.Name = "Tarih";
            Tarih.Width = 272;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "patient_identity_no";
            dataGridViewTextBoxColumn1.HeaderText = "Hasta T.C.";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 273;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Saat";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 272;
            // 
            // lblSelectedPatient
            // 
            lblSelectedPatient.AutoSize = true;
            lblSelectedPatient.Location = new System.Drawing.Point(608, 407);
            lblSelectedPatient.Name = "lblSelectedPatient";
            lblSelectedPatient.Size = new System.Drawing.Size(113, 20);
            lblSelectedPatient.TabIndex = 32;
            lblSelectedPatient.Text = "Seçili Hasta T.C.";
            // 
            // btnCallPatient
            // 
            btnCallPatient.BackColor = System.Drawing.Color.Brown;
            btnCallPatient.FlatAppearance.BorderSize = 0;
            btnCallPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCallPatient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCallPatient.ForeColor = System.Drawing.Color.White;
            btnCallPatient.Location = new System.Drawing.Point(946, 400);
            btnCallPatient.Name = "btnCallPatient";
            btnCallPatient.Size = new System.Drawing.Size(209, 35);
            btnCallPatient.TabIndex = 31;
            btnCallPatient.Text = "Hastayı Çağır";
            btnCallPatient.UseVisualStyleBackColor = false;
            btnCallPatient.Click += btnCallPatient_Click;
            // 
            // btnCanceledAppointments
            // 
            btnCanceledAppointments.BackColor = System.Drawing.Color.Brown;
            btnCanceledAppointments.FlatAppearance.BorderSize = 0;
            btnCanceledAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCanceledAppointments.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCanceledAppointments.ForeColor = System.Drawing.Color.White;
            btnCanceledAppointments.Location = new System.Drawing.Point(227, 12);
            btnCanceledAppointments.Name = "btnCanceledAppointments";
            btnCanceledAppointments.Size = new System.Drawing.Size(209, 32);
            btnCanceledAppointments.TabIndex = 29;
            btnCanceledAppointments.Text = "İptal Edilen Randevular";
            btnCanceledAppointments.UseVisualStyleBackColor = false;
            btnCanceledAppointments.Click += btn_Click;
            // 
            // btnActiveAppointments
            // 
            btnActiveAppointments.BackColor = System.Drawing.Color.Brown;
            btnActiveAppointments.FlatAppearance.BorderSize = 0;
            btnActiveAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActiveAppointments.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnActiveAppointments.ForeColor = System.Drawing.Color.White;
            btnActiveAppointments.Location = new System.Drawing.Point(12, 12);
            btnActiveAppointments.Name = "btnActiveAppointments";
            btnActiveAppointments.Size = new System.Drawing.Size(209, 32);
            btnActiveAppointments.TabIndex = 28;
            btnActiveAppointments.Text = "Aktif Randevular";
            btnActiveAppointments.UseVisualStyleBackColor = false;
            btnActiveAppointments.Click += btn_Click;
            // 
            // dgwAppointment
            // 
            dgwAppointment.AllowUserToAddRows = false;
            dgwAppointment.AllowUserToDeleteRows = false;
            dgwAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgwAppointment.BackgroundColor = System.Drawing.Color.White;
            dgwAppointment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgwAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dgwAppointment.Location = new System.Drawing.Point(12, 50);
            dgwAppointment.Name = "dgwAppointment";
            dgwAppointment.ReadOnly = true;
            dgwAppointment.RowHeadersWidth = 51;
            dgwAppointment.RowTemplate.Height = 29;
            dgwAppointment.Size = new System.Drawing.Size(1143, 333);
            dgwAppointment.TabIndex = 30;
            dgwAppointment.CellClick += dgwAppointment_CellClick;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "patient_identity_no";
            dataGridViewTextBoxColumn6.FillWeight = 58.1550827F;
            dataGridViewTextBoxColumn6.HeaderText = "Hasta T.C.";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "date";
            dataGridViewTextBoxColumn7.FillWeight = 58.1550827F;
            dataGridViewTextBoxColumn7.HeaderText = "Tarih";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "time";
            dataGridViewTextBoxColumn8.FillWeight = 58.1550827F;
            dataGridViewTextBoxColumn8.HeaderText = "Saat";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "status";
            dataGridViewTextBoxColumn9.FillWeight = 58.1550827F;
            dataGridViewTextBoxColumn9.HeaderText = "Durum";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "doctor_identity_no";
            dataGridViewTextBoxColumn10.HeaderText = "Doktor T.C.";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "appointment_id";
            dataGridViewTextBoxColumn11.HeaderText = "Randevu Id";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Visible = false;
            // 
            // frmDoctorAppointment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 447);
            Controls.Add(lblSelectedPatient);
            Controls.Add(btnCallPatient);
            Controls.Add(btnCanceledAppointments);
            Controls.Add(btnActiveAppointments);
            Controls.Add(dgwAppointment);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmDoctorAppointment";
            Text = "frmDoctorAppointment";
            Load += frmDoctorAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblSelectedPatient;
        private System.Windows.Forms.Button btnCallPatient;
        private System.Windows.Forms.Button btnCanceledAppointments;
        public System.Windows.Forms.Button btnActiveAppointments;
        private System.Windows.Forms.DataGridView dgwAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}