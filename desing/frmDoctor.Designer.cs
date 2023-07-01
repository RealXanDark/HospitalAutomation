namespace desing
{
    partial class frmDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor));
            pnlMain = new System.Windows.Forms.Panel();
            btnPastTreatments = new System.Windows.Forms.Button();
            btnAccount = new System.Windows.Forms.Button();
            btnAppointments = new System.Windows.Forms.Button();
            btnTestResults = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            btnLogOut = new System.Windows.Forms.Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 132);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1167, 449);
            pnlMain.TabIndex = 4;
            // 
            // btnPastTreatments
            // 
            btnPastTreatments.BackColor = System.Drawing.Color.Brown;
            btnPastTreatments.FlatAppearance.BorderSize = 0;
            btnPastTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPastTreatments.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPastTreatments.ForeColor = System.Drawing.Color.Transparent;
            btnPastTreatments.Image = (System.Drawing.Image)resources.GetObject("btnPastTreatments.Image");
            btnPastTreatments.Location = new System.Drawing.Point(255, 2);
            btnPastTreatments.Name = "btnPastTreatments";
            btnPastTreatments.Size = new System.Drawing.Size(142, 125);
            btnPastTreatments.TabIndex = 3;
            btnPastTreatments.Text = "Geçmiş Tedaviler";
            btnPastTreatments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnPastTreatments.UseVisualStyleBackColor = false;
            btnPastTreatments.Click += btn_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = System.Drawing.Color.Brown;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAccount.ForeColor = System.Drawing.Color.Transparent;
            btnAccount.Image = (System.Drawing.Image)resources.GetObject("btnAccount.Image");
            btnAccount.Location = new System.Drawing.Point(403, 3);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new System.Drawing.Size(120, 125);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "Hesabım";
            btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btn_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = System.Drawing.Color.Brown;
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAppointments.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAppointments.ForeColor = System.Drawing.Color.Transparent;
            btnAppointments.Image = (System.Drawing.Image)resources.GetObject("btnAppointments.Image");
            btnAppointments.Location = new System.Drawing.Point(3, 3);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new System.Drawing.Size(120, 125);
            btnAppointments.TabIndex = 0;
            btnAppointments.Text = "Randevular";
            btnAppointments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btn_Click;
            // 
            // btnTestResults
            // 
            btnTestResults.BackColor = System.Drawing.Color.Brown;
            btnTestResults.FlatAppearance.BorderSize = 0;
            btnTestResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTestResults.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTestResults.ForeColor = System.Drawing.Color.Transparent;
            btnTestResults.Image = (System.Drawing.Image)resources.GetObject("btnTestResults.Image");
            btnTestResults.Location = new System.Drawing.Point(129, 3);
            btnTestResults.Name = "btnTestResults";
            btnTestResults.Size = new System.Drawing.Size(120, 125);
            btnTestResults.TabIndex = 2;
            btnTestResults.Text = "Test Sonuçları";
            btnTestResults.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTestResults.UseVisualStyleBackColor = false;
            btnTestResults.Click += btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Brown;
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnPastTreatments);
            panel2.Controls.Add(btnAccount);
            panel2.Controls.Add(btnAppointments);
            panel2.Controls.Add(btnTestResults);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1167, 132);
            panel2.TabIndex = 3;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = System.Drawing.Color.Brown;
            btnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            btnLogOut.Image = (System.Drawing.Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new System.Drawing.Point(1047, 0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new System.Drawing.Size(120, 132);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Çıkış Yap";
            btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btn_Click;
            // 
            // frmDoctor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1167, 581);
            Controls.Add(pnlMain);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmDoctor";
            Text = "frmDoctor";
            Load += frmDoctor_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnPastTreatments;
        private System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnAppointments;
        public System.Windows.Forms.Button btnTestResults;
        public System.Windows.Forms.Button btnAccount;
    }
}