using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTech.Website.Controllers
{
    public class FrenchiController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult App()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}