using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureTestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application is an Azure test for the Web Apps";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Azure Web App";

            return View();
        }
    }
}