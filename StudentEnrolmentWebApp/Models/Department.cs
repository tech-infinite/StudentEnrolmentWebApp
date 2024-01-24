using System.ComponentModel.DataAnnotations;

namespace StudentEnrolmentWebApp.Models
{
    public class Department
    {
        [Key]
        public string DeptID { get; set; }
        public string CourseID { get; set; }

        public string CourseName { get; set; }

    }
}
