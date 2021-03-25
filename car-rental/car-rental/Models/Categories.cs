using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace car_rental.Models
{
    public class Categories
    {
        public ICollection<Cars> Cars { get; set; }

        [Required(ErrorMessage = "Input category ID")]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}