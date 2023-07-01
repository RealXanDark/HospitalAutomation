using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desing
{
    public partial class frmLaboratory : Form
    {
        public frmLaboratory()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name == "btnTests")
            {
                frmLaboratoryTest laboratoryTest = new frmLaboratoryTest();
                Methods.OpenForms(laboratoryTest, pnlMain);
                Methods.ChangeButtonColorInForm(this, btn);
            }
            else if (btn.Name == "btnAccount")
            {
                frmLabUser User = new frmLabUser();
                Methods.OpenForms(User, pnlMain);
                Methods.ChangeButtonColorInForm(this, btn);
            }
            else if (btn.Name == "btnLogOut")
            {
                Application.Restart();
                Methods.ChangeButtonColorInForm(this, btn);
            }
        }

        private void frmLaboratory_Load(object sender, EventArgs e)
        {
            btnTests.PerformClick();
        }
    }
}
