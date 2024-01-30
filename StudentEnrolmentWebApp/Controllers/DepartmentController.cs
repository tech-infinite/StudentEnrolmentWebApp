using Microsoft.AspNetCore.Mvc;

namespace StudentEnrolmentWebApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        public DepartmentController(DatabaseContext databaseContext) 
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
