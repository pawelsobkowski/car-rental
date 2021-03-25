using car_rental.DAL;
using car_rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace car_rental.Controllers
{
    public class HomeController : Controller
    {
        CarsContext db = new CarsContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}