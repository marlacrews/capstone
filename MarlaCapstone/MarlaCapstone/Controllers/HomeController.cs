using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarlaCapstone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About The Company";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page";

            return View();
        }

        public ActionResult LocalEvents()
        {
            ViewBag.Message = "Local Events";

            return View();
        }

        
    }
}