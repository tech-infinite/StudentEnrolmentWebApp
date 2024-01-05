using System.ComponentModel.DataAnnotations;

namespace StudentEnrolmentWebApp.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        
        [Required(ErrorMessage = "First name is required"), StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required"), StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
