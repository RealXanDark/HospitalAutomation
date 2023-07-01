namespace desing
{
    partial class frmLaboratoryResult
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgwTest = new System.Windows.Forms.DataGridView();
            txtTestResult = new System.Windows.Forms.TextBox();
            btnSendResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgwTest).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgwTest
            // 
            dgwTest.AllowUserToAddRows = false;
            dgwTest.AllowUserToDeleteRows = false;
            dgwTest.BackgroundColor = System.Drawing.Color.White;
            dgwTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTest.Location = new System.Drawing.Point(12, 12);
            dgwTest.Name = "dgwTest";
            dgwTest.ReadOnly = true;
            dgwTest.RowHeadersWidth = 51;
            dgwTest.RowTemplate.Height = 29;
            dgwTest.Size = new System.Drawing.Size(735, 425);
            dgwTest.TabIndex = 63;
            // 
            // txtTestResult
            // 
            txtTestResult.Location = new System.Drawing.Point(753, 12);
            txtTestResult.Multiline = true;
            txtTestResult.Name = "txtTestResult";
            txtTestResult.PlaceholderText = "Test Sonucu";
            txtTestResult.Size = new System.Drawing.Size(402, 374);
            txtTestResult.TabIndex = 65;
            // 
            // btnSendResult
            // 
            btnSendResult.BackColor = System.Drawing.Color.Brown;
            btnSendResult.FlatAppearance.BorderSize = 0;
            btnSendResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSendResult.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSendResult.ForeColor = System.Drawing.Color.White;
            btnSendResult.Location = new System.Drawing.Point(753, 392);
            btnSendResult.Name = "btnSendResult";
            btnSendResult.Size = new System.Drawing.Size(402, 45);
            btnSendResult.TabIndex = 66;
            btnSendResult.Text = "Sonucu Gönder";
            btnSendResult.UseVisualStyleBackColor = false;
            btnSendResult.Click += btnSendResult_Click;
            // 
            // frmLaboratoryResult
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1167, 449);
            Controls.Add(btnSendResult);
            Controls.Add(txtTestResult);
            Controls.Add(dgwTest);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmLaboratoryResult";
            Text = "frmLaboratoryResult";
            ((System.ComponentModel.ISupportInitialize)dgwTest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.DataGridView dgwTest;
        private System.Windows.Forms.TextBox txtTestResult;
        private System.Windows.Forms.Button btnSendResult;
    }
}