using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentEnrolmentWebApp.Models;

namespace StudentEnrolmentWebApp.Pages
{
    public class DepartmentModel : PageModel
    {
        private readonly DatabaseContext _databaseContext;
        public DepartmentModel(DatabaseContext context)
        {
                _databaseContext = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }


        [BindProperty]
        public Department Department { get; set; } = default!;
    }
}
