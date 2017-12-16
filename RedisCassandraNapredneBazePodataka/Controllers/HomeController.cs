using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedisCassandraNapredneBazePodataka.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Onama()
        {
            ViewBag.Message = "Your application Onama page.";

            return View();
        }

        public ActionResult Delatnosti()
        {
            ViewBag.Message = "Your Delatnosti page.";

            return View();
        }
    }
}