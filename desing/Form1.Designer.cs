namespace desing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLoginPage = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            pnlSmall = new System.Windows.Forms.Panel();
            pnlLoginPage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginPage
            // 
            pnlLoginPage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlLoginPage.Controls.Add(label1);
            pnlLoginPage.Controls.Add(pnlSmall);
            pnlLoginPage.Location = new System.Drawing.Point(0, 0);
            pnlLoginPage.Name = "pnlLoginPage";
            pnlLoginPage.Size = new System.Drawing.Size(1167, 581);
            pnlLoginPage.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 552);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(311, 20);
            label1.TabIndex = 9;
            label1.Text = "©2023 Han Hastaneleri Tüm Hakları Saklıdır.";
            // 
            // pnlSmall
            // 
            pnlSmall.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlSmall.Location = new System.Drawing.Point(284, 121);
            pnlSmall.Name = "pnlSmall";
            pnlSmall.Size = new System.Drawing.Size(647, 327);
            pnlSmall.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 581);
            Controls.Add(pnlLoginPage);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Han Hastaneleri";
            Load += Form1_Load;
            pnlLoginPage.ResumeLayout(false);
            pnlLoginPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlSmall;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlLoginPage;
    }
}
