using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Dashboard()
        {
       
            if (Session["User"] == null)
            {
                TempData["ErrorMessage"] = "You must log in to access the dashboard.";
                return RedirectToAction("Login", "Account");
            }

            ViewBag.User = Session["User"];
            return View();
        }
        public ActionResult CheckSession()
        {
            if (Session["User"] == null)
            {
                TempData["ErrorMessage"] = "Session timed out. Please log in again.";
                return RedirectToAction("Login", "Account");
            }
            
            return View();
        }
    }
}