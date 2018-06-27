using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObucaTanja.Models;


namespace ObucaTanja.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Img> images = new List<Img>
        {
            new Img{ Name = "modeli.jpg", Text="Man's infantri brow leather", Price=8990},
            new Img{ Name = "modeli.jpg", Text="Man's infantri brow leather", Price=8990},
            new Img{ Name = "modeli.jpg", Text="Man's infantri brow leather", Price=8990},
            new Img{ Name = "modeli.jpg", Text="Man's infantri brow leather", Price=8990},
            new Img{ Name = "modeli.jpg", Text="Man's infantri brow leather", Price=8990},
            new Img{ Name = "modeli.jpg", Text="Man's infantri brow leather", Price=8990}
        };

        [HttpGet]
        public ActionResult Index()
        {
            return View(images);
        }

        [HttpGet]
        public ActionResult Shop()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}