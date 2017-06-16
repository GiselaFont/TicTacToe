using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject.Data;

namespace WebProject.Models
{
    public class BuyCarViewModel
    {
        public List<Cars> BuyCars { get; set; } = new List<Cars>();

        public string sort { get; set; }

        public string all_makes { get; set; }

        public string all_models { get; set; }

        public int price { get; set; }

        public string transmission { get; set; }

    }
}