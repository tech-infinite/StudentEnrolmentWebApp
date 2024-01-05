using System.ComponentModel.DataAnnotations;

namespace StudentEnrolmentWebApp.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrolmentID { get; set; }
        public int StudentID { get; set;}
        public int CourseID { get; set; }
        public string GPA { get; set;}

        public DateTime EnrollmentDate { get; set; }
        public EnrollmentStatus Status { get; set; }


    }
}
