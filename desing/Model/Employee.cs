using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class Employee
    {
        public int employee_id { get; set; }
        public string? employee_identity_no { get; set; }
        public string? employee_name { get; set; }
        public string? employee_surname { get; set; }
        public DateTime employee_date_of_birth { get; set; }
        public string? employee_gender { get; set; }
        public string? employee_blood_group { get; set; }
        public string? employee_email { get; set; }
        public string? employee_phone_number { get; set; }
        public string? employee_password { get; set; }
        public int employee_hospital_id { get; set; }
    }
}
