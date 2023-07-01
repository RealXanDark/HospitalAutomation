using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class Visit
    {
        public int visit_id { get; set; }
        public string? patient_identity_no { get; set; }
        public DateTime visit_date { get; set; }
        public string? diagnosis { get; set; }
        public string? medication { get; set; }
    }
}
