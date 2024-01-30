using Microsoft.AspNetCore.Mvc;

namespace StudentEnrolmentWebApp.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        public RegistrationController(DatabaseContext databaseContext) 
        {
            _databaseContext = databaseContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
