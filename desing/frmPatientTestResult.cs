using desing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desing
{
    public partial class frmPatientTestResult : Form
    {
        public frmPatientTestResult()
        {
            InitializeComponent();
            FormLoad();
        }

        private void dgwTestResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSelectedTest.Text = "Seçili Test Id : " + dgwTestResult.CurrentRow.Cells[0].Value.ToString();
        }

        private void print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics? graphics = e.Graphics;
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float x = 0;
            float y = 0;

            List<string> selectedColumns = new List<string> { "testadi", "Tarih", "Sonuç", "doktorcevabi" }; 

            foreach (DataGridViewColumn column in dgwTestResult.Columns)
            {
                if (selectedColumns.Contains(column.Name))
                {
                    graphics?.DrawString(column.HeaderText, font, brush, x, y);
                    x += column.Width;
                }
            }

            y += font.Height;

            foreach (DataGridViewRow row in dgwTestResult.SelectedRows)
            {
                x = 10;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (selectedColumns.Contains(dgwTestResult.Columns[cell.ColumnIndex].Name))
                    {
                        graphics?.DrawString(cell.Value.ToString(), font, brush, x, y);
                        x += dgwTestResult.Columns[cell.ColumnIndex].Width;
                    }
                }
                y += font.Height;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = print;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                print.Print();
            }
        }
        private void FormLoad()
        {
            try
            {
                using (var db = new HospitalContext())
                {
                    var today = DateTime.Today;

                    var test = db.Tests
                        .Where(a => a.patient_identity_no == Global.patientidentityno)
                        .ToList();
                    dgwTestResult.DataSource = test;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Deneyin :(");
            }
        }
    }
}
