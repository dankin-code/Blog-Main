using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Daniel's Blog.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me.";

            return View();
        }
    }
}