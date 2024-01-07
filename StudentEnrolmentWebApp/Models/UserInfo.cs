using System.ComponentModel.DataAnnotations;

namespace StudentEnrolmentWebApp.Models
{
    public class UserInfo
    {
        [Key]
        public int UserID { get; set; }
        public int GUID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }
    }
}
