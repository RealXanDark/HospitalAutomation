using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class Patient
    {
        public int patient_id { get; set; }
        public string? patient_identity_no { get; set; }
        public string? patient_name { get; set; }
        public string? patient_surname { get; set; }
        public DateTime? patient_date_of_birth { get; set; }
        public string? patient_gender { get; set; }
        public string? patient_blood_group { get; set; }
        public string? patient_email { get; set; }
        public string? patient_phone_number { get; set; }
        public string? patient_password { get; set; }
    }
}
