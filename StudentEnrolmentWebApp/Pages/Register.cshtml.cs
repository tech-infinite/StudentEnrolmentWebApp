using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentEnrolmentWebApp.Pages
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            // This method handles HTTP POST requests
            // You can add your registration logic here (e.g., save to the database)

            // For simplicity, redirect to login after registration
            RedirectToPage("/Login");
        }
    }
}
