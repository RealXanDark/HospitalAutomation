namespace desing
{
    partial class frmPasswordChangeVerification
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordChangeVerification));
            pBoxReturn = new System.Windows.Forms.PictureBox();
            txtVerificationCode = new System.Windows.Forms.TextBox();
            btnNext = new System.Windows.Forms.Button();
            lblRemainingTime = new System.Windows.Forms.Label();
            tmrVerification = new System.Windows.Forms.Timer(components);
            lblResendVerificationCode = new System.Windows.Forms.Label();
            lblFalseCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).BeginInit();
            SuspendLayout();
            // 
            // pBoxReturn
            // 
            pBoxReturn.Image = (System.Drawing.Image)resources.GetObject("pBoxReturn.Image");
            pBoxReturn.Location = new System.Drawing.Point(578, 185);
            pBoxReturn.Name = "pBoxReturn";
            pBoxReturn.Size = new System.Drawing.Size(59, 32);
            pBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBoxReturn.TabIndex = 34;
            pBoxReturn.TabStop = false;
            pBoxReturn.Click += btn_Click;
            // 
            // txtVerificationCode
            // 
            txtVerificationCode.BackColor = System.Drawing.Color.White;
            txtVerificationCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtVerificationCode.Location = new System.Drawing.Point(10, 93);
            txtVerificationCode.MaxLength = 11;
            txtVerificationCode.Name = "txtVerificationCode";
            txtVerificationCode.PlaceholderText = "Doğrulama Kodu";
            txtVerificationCode.Size = new System.Drawing.Size(627, 26);
            txtVerificationCode.TabIndex = 31;
            txtVerificationCode.TextChanged += txtVerificationCode_TextChanged;
            // 
            // btnNext
            // 
            btnNext.BackColor = System.Drawing.Color.Brown;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNext.ForeColor = System.Drawing.Color.White;
            btnNext.Location = new System.Drawing.Point(10, 185);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(559, 32);
            btnNext.TabIndex = 33;
            btnNext.Text = "İleri";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btn_Click;
            // 
            // lblRemainingTime
            // 
            lblRemainingTime.AutoSize = true;
            lblRemainingTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRemainingTime.Location = new System.Drawing.Point(10, 142);
            lblRemainingTime.Name = "lblRemainingTime";
            lblRemainingTime.Size = new System.Drawing.Size(125, 20);
            lblRemainingTime.TabIndex = 35;
            lblRemainingTime.Text = "Kalan Süre : 2:00";
            // 
            // tmrVerification
            // 
            tmrVerification.Interval = 1000;
            tmrVerification.Tick += tmrVerification_Tick;
            // 
            // lblResendVerificationCode
            // 
            lblResendVerificationCode.AutoSize = true;
            lblResendVerificationCode.BackColor = System.Drawing.Color.Transparent;
            lblResendVerificationCode.Enabled = false;
            lblResendVerificationCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblResendVerificationCode.ForeColor = System.Drawing.Color.FromArgb(88, 169, 255);
            lblResendVerificationCode.Location = new System.Drawing.Point(524, 142);
            lblResendVerificationCode.Name = "lblResendVerificationCode";
            lblResendVerificationCode.Size = new System.Drawing.Size(113, 20);
            lblResendVerificationCode.TabIndex = 36;
            lblResendVerificationCode.Text = "Tekrar Gönder";
            lblResendVerificationCode.Click += btn_Click;
            // 
            // lblFalseCode
            // 
            lblFalseCode.AutoSize = true;
            lblFalseCode.ForeColor = System.Drawing.Color.Brown;
            lblFalseCode.Location = new System.Drawing.Point(141, 142);
            lblFalseCode.Name = "lblFalseCode";
            lblFalseCode.Size = new System.Drawing.Size(350, 20);
            lblFalseCode.TabIndex = 37;
            lblFalseCode.Text = "Bu kod çalışmadı. Kodu kontrol edip tekrar deneyin.";
            lblFalseCode.Visible = false;
            // 
            // frmPasswordChangeVerification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(647, 327);
            Controls.Add(lblFalseCode);
            Controls.Add(lblResendVerificationCode);
            Controls.Add(lblRemainingTime);
            Controls.Add(pBoxReturn);
            Controls.Add(txtVerificationCode);
            Controls.Add(btnNext);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmPasswordChangeVerification";
            Text = "frmPasswordChangeVerification";
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.PictureBox pBoxReturn;
        private System.Windows.Forms.TextBox txtVerificationCode;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Timer tmrVerification;
        private System.Windows.Forms.Label lblResendVerificationCode;
        private System.Windows.Forms.Label lblFalseCode;
    }
}