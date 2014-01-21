using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarlaCapstone.Controllers
{
    public class GuestBookController : Controller
    {
        //
        // GET: /GuestBook/
        public ActionResult Index()
        {
            return View();
        }
	}
}