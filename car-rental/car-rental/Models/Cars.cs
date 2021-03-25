using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace car_rental.Models
{
    public class Cars
    {
        [Required(ErrorMessage = "Input car ID")]
        public int CarsID { get; set; }

        [Required(ErrorMessage = "Input car brand")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Input car model")]
        public string Model { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
        
        public decimal Price { get; set; }
        public DateTime AddDate { get; set; }
        public int CategoryID { get; set; }
        public virtual Categories Category { get; set; }
    }
}