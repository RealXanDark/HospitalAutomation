using desing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace desing
{
    public partial class frmHospitals : Form
    {
        int provinceid, districtid, hospitalprovinceid, hospitaldistrictid, hospitalid;
        int updateprovince, updatedistrict;
        public frmHospitals()
        {
            InitializeComponent();
            FormLoad();
        }

        private void btnSaveMode_Click(object sender, EventArgs e)
        {
            btnSaveUpdate.Text = "Kaydet";
            lblInformation.Text = "Hastane Kaydetme Modu";
            lblInformation.ForeColor = Color.Brown;
            foreach (Control control in Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "1")
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Text = string.Empty;
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.SelectedIndex = -1;
                    }
                }
            }
        }

        private void btnUpdateMode_Click(object sender, EventArgs e)
        {
            btnSaveUpdate.Text = "Güncelle";
            lblInformation.Text = "Hastane Güncelleme Modu";
        }
        private void FormLoad()
        {
            lblInformation.ForeColor = Color.Red;
            using (var db = new HospitalContext())
            {
                var provincesWithBranch = db.Provinces.OrderBy(p => p.province_name)
        .ToList();
                cbProvince.DataSource = provincesWithBranch;
                cbProvince.DisplayMember = "province_name";
                cbProvince.ValueMember = "province_id";
                cbProvince.SelectedIndex = -1;
            }
            using (var db = new HospitalContext())
            {

                var hospital = db.Hospitals
                    .ToList();
                dgwHospitals.DataSource = hospital;
            }

        }
        private void LoadDGW()
        {
            using (var db = new HospitalContext())
            {

                var hospital = db.Hospitals
                    .ToList();
                dgwHospitals.DataSource = hospital;
            }
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrict.Enabled = true;
            if (cbProvince.SelectedItem is Province selectedProvince)
            {
                using (var db = new HospitalContext())
                {
                    var districtsWithBranch = db.Districts
                        .Where(d => d.district_parent_id == selectedProvince.province_id).OrderBy(d => d.district_name)
                        .ToList();
                    cbDistrict.DataSource = districtsWithBranch;
                    cbDistrict.DisplayMember = "district_name";
                    cbDistrict.ValueMember = "district_id";
                    cbDistrict.SelectedIndex = -1;
                }
                updateprovince = selectedProvince.province_id;
            }
            if (cbProvince.SelectedIndex == -1)
            {
                cbDistrict.Enabled = false;
            }

        }

        private void frmHospitals_Load(object sender, EventArgs e)
        {
            btnSaveMode.PerformClick();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (cbProvince.SelectedItem is Province selectedProvince && cbDistrict.SelectedItem is District selectedDistrict)
            {
                provinceid = selectedProvince.province_id;
                districtid = selectedDistrict.district_id;
            }
            if (btnSaveUpdate.Text == "Kaydet")
            {
                using (var ctx = new HospitalContext())
                {
                    var hospital = new Hospital { hospital_name = txtName.Text.Trim(), hospital_phone_number = txtPhoneNumber.Text.Trim(), hospital_address = txtAdress.Text.Trim(), hospital_province_id = provinceid, hospital_district_id = districtid };
                    ctx.Hospitals.Add(hospital);
                    int sonuc = ctx.SaveChanges();
                    lblInformation.Text = sonuc > 0 ? "Kayıt Başarılı" : "Kayıt Sırasında Hata Oluştu";
                    lblInformation.ForeColor = sonuc > 0 ? Color.Green : Color.Red;
                }
            }
            else if (btnSaveUpdate.Text == "Güncelle")
            {
                MessageBox.Show(hospitalid.ToString());
                using (var context = new HospitalContext())
                {
                    var hospital = context.Hospitals.FirstOrDefault(u => u.hospital_id == hospitalid); 

                    if (hospital != null)
                    {
                        hospital.hospital_name = txtName.Text.Trim();
                        hospital.hospital_phone_number = txtPhoneNumber.Text.Trim();
                        hospital.hospital_address = txtAdress.Text.Trim();
                        hospital.hospital_province_id = updateprovince;
                        hospital.hospital_district_id = updatedistrict;
                        int sonuc = context.SaveChanges();
                        lblInformationUpdate.Text = sonuc > 0 ? "Güncelleme Başarılı" : "Güncelleme Sırasında Hata Oluştu";
                        lblInformationUpdate.ForeColor = sonuc > 0 ? Color.Green : Color.Red;
                    }
                }
            }
            LoadDGW();

        }
        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDistrict.SelectedItem is District selectedDistrict)
            {
                updatedistrict = selectedDistrict.district_id;
            }
        }

        private void dgwHospitals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSaveUpdate.Text == "Güncelle")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgwHospitals.Rows[e.RowIndex];
                    txtName.Text = row.Cells["hospital_name"].Value.ToString();
                    txtPhoneNumber.Text = row.Cells["hospital_phone_number"].Value.ToString();
                    txtAdress.Text = row.Cells["hospital_address"].Value.ToString();
                    hospitalid = int.Parse(row.Cells["hospital_id"].Value.ToString() ?? string.Empty);
                    hospitalprovinceid = int.Parse(row.Cells["hospital_province_id"].Value.ToString() ?? string.Empty);
                    hospitaldistrictid = int.Parse(row.Cells["hospital_district_id"].Value.ToString() ?? string.Empty);

                    using (var db = new HospitalContext())
                    {
                        var provinces = db.Provinces.OrderBy(p => p.province_name).ToList();
                        cbProvince.DataSource = provinces;
                        cbProvince.DisplayMember = "province_name";
                        cbProvince.ValueMember = "province_id";
                        cbProvince.Text = db.Provinces.FirstOrDefault(p => p.province_id == hospitalprovinceid)?.province_name;

                        var districts = db.Districts.Where(d => d.district_parent_id == hospitalprovinceid).OrderBy(d => d.district_name).ToList();
                        cbDistrict.DataSource = districts;
                        cbDistrict.DisplayMember = "district_name";
                        cbDistrict.ValueMember = "district_id";
                        cbDistrict.Text = db.Districts.FirstOrDefault(d => d.district_id == hospitaldistrictid)?.district_name;
                    }
                }
            }
        }

    }
}
