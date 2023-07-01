namespace desing
{
    partial class frmPatientTestResult
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
            lblSelectedTest = new System.Windows.Forms.Label();
            btnPrint = new System.Windows.Forms.Button();
            dgwTestResult = new System.Windows.Forms.DataGridView();
            print = new System.Drawing.Printing.PrintDocument();
            testadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sonuç = new System.Windows.Forms.DataGridViewTextBoxColumn();
            doktorcevabi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patient_identity_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            test_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwTestResult).BeginInit();
            SuspendLayout();
            // 
            // lblSelectedTest
            // 
            lblSelectedTest.AutoSize = true;
            lblSelectedTest.Location = new System.Drawing.Point(575, 403);
            lblSelectedTest.Name = "lblSelectedTest";
            lblSelectedTest.Size = new System.Drawing.Size(102, 20);
            lblSelectedTest.TabIndex = 63;
            lblSelectedTest.Text = "Seçili Test Id : ";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = System.Drawing.Color.Brown;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrint.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPrint.ForeColor = System.Drawing.Color.White;
            btnPrint.Location = new System.Drawing.Point(864, 391);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(291, 45);
            btnPrint.TabIndex = 62;
            btnPrint.Text = "Yazdır";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // dgwTestResult
            // 
            dgwTestResult.AllowUserToAddRows = false;
            dgwTestResult.AllowUserToDeleteRows = false;
            dgwTestResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgwTestResult.BackgroundColor = System.Drawing.Color.White;
            dgwTestResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTestResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { testadi, Tarih, Sonuç, doktorcevabi, Control, patient_identity_no, test_id });
            dgwTestResult.Location = new System.Drawing.Point(12, 10);
            dgwTestResult.Name = "dgwTestResult";
            dgwTestResult.ReadOnly = true;
            dgwTestResult.RowHeadersWidth = 51;
            dgwTestResult.RowTemplate.Height = 29;
            dgwTestResult.Size = new System.Drawing.Size(1143, 375);
            dgwTestResult.TabIndex = 61;
            dgwTestResult.CellClick += dgwTestResult_CellClick;
            // 
            // print
            // 
            print.PrintPage += print_PrintPage;
            // 
            // testadi
            // 
            testadi.DataPropertyName = "test_name";
            testadi.HeaderText = "Test Adı";
            testadi.MinimumWidth = 6;
            testadi.Name = "testadi";
            testadi.ReadOnly = true;
            // 
            // Tarih
            // 
            Tarih.DataPropertyName = "date";
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 6;
            Tarih.Name = "Tarih";
            Tarih.ReadOnly = true;
            // 
            // Sonuç
            // 
            Sonuç.DataPropertyName = "result";
            Sonuç.HeaderText = "Sonuç";
            Sonuç.MinimumWidth = 6;
            Sonuç.Name = "Sonuç";
            Sonuç.ReadOnly = true;
            // 
            // doktorcevabi
            // 
            doktorcevabi.DataPropertyName = "remarks";
            doktorcevabi.HeaderText = "Doktor Cevabı";
            doktorcevabi.MinimumWidth = 6;
            doktorcevabi.Name = "doktorcevabi";
            doktorcevabi.ReadOnly = true;
            // 
            // Control
            // 
            Control.DataPropertyName = "doctor_control";
            Control.HeaderText = "Control";
            Control.MinimumWidth = 6;
            Control.Name = "Control";
            Control.ReadOnly = true;
            Control.Visible = false;
            // 
            // patient_identity_no
            // 
            patient_identity_no.DataPropertyName = "patient_identity_no";
            patient_identity_no.HeaderText = "patient_identity_no";
            patient_identity_no.MinimumWidth = 6;
            patient_identity_no.Name = "patient_identity_no";
            patient_identity_no.ReadOnly = true;
            patient_identity_no.Visible = false;
            // 
            // test_id
            // 
            test_id.DataPropertyName = "test_id";
            test_id.HeaderText = "test_id";
            test_id.MinimumWidth = 6;
            test_id.Name = "test_id";
            test_id.ReadOnly = true;
            test_id.Visible = false;
            // 
            // frmPatientTestResult
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 447);
            Controls.Add(lblSelectedTest);
            Controls.Add(btnPrint);
            Controls.Add(dgwTestResult);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmPatientTestResult";
            Text = "frmPatientTestResult";
            ((System.ComponentModel.ISupportInitialize)dgwTestResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSelectedTest;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgwTestResult;
        private System.Drawing.Printing.PrintDocument print;
        private System.Windows.Forms.DataGridViewTextBoxColumn testadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonuç;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorcevabi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Control;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_identity_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_id;
    }
}