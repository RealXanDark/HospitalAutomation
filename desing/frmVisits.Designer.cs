namespace desing
{
    partial class frmVisits
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
            dgwVisit = new System.Windows.Forms.DataGridView();
            hastatc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            teshis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            recete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwVisit).BeginInit();
            SuspendLayout();
            // 
            // dgwVisit
            // 
            dgwVisit.AllowUserToAddRows = false;
            dgwVisit.AllowUserToDeleteRows = false;
            dgwVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgwVisit.BackgroundColor = System.Drawing.Color.White;
            dgwVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { hastatc, tarih, teshis, recete, id });
            dgwVisit.Location = new System.Drawing.Point(12, 12);
            dgwVisit.Name = "dgwVisit";
            dgwVisit.ReadOnly = true;
            dgwVisit.RowHeadersWidth = 51;
            dgwVisit.RowTemplate.Height = 29;
            dgwVisit.Size = new System.Drawing.Size(1143, 423);
            dgwVisit.TabIndex = 0;
            // 
            // hastatc
            // 
            hastatc.DataPropertyName = "patient_identity_no";
            hastatc.HeaderText = "Hasta T.C.";
            hastatc.MinimumWidth = 6;
            hastatc.Name = "hastatc";
            hastatc.ReadOnly = true;
            // 
            // tarih
            // 
            tarih.DataPropertyName = "visit_date";
            tarih.HeaderText = "Ziyaret Tarihi";
            tarih.MinimumWidth = 6;
            tarih.Name = "tarih";
            tarih.ReadOnly = true;
            // 
            // teshis
            // 
            teshis.DataPropertyName = "diagnosis";
            teshis.HeaderText = "Teşhis";
            teshis.MinimumWidth = 6;
            teshis.Name = "teshis";
            teshis.ReadOnly = true;
            // 
            // recete
            // 
            recete.DataPropertyName = "medication";
            recete.HeaderText = "Reçete";
            recete.MinimumWidth = 6;
            recete.Name = "recete";
            recete.ReadOnly = true;
            // 
            // id
            // 
            id.DataPropertyName = "visit_id";
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // frmVisits
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 447);
            Controls.Add(dgwVisit);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmVisits";
            Text = "frmVisits";
            ((System.ComponentModel.ISupportInitialize)dgwVisit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgwVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastatc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn teshis;
        private System.Windows.Forms.DataGridViewTextBoxColumn recete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}