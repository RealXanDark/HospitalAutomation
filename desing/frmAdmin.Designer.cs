namespace desing
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            pnlMain = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            btnEmployees = new System.Windows.Forms.Button();
            btnLogOut = new System.Windows.Forms.Button();
            btnPrescriptions = new System.Windows.Forms.Button();
            btnAccount = new System.Windows.Forms.Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 132);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1167, 449);
            pnlMain.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Brown;
            panel2.Controls.Add(btnEmployees);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnPrescriptions);
            panel2.Controls.Add(btnAccount);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1167, 132);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = System.Drawing.Color.Brown;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEmployees.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEmployees.ForeColor = System.Drawing.Color.Transparent;
            btnEmployees.Image = (System.Drawing.Image)resources.GetObject("btnEmployees.Image");
            btnEmployees.Location = new System.Drawing.Point(0, 3);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new System.Drawing.Size(120, 125);
            btnEmployees.TabIndex = 9;
            btnEmployees.Text = "Çalışanlar";
            btnEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btn_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = System.Drawing.Color.Brown;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            btnLogOut.Image = (System.Drawing.Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new System.Drawing.Point(1044, 3);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new System.Drawing.Size(120, 125);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Çıkış Yap";
            btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btn_Click;
            // 
            // btnPrescriptions
            // 
            btnPrescriptions.BackColor = System.Drawing.Color.Brown;
            btnPrescriptions.FlatAppearance.BorderSize = 0;
            btnPrescriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrescriptions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPrescriptions.ForeColor = System.Drawing.Color.Transparent;
            btnPrescriptions.Image = (System.Drawing.Image)resources.GetObject("btnPrescriptions.Image");
            btnPrescriptions.Location = new System.Drawing.Point(802, 3);
            btnPrescriptions.Name = "btnPrescriptions";
            btnPrescriptions.Size = new System.Drawing.Size(120, 125);
            btnPrescriptions.TabIndex = 10;
            btnPrescriptions.Text = "Yönetim";
            btnPrescriptions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnPrescriptions.UseVisualStyleBackColor = false;
            btnPrescriptions.Visible = false;
            btnPrescriptions.Click += btn_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = System.Drawing.Color.Brown;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAccount.ForeColor = System.Drawing.Color.Transparent;
            btnAccount.Image = (System.Drawing.Image)resources.GetObject("btnAccount.Image");
            btnAccount.Location = new System.Drawing.Point(918, 3);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new System.Drawing.Size(120, 125);
            btnAccount.TabIndex = 11;
            btnAccount.Text = "Hesabım";
            btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Visible = false;
            btnAccount.Click += btn_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1167, 581);
            Controls.Add(pnlMain);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmAdmin";
            Text = "frmAdmin";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPrescriptions;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnAccount;
    }
}