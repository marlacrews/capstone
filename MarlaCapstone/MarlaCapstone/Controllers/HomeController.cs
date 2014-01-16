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

        public ActionResult Bryan()
        {
            ViewBag.Message = "Bryan County";

            return View();
        }

        public ActionResult Bulloch()
        {
            ViewBag.Message = "Bulloch County";

            return View();
        }

        public ActionResult Candler()
        {
            ViewBag.Message = "Candler County";

            return View();
        }

        public ActionResult Comcast()
        {
            ViewBag.Message = "Comcast Services";

            return View();
        }

        public ActionResult Evans()
        {
            ViewBag.Message = "Evans County";

            return View();
        }

        public ActionResult InternetCafe()
        {
            ViewBag.Message = "Internet Cafe";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Products";

            return View();
        }

        public ActionResult Tattnall()
        {
            ViewBag.Message = "Tattnall";

            return View();
        }

        public ActionResult Toombs()
        {
            ViewBag.Message = "Toombs County";

            return View();
        }
    }
}