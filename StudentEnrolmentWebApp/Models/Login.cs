using System.ComponentModel.DataAnnotations;

namespace StudentEnrolmentWebApp.Models
{
    public class Login
    {
        [Key]
        public int StudentID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
