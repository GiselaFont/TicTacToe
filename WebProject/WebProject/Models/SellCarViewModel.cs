using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class SellCarViewModel
    {
        public String contact_name { get; set; }

        public String contact_email { get; set; }

       public String contact_phone { get; set; }

       public bool sell { get; set; }

       public bool tradein { get; set; }
    }
}