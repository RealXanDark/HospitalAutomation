using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class Lab
    {
        public int lab_id { get; set; }
        public string? lab_identity_no { get; set; }
        public string? lab_name { get; set; }
        public string? lab_surname { get; set; }
        public DateTime lab_date_of_birth { get; set; }
        public string? lab_gender { get; set; }
        public string? lab_blood_group { get; set; }
        public string? lab_email { get; set; }
        public string? lab_phone_number { get; set; }
        public string? lab_password { get; set; }
        public int lab_hospital_id { get; set; }
    }
}
