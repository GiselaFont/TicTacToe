using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebProject.Data
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Make { get; set; }
        [MaxLength(50)]
        public string Model { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        [Required]
        [MaxLength(20)]
        public string Color { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [MaxLength(20)]
        public string Transmission { get; set; }
        [Required]
        public int Milage { get; set; }
        [Required]
        public int Price { get; set; }
        [MaxLength(300)]
        public string description { get; set; }
        
        public Cars()
        {

        }
    }
}