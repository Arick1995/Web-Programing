````c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            ViewBag.message = "I m here";
            return View("~/Views/Home/Index");
        }
        public ActionResult Browse()
        {
            ViewBag.message = "I m here";
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}
