using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class ContactViewModel
    {
        public String contact_name { get; set; }

        public String contact_email { get; set; }

        public String contact_car { get; set; }

        public String contact_purpose { get; set; }

        public String contact_phone { get; set; }

        public String contact_message { get; set; }
    }
}