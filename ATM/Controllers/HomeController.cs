using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        // GET /home/index
        public ActionResult Index()
        {
            return View();
        }

        // GET /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            ViewBag.YourMessage = "Have trouble? Send us a message.";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO: send message 
            ViewBag.YourMessage = "Thanks, we got your message!";

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5NO1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
            //return new HttpStatusCodeResult(403);
            //return Json(new { name = "Serial", value = serial },
            //    JsonRequestBehavior.AllowGet);
            //return RedirectToAction("Index");

        }
    }
}