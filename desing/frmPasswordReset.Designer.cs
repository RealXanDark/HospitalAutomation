namespace desing
{
    partial class frmPasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordReset));
            pBoxReturn = new System.Windows.Forms.PictureBox();
            txtIdentityNo = new System.Windows.Forms.TextBox();
            btnNext = new System.Windows.Forms.Button();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
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
            pBoxReturn.TabIndex = 30;
            pBoxReturn.TabStop = false;
            pBoxReturn.Click += btn_Click;
            // 
            // txtIdentityNo
            // 
            txtIdentityNo.BackColor = System.Drawing.Color.White;
            txtIdentityNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIdentityNo.Location = new System.Drawing.Point(10, 93);
            txtIdentityNo.MaxLength = 11;
            txtIdentityNo.Name = "txtIdentityNo";
            txtIdentityNo.PlaceholderText = "T.C. Kimlik No";
            txtIdentityNo.Size = new System.Drawing.Size(627, 26);
            txtIdentityNo.TabIndex = 27;
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
            btnNext.TabIndex = 29;
            btnNext.Text = "İleri";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btn_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = System.Drawing.Color.White;
            txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhoneNumber.Location = new System.Drawing.Point(10, 125);
            txtPhoneNumber.MaxLength = 30;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Telefon Numarası";
            txtPhoneNumber.Size = new System.Drawing.Size(627, 26);
            txtPhoneNumber.TabIndex = 28;
            // 
            // frmPasswordReset
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(647, 327);
            Controls.Add(pBoxReturn);
            Controls.Add(txtIdentityNo);
            Controls.Add(btnNext);
            Controls.Add(txtPhoneNumber);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmPasswordReset";
            Text = "frmPasswordReset";
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.PictureBox pBoxReturn;
        private System.Windows.Forms.TextBox txtIdentityNo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}