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
    }
}