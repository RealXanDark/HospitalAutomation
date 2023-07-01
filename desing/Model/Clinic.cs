using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class Clinic
    {
        public int clinic_id { get; set; }

        public string? clinic_name { get; set; }

        public string? clinic_phone_number { get; set; }

        public string? clinic_address { get; set; }

        public int clinic_hospital_id { get; set; }
    }
}
