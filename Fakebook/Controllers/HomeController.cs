using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fakebook.Controllers
{
    public class HomeController : Controller
    {
        private DbContext db;

        public HomeController(DbContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
