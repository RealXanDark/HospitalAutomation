namespace desing
{
    partial class frmLaboratory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratory));
            btnLogOut = new System.Windows.Forms.Button();
            btnAccount = new System.Windows.Forms.Button();
            btnTests = new System.Windows.Forms.Button();
            pnlMain = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = System.Drawing.Color.Brown;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            btnLogOut.Image = (System.Drawing.Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new System.Drawing.Point(1047, 0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new System.Drawing.Size(120, 125);
            btnLogOut.TabIndex = 19;
            btnLogOut.Text = "Çıkış Yap";
            btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btn_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = System.Drawing.Color.Brown;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAccount.ForeColor = System.Drawing.Color.Transparent;
            btnAccount.Image = (System.Drawing.Image)resources.GetObject("btnAccount.Image");
            btnAccount.Location = new System.Drawing.Point(126, 0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new System.Drawing.Size(120, 125);
            btnAccount.TabIndex = 24;
            btnAccount.Text = "Hesabım";
            btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btn_Click;
            // 
            // btnTests
            // 
            btnTests.BackColor = System.Drawing.Color.Brown;
            btnTests.FlatAppearance.BorderSize = 0;
            btnTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTests.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTests.ForeColor = System.Drawing.Color.Transparent;
            btnTests.Image = (System.Drawing.Image)resources.GetObject("btnTests.Image");
            btnTests.Location = new System.Drawing.Point(0, 0);
            btnTests.Name = "btnTests";
            btnTests.Size = new System.Drawing.Size(120, 125);
            btnTests.TabIndex = 20;
            btnTests.Text = "Testler";
            btnTests.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTests.UseVisualStyleBackColor = false;
            btnTests.Click += btn_Click;
            // 
            // pnlMain
            // 
            pnlMain.Location = new System.Drawing.Point(0, 125);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1167, 456);
            pnlMain.TabIndex = 18;
            // 
            // frmLaboratory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Brown;
            ClientSize = new System.Drawing.Size(1167, 581);
            Controls.Add(btnLogOut);
            Controls.Add(btnAccount);
            Controls.Add(btnTests);
            Controls.Add(pnlMain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmLaboratory";
            Text = "frmLaboratory";
            Load += frmLaboratory_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.Button btnTests;
    }
}