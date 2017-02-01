using AutoCompleteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCompleteMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAll()
        {
            var model = new List<Product>
            {
                new Product {Name="HP",Price=20000 },
                 new Product {Name="Sony",Price=30000 },
                  new Product {Name="Vaio",Price=40000 },
                   new Product {Name="Lennovo",Price=50000 },
            };
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}