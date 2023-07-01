using desing.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmAppointment : Form
    {
        string? selectedDoctorIdentityNo;
        public frmAppointment()
        {
            InitializeComponent();
            dtpDate.MinDate = DateTime.Now;
            btnReviewAppointment.Enabled = false;
        }

        private void control_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (sender is ComboBox)
            //{
            //    ComboBox comboBox = (ComboBox)sender;
            //    RestartComboBox(comboBox);
            //    DisableOtherComboBoxes(comboBox);
            //}
            //else if (sender is DateTimePicker)
            //{
            //    DateTimePicker dtp = (DateTimePicker)sender;
            //    RestartComboBox(dtp);
            //    DisableOtherComboBoxes(dtp);
            //}
            int sayac = 0;
            ComboBox cb = (ComboBox)sender;
            if (cb == cbProvince && sayac == 1)
            {
                using (var db = new HospitalContext())
                {
                    var provincesWithBranch = db.Districts
            .Where(p => p.district_parent_id == (int)cbProvince!.SelectedValue!)
            .ToList();
                    cbDistrict.DataSource = provincesWithBranch;
                    cbDistrict.DisplayMember = "district_name";
                    cbDistrict.ValueMember = "district_id";
                }

            }
            else if (cb == cbDistrict)
            {

            }
            sayac++;
        }
        private void DisableOtherComboBoxes(Control selectedControl)
        {
            int selectedTag = int.Parse(selectedControl!.Tag!.ToString()!);

            foreach (Control control in this.Controls)
            {
                if (control is ComboBox || control is DateTimePicker)
                {
                    int controlTag = int.Parse(control!.Tag!.ToString()!);

                    if (control != selectedControl)
                    {
                        control.Enabled = controlTag <= selectedTag + 1;
                    }
                }
            }
        }
        private void RestartComboBox(Control selectedControl)
        {

            int selectedTag = int.Parse(selectedControl!.Tag!.ToString()!);

            foreach (Control control in this.Controls)
            {
                if (control is ComboBox || control is DateTimePicker)
                {
                    int controlTag = int.Parse(control!.Tag!.ToString()!);

                    if (control != selectedControl && controlTag > selectedTag)
                    {
                        if (control is ComboBox)
                        {
                            ((ComboBox)control).SelectedIndex = -1;
                        }
                        else if (control is DateTimePicker)
                        {
                            ((DateTimePicker)control).Value = DateTime.Now;
                        }
                    }
                }
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Global.appointmentdatetime = dtpDate.Value.ToShortDateString() + " " + cbTime.Text;
            Global.appointmentdate = DateTime.Parse(dtpDate.Value.ToString());
            Global.appointmenttime = cbTime.Text;
            Global.appointmentclinic = cbClinic.Text;
            Global.appointmenthospital = cbHospital.Text;
            Global.appointmentdoctor = cbDoctor.Text;
            Global.appointmentdoctoridentityno = selectedDoctorIdentityNo;
            frmAppointmentConfirmation confirmation = new frmAppointmentConfirmation();
            confirmation.StartPosition = FormStartPosition.CenterParent;
            confirmation.ShowDialog();
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            using (var db = new HospitalContext())
            {
                var provincesWithBranch = db.Provinces
        .Where(p => p.province_has_branch == 1)
        .ToList();
                cbProvince.DataSource = provincesWithBranch;
                cbProvince.DisplayMember = "province_name";
                cbProvince.ValueMember = "province_id";
                cbProvince.SelectedIndex = -1;
            }
            if (cbProvince.SelectedIndex == -1)
            {
                cbDistrict.Enabled = false;
                cbHospital.Enabled = false;
                cbDoctor.Enabled = false;
                cbClinic.Enabled = false;
                dtpDate.Enabled = false;
                cbTime.Enabled = false;
                btnReviewAppointment.Enabled = false;
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
                        .Where(d => d.district_parent_id == selectedProvince.province_id && d.district_has_branch == 1)
                        .ToList();
                    cbDistrict.DataSource = districtsWithBranch;
                    cbHospital.DataSource = null;
                    cbClinic.DataSource = null;
                    cbDoctor.DataSource = null;
                    cbDistrict.DisplayMember = "district_name";
                    cbDistrict.ValueMember = "district_id";
                    cbDistrict.SelectedIndex = -1;
                }
            }
            if (cbDistrict.SelectedIndex == -1)
            {
                cbHospital.Enabled = false;
                cbDoctor.Enabled = false;
                cbClinic.Enabled = false;
                dtpDate.Enabled = false;
                cbTime.Enabled = false;
                btnReviewAppointment.Enabled = false;
            }
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHospital.Enabled = true;
            if (cbDistrict.SelectedItem is District selectedDistrict)
            {
                using (var db = new HospitalContext())
                {
                    var hospitalsWithBranch = db.Hospitals
                        .Where(h => h.hospital_district_id == selectedDistrict.district_id)
                        .ToList();
                    cbHospital.DataSource = hospitalsWithBranch;
                    cbClinic.DataSource = null;
                    cbDoctor.DataSource = null;
                    cbHospital.DisplayMember = "hospital_name";
                    cbHospital.ValueMember = "hospital_id";
                    cbHospital.SelectedIndex = -1;
                }
            }
            if (cbHospital.SelectedIndex == -1)
            {
                cbDoctor.Enabled = false;
                cbClinic.Enabled = false;
                dtpDate.Enabled = false;
                cbTime.Enabled = false;
                btnReviewAppointment.Enabled = false;
            }
        }

        private void cbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClinic.Enabled = true;
            if (cbHospital.SelectedItem is Hospital selectedHospital)
            {
                using (var db = new HospitalContext())
                {
                    var clinicsWithBranch = db.Clinics
                        .Where(c => c.clinic_hospital_id == selectedHospital.hospital_id)
                        .ToList();
                    cbClinic.DataSource = clinicsWithBranch;
                    cbDoctor.DataSource = null;
                    cbClinic.DisplayMember = "clinic_name";
                    cbClinic.ValueMember = "clinic_id";
                    cbClinic.SelectedIndex = -1;
                }
            }
            if (cbClinic.SelectedIndex == -1)
            {
                cbDoctor.Enabled = false;
                dtpDate.Enabled = false;
                cbTime.Enabled = false;
                btnReviewAppointment.Enabled = false;
            }
        }

        private void cbClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDoctor.Enabled = true;
            if (cbClinic.SelectedItem is Clinic selectedClinic)
            {
                using (var db = new HospitalContext())
                {
                    var doctorsWithBranch = db.Doctors
                        .Where(d => d.doctor_clinic_id == selectedClinic.clinic_id)
                        .ToList();
                    cbDoctor.DataSource = doctorsWithBranch;
                    cbDoctor.DisplayMember = "FullName";
                    cbDoctor.ValueMember = "doctor_id";
                    cbDoctor.SelectedIndex = -1;
                }
            }
            if (cbDoctor.SelectedIndex == -1)
            {
                dtpDate.Enabled = false;
                cbTime.Enabled = false;
                btnReviewAppointment.Enabled = false;
            }
        }

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctor.SelectedItem is Doctor selectedDoctor)
            {
                selectedDoctorIdentityNo = selectedDoctor.doctor_identity_no;
            }
            dtpDate.Enabled = true;
            cbTime.Enabled = false;
            btnReviewAppointment.Enabled = false;

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            cbTime.Enabled = true;
            btnReviewAppointment.Enabled = false;
            using (var db = new HospitalContext())
            {
                DateTime selectedDate = dtpDate.Value.Date;

                var reservedTimes = db.Appointments
                    .Where(r => r.date == selectedDate && r.doctor_identity_no == selectedDoctorIdentityNo && r.status == "active")
                    .Select(r => r.time)
                    .ToList();

                var availableTimes = db.Times.ToList()
                    .Where(s => !reservedTimes.Contains(s.time))
                    .Select(s => s.time)
                    .ToList();

                cbTime.DataSource = availableTimes;
            }
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTime.SelectedIndex != -1)
            {
                btnReviewAppointment.Enabled = true;
            }
        }
    }
}
