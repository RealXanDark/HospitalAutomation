using Microsoft.Data.SqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void pBoxReturn_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        public override void Refresh()
        {
            Methods.form = this;
            Methods.smallpanel = this.pnlSmall;
            Methods.bigpanel = this.pnlLoginPage;
            frmLogin frm = new frmLogin();
            Methods.OpenForms(frm, this.pnlSmall);
            DateTime now = DateTime.Now;
            label1.Text = "©" + now.Year.ToString() + " Han Hastaneleri Tüm Hakları Saklıdır.";
        }
    }
}
