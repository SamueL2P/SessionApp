using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private const string CorrectUsername = "testuser";
        private const string CorrectPassword = "password123";

   
        public ActionResult Login()
        {
            return View();
        }

    
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            
            if (username == CorrectUsername && password == CorrectPassword)
            {
         
                Session["User"] = username;
                Session["LoginTime"] = DateTime.Now;

            
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
        
                TempData["ErrorMessage"] = "Invalid username or password. Please try again.";
                return RedirectToAction("Login");
            }
        
             }
    }
}