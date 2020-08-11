using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthAutomationSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            /// Hasta bilgilerini güncelleyecebilecek.
            /// Hasta randevularını görebilecek.
            /// Hasta reçetelerini görebilecek.
            /// Doktor randevularını görebilecek.
            /// Doktor reçete yazabilecek.
            /// Doktor reçeteleri görebilecek.
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}