using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class Hospital
    {
        public int hospital_id { get; set; }

        public string? hospital_name { get; set; }

        public string? hospital_phone_number { get; set; }

        public string? hospital_address { get; set; }

        public int hospital_province_id { get; set; }

        public int hospital_district_id { get; set; }
    }
}
