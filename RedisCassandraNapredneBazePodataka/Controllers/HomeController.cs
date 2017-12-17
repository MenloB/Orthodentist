using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CassandraDataLayer;

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

            return Content(DataProvider.GetUserByUsername("z3r0d4y").ToString());
        }

        public ActionResult GetUsers()
        {
            return Content(DataProvider.GetAllUsers()[0].ToString());
        }

        public ActionResult Delatnosti()
        {
            ViewBag.Message = "Your Delatnosti page.";

            return View();
        }
    }
}