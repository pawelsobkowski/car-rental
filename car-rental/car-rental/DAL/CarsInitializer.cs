using car_rental.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace car_rental.DAL
{
    public class CarsInitializer : DropCreateDatabaseAlways<CarsContext>
    {
        protected override void Seed(CarsContext context)
        {
            SeedCars(context);
        }

        private void SeedCars(CarsContext context)
        {
            var categories = new List<Category>()
            {
                new Category
                {
                    CategoryID = 1,
                    Name = "Sport",
                    Description = "Sportowy samochód"
                }
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }

            context.SaveChanges();


        }
    }
}