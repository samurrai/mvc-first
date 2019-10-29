using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Columns()
        {
            return View();
        }

        public ActionResult LeftSideBar()
        {
            return View();
        }

        public ActionResult RightSideBar()
        {
            return View();
        }

        public ActionResult WithoutSideBar()
        {
            return View();
        }
    }
}