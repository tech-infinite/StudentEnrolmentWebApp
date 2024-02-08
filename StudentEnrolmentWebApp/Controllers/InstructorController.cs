using Microsoft.AspNetCore.Mvc;

namespace StudentEnrolmentWebApp.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
