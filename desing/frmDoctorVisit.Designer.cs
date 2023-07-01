namespace desing
{
    partial class frmDoctorVisit
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
            txtPatientIdentityNo = new System.Windows.Forms.TextBox();
            dgwTestResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwTestResult).BeginInit();
            SuspendLayout();
            // 
            // txtPatientIdentityNo
            // 
            txtPatientIdentityNo.Location = new System.Drawing.Point(12, 12);
            txtPatientIdentityNo.MaxLength = 11;
            txtPatientIdentityNo.Name = "txtPatientIdentityNo";
            txtPatientIdentityNo.PlaceholderText = "Hasta T.C.";
            txtPatientIdentityNo.Size = new System.Drawing.Size(213, 27);
            txtPatientIdentityNo.TabIndex = 75;
            txtPatientIdentityNo.TextChanged += txtPatientIdentityNo_TextChanged;
            // 
            // dgwTestResult
            // 
            dgwTestResult.AllowUserToAddRows = false;
            dgwTestResult.AllowUserToDeleteRows = false;
            dgwTestResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgwTestResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgwTestResult.BackgroundColor = System.Drawing.Color.White;
            dgwTestResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTestResult.Location = new System.Drawing.Point(12, 45);
            dgwTestResult.Name = "dgwTestResult";
            dgwTestResult.ReadOnly = true;
            dgwTestResult.RowHeadersWidth = 51;
            dgwTestResult.RowTemplate.Height = 29;
            dgwTestResult.Size = new System.Drawing.Size(1143, 389);
            dgwTestResult.TabIndex = 71;
            // 
            // frmDoctorVisit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 447);
            Controls.Add(txtPatientIdentityNo);
            Controls.Add(dgwTestResult);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmDoctorVisit";
            Text = "frmDoctorVisit";
            ((System.ComponentModel.ISupportInitialize)dgwTestResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientIdentityNo;
        private System.Windows.Forms.DataGridView dgwTestResult;
    }
}