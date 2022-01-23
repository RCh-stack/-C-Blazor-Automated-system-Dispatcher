using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class CarModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name too long.")]
        [MinLength(5, ErrorMessage = "Name too short.")]
        public string Fullname { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The brand name is too long.")]
        [MinLength(3, ErrorMessage = "The brand name is too short.")]
        public string Brand { get; set; }

        [Range(20, 120, ErrorMessage = "Average speed range from 20 to 120.")]
        public int Speed { get; set; }

        [Range(10, 10000, ErrorMessage = "Capacity range from 10 to 10000.")]
        public int Capacity { get; set; }
    }
}
