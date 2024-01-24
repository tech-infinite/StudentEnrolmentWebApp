using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEnrolmentWebApp;
using StudentEnrolmentWebApp.Models;

namespace StudentEnrolmentWebApp.Pages
{
    public class UserInfoModel : PageModel
    {
        private readonly StudentEnrolmentWebApp.DatabaseContext _context;

        public UserInfoModel(StudentEnrolmentWebApp.DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UserInfo UserInfo { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.UserInfo == null || UserInfo == null)
            {
                return Page();
            }

            _context.UserInfo.Add(UserInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
