using car_rental.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace car_rental.DAL
{
    public class CarsContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}