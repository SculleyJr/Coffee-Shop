using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootcampBeanery.Models;

namespace BootcampBeanery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult New()
        {

           
            ViewBag.Message = "Enter your information below to register";
            return View();
        }

        [HttpPost]
        public ActionResult New(Customer cust)
        {
            return RedirectToAction("ThankYou", cust);
        }

        public ActionResult ThankYou(Customer model)
        {
            return View(model);
        }

    

    }
}