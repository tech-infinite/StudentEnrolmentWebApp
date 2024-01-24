using Microsoft.AspNetCore.Mvc;

namespace StudentEnrolmentWebApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Register
        //    [HttpPost]
        //    public IActionResult Register(string firstName, string lastName, string email, string username, string password, string department, string course)
        //    {
        //        // Registration logic goes here (e.g., save to the database)

        //        // For simplicity, redirect to login after registration
        //        return RedirectToAction("Login");
        //    }

        //    // GET: /Account/Login
        //    public IActionResult Login()
        //    {
        //        return View();
        //    }

        //    // POST: /Account/Login
        //    [HttpPost]
        //    public IActionResult Login(string username, string password)
        //    {
        //        // Login logic goes here (e.g., validate credentials)

        //        // For simplicity, redirect to home page after login
        //        return RedirectToAction("Index", "Home");
        //    }
        //}

    }
}
