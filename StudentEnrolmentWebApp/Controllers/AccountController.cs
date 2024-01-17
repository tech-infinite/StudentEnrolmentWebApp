using Microsoft.AspNetCore.Mvc;

namespace StudentEnrolmentWebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login (string userName, string password)
        {
            if (IsValidUser(userName, password)) 
            {
                return RedirectToAction("Index", "Home");
            }

            else
            {
                ModelState.AddModelError("", "Username or password entered is valid");
                return View(); 
            }
        }

        private bool IsValidUser(string userName, string password) 
        {
            return(userName == "admin" || password == "password");
        }

        [HttpPost]
        public ActionResult Register(string userName, string password)
        {
            return RedirectToAction("Login");
        }
    }
}
