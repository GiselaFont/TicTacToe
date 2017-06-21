using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebProject.Data
{
    public class Tables
    {
        [Key]
        public int Id { get; set; }
        public string cell11 { get; set; }

        public string cell12 { get; set; }

        public string cell13 { get; set; }

        public string cell21 { get; set; }

        public string cell22 { get; set; }

        public string cell23 { get; set; }

        public string cell31 { get; set; }

        public string cell32 { get; set; }

        public string cell33 { get; set; }

        public bool active { get; set; } = false;

        public string move { get; set; } = "O";

        public string winner { get; set; }

        public Tables()
        {

        }
    }
}