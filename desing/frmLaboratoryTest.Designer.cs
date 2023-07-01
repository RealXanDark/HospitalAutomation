namespace desing
{
    partial class frmLaboratoryTest
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
            btnView = new System.Windows.Forms.Button();
            dgwTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwTest).BeginInit();
            SuspendLayout();
            // 
            // lblSelectedTest
            // 
            lblSelectedTest.AutoSize = true;
            lblSelectedTest.Location = new System.Drawing.Point(563, 410);
            lblSelectedTest.Name = "lblSelectedTest";
            lblSelectedTest.Size = new System.Drawing.Size(85, 20);
            lblSelectedTest.TabIndex = 63;
            lblSelectedTest.Text = "Seçili Test : ";
            // 
            // btnView
            // 
            btnView.BackColor = System.Drawing.Color.Brown;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnView.ForeColor = System.Drawing.Color.White;
            btnView.Location = new System.Drawing.Point(864, 391);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(291, 59);
            btnView.TabIndex = 62;
            btnView.Text = "Görüntüle";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // dgwTest
            // 
            dgwTest.AllowUserToAddRows = false;
            dgwTest.AllowUserToDeleteRows = false;
            dgwTest.BackgroundColor = System.Drawing.Color.White;
            dgwTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTest.Location = new System.Drawing.Point(12, 10);
            dgwTest.Name = "dgwTest";
            dgwTest.ReadOnly = true;
            dgwTest.RowHeadersWidth = 51;
            dgwTest.RowTemplate.Height = 29;
            dgwTest.Size = new System.Drawing.Size(1143, 375);
            dgwTest.TabIndex = 61;
            dgwTest.CellClick += dgwTest_CellClick;
            // 
            // frmLaboratoryTest
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(1167, 456);
            Controls.Add(lblSelectedTest);
            Controls.Add(btnView);
            Controls.Add(dgwTest);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmLaboratoryTest";
            Text = "frmLaboratoryTest";
            ((System.ComponentModel.ISupportInitialize)dgwTest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSelectedTest;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgwTest;
    }
}