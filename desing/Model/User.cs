using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing.Model
{
    public class User
    {

        public int user_id { get; set; }

        public string? user_identity_no { get; set; }

        public string? user_email { get; set; }

        public string? user_phone_number { get; set; }

        public string? user_password { get; set; }

        public int user_group_id { get; set; }

        
        


    }
}
