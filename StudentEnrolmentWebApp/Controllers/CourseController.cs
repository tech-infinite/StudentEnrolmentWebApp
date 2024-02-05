using Microsoft.AspNetCore.Mvc;
using StudentEnrolmentWebApp.Models;

namespace StudentEnrolmentWebApp.Controllers
{
    public class CourseController : Controller
    {

        private readonly DatabaseContext _databaseContext;

        public CourseController(DatabaseContext databaseContext)
        {
                _databaseContext = databaseContext;
        }

        
        public IActionResult Index()
        {
            List<Course> courses = _databaseContext.Courses.ToList();
            return View(courses);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course courseObj)
        {
            return View();
        }
    }
}
