using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIHelpers.Sample.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to the MVC UI Helpers Sample Project!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Content()
        {
            return View();
        }
    }
}
