using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ClaimModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name too long.")]
        [MinLength(3, ErrorMessage = "Name too short.")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The address is too long.")]
        [MinLength(10, ErrorMessage = "The address is too short.")]
        public string Loading { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The address is too long.")]
        [MinLength(10, ErrorMessage = "The address is too short.")]
        public string Unloading { get; set; }

        [Required]
        [Range(0, 1000000000, ErrorMessage = "Too small amount.")]
        public float Payment { get; set; }

        [Required]
        [Range(0, 10000, ErrorMessage = "Too little weight.")]
        public int Weight { get; set; }

        public DateTime Date { get; set; }
        public DateTime Ending { get; set; }

        public string PointXStart { get; set; }
        public string PointYStart { get; set; }
        public string PointXEnd { get; set; }
        public string PointYEnd { get; set; }
    }
}
