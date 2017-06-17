using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject.Data;

namespace WebProject.Models
{
    public class TicTacToeViewModel
    {
        public List<Tables> Table { get; set; } = new List<Tables>();

        public String cell11 { get; set; }

        public String cell12 { get; set; }

        public String cell13 { get; set; }

        public String cell21 { get; set; }

        public String cell22 { get; set; }

        public String cell23 { get; set; }

        public String cell31 { get; set; }

        public String cell32 { get; set; }

        public String cell33 { get; set; }
    }
}