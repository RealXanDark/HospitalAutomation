namespace desing
{
    partial class frmTestResultWindow
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
            dgwResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwResult).BeginInit();
            SuspendLayout();
            // 
            // dgwResult
            // 
            dgwResult.AllowUserToAddRows = false;
            dgwResult.AllowUserToDeleteRows = false;
            dgwResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgwResult.BackgroundColor = System.Drawing.Color.White;
            dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwResult.Location = new System.Drawing.Point(12, 12);
            dgwResult.Name = "dgwResult";
            dgwResult.ReadOnly = true;
            dgwResult.RowHeadersWidth = 51;
            dgwResult.RowTemplate.Height = 29;
            dgwResult.Size = new System.Drawing.Size(1143, 557);
            dgwResult.TabIndex = 1;
            // 
            // frmTestResultWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 581);
            Controls.Add(dgwResult);
            Name = "frmTestResultWindow";
            Text = "frmTestResultWindow";
            ((System.ComponentModel.ISupportInitialize)dgwResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgwResult;
    }
}