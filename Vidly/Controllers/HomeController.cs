using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MovieBank()
        {
            ViewBag.Message = "Movie List";

            var movie = new List<Movie>
            {
                new Movie { Name = "Movie A" },
                new Movie { Name = "Movie B" }
            };
            ViewBag.Movie = movie;

            return View();
        }

        public ActionResult Customers()
        {
            ViewBag.Message = "Customer List";

            var customers = new List<Customer>
            {
                new Customer { Name = "customer 1" },
                new Customer { Name = "customer 2" }
            };

            ViewBag.Customer = customers;


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}