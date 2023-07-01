using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class Appointment
    {
        public int appointment_id { get; set; }


        public string? patient_identity_no { get; set; }

        public string? doctor_identity_no { get; set; }

        public DateTime date { get; set; }

        public string? time { get; set; }

        public string? status { get; set; }
    }
}
