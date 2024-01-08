using Microsoft.AspNetCore.Mvc;

namespace StudentEnrolmentWebApp.Controllers
{
    public class LoginController : Controller
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
            { return View(); }
        }

        private bool IsValidUser(string userName, string password) 
        {
            return(userName == "admin" || password == "password");
        }
    }
}
