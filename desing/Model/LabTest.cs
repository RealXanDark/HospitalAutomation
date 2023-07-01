using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class LabTest
    {
        public int test_id { get; set; }

        public string? patient_identity_no { get; set; }

        public string? test_name { get; set; }

        public DateTime date { get; set; }

        public string? result { get; set; }

        public string? remarks { get; set; }

        public byte doctor_control { get; set; }
    }
}
