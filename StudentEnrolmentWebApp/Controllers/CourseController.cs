using Microsoft.AspNetCore.Mvc;

namespace StudentEnrolmentWebApp.Controllers
{
    public class CourseController : Controller
    {

        private readonly DatabaseContext _databaseContext;

        public CourseController(DatabaseContext databaseContext)
        {
                _databaseContext = databaseContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
