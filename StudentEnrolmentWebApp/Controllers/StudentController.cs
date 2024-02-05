using Microsoft.AspNetCore.Mvc;

namespace StudentEnrolmentWebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        public StudentController(DatabaseContext databaseContext)
        {
                _databaseContext = databaseContext;
        }

       
      
    }
}
