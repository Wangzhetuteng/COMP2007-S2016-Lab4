using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_Lab4.Controllers
{
    public class HomeController : Controller
    {
        public string SubTitle;

        //GET: /Home/Index or /
        public ActionResult Index()
        {
            this.SubTitle = "Hello World!";
            return View();
        }

        //GET: Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(SubTitle);
        }

        //GET: Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}