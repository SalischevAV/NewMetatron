using NewMetatron.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewMetatron.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private Metatron db = new Metatron();
        public ActionResult Index()
        {
            return View(db.cdr_city.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}