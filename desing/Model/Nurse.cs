using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class Nurse
    {
        public int nurse_id { get; set; }
        public string? nurse_identity_no { get; set; }
        public string? nurse_name { get; set; }
        public string? nurse_surname { get; set; }
        public DateTime nurse_date_of_birth { get; set; }
        public string? nurse_gender { get; set; }
        public string? nurse_blood_group { get; set; }
        public string? nurse_email { get; set; }
        public string? nurse_phone_number { get; set; }
        public string? nurse_password { get; set; }
        public int nurse_hospital_id { get; set; }
        public int nurse_clinic_id { get; set; }
    }
}
