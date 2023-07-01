using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class District
    {
        public int district_id { get; set; }
        public string? district_name { get; set; }
        public int district_parent_id { get; set; }
        public int district_has_branch { get; set; }
    }
}
