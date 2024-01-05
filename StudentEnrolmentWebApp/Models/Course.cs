using System.ComponentModel.DataAnnotations;

namespace StudentEnrolmentWebApp.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int Credits { get; set; }
    }
}
