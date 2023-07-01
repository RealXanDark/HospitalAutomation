using desing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace desing
{
    public partial class frmTestResultWindow : Form
    {
        public frmTestResultWindow()
        {
            InitializeComponent();
            FormLoad();
        }
        private void FormLoad()
        {
            try
            {
                using (var db = new HospitalContext())
                {
                    var test = db.Tests
                        .Where(a => a.patient_identity_no == Global.patientidentityno)
                        .ToList();
                    dgwResult.DataSource = test;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Deneyin :(");
            }
        }
    }
}
