namespace desing
{
    partial class frmTestResult
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
            dgwTestResult = new System.Windows.Forms.DataGridView();
            btnSendResult = new System.Windows.Forms.Button();
            txtTestResult = new System.Windows.Forms.TextBox();
            lblSelectedTestId = new System.Windows.Forms.Label();
            txtPatientIdentityNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwTestResult).BeginInit();
            SuspendLayout();
            // 
            // dgwTestResult
            // 
            dgwTestResult.AllowUserToAddRows = false;
            dgwTestResult.AllowUserToDeleteRows = false;
            dgwTestResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgwTestResult.BackgroundColor = System.Drawing.Color.White;
            dgwTestResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTestResult.Location = new System.Drawing.Point(12, 45);
            dgwTestResult.Name = "dgwTestResult";
            dgwTestResult.ReadOnly = true;
            dgwTestResult.RowHeadersWidth = 51;
            dgwTestResult.RowTemplate.Height = 29;
            dgwTestResult.Size = new System.Drawing.Size(728, 389);
            dgwTestResult.TabIndex = 0;
            dgwTestResult.CellClick += dgwTestResult_CellClick;
            // 
            // btnSendResult
            // 
            btnSendResult.BackColor = System.Drawing.Color.Brown;
            btnSendResult.FlatAppearance.BorderSize = 0;
            btnSendResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSendResult.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSendResult.ForeColor = System.Drawing.Color.White;
            btnSendResult.Location = new System.Drawing.Point(753, 389);
            btnSendResult.Name = "btnSendResult";
            btnSendResult.Size = new System.Drawing.Size(402, 45);
            btnSendResult.TabIndex = 69;
            btnSendResult.Text = "Sonucu Gönder";
            btnSendResult.UseVisualStyleBackColor = false;
            btnSendResult.Click += btnSendResult_Click;
            // 
            // txtTestResult
            // 
            txtTestResult.Location = new System.Drawing.Point(753, 45);
            txtTestResult.Multiline = true;
            txtTestResult.Name = "txtTestResult";
            txtTestResult.PlaceholderText = "Test Sonucu";
            txtTestResult.Size = new System.Drawing.Size(402, 338);
            txtTestResult.TabIndex = 68;
            txtTestResult.TextChanged += txtTestResult_TextChanged;
            // 
            // lblSelectedTestId
            // 
            lblSelectedTestId.AutoSize = true;
            lblSelectedTestId.Location = new System.Drawing.Point(753, 15);
            lblSelectedTestId.Name = "lblSelectedTestId";
            lblSelectedTestId.Size = new System.Drawing.Size(118, 20);
            lblSelectedTestId.TabIndex = 67;
            lblSelectedTestId.Text = "Seçilen Tahlil Id :";
            lblSelectedTestId.Click += lblSelectedTestId_Click;
            // 
            // txtPatientIdentityNo
            // 
            txtPatientIdentityNo.Location = new System.Drawing.Point(12, 12);
            txtPatientIdentityNo.MaxLength = 11;
            txtPatientIdentityNo.Name = "txtPatientIdentityNo";
            txtPatientIdentityNo.PlaceholderText = "Hasta T.C.";
            txtPatientIdentityNo.Size = new System.Drawing.Size(213, 27);
            txtPatientIdentityNo.TabIndex = 70;
            txtPatientIdentityNo.TextChanged += txtPatientIdentityNo_TextChanged;
            // 
            // frmTestResult
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 447);
            Controls.Add(txtPatientIdentityNo);
            Controls.Add(btnSendResult);
            Controls.Add(txtTestResult);
            Controls.Add(lblSelectedTestId);
            Controls.Add(dgwTestResult);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmTestResult";
            Text = "frmTestResult";
            ((System.ComponentModel.ISupportInitialize)dgwTestResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTestResult;
        private System.Windows.Forms.Button btnSendResult;
        private System.Windows.Forms.TextBox txtTestResult;
        private System.Windows.Forms.Label lblSelectedTestId;
        private System.Windows.Forms.TextBox txtPatientIdentityNo;
    }
}