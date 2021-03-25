using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace car_rental.Models
{
    public class Category
    {
        public ICollection<Car> Cars { get; set; }

        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}