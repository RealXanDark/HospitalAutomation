using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class Doctor
    {
        public int doctor_id { get; set; }
        public string? doctor_identity_no { get; set; }
        public string? doctor_name { get; set; }
        public string? doctor_surname { get; set; }
        public DateTime? doctor_date_of_birth { get; set; }
        public string? doctor_gender { get; set; }
        public string? doctor_blood_group { get; set; }
        public string? doctor_email { get; set; }
        public string? doctor_phone_number { get; set; }
        public string? doctor_password { get; set; }
        public int doctor_hospital_id { get; set; }
        public int doctor_clinic_id { get; set; }
        public string? doctor_specialization_name{ get; set; }

        public string FullName => $"{doctor_specialization_name} {doctor_name} {doctor_surname}";

    }
}
