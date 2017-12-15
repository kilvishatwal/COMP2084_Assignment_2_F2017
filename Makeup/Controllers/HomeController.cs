using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Makeup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This web app lets you to create brands and add their products.";

            return View();
        }

        public ActionResult Contact()
        {
            
            return View();
        }
    }
}