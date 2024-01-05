using System.ComponentModel.DataAnnotations;

namespace StudentEnrolmentWebApp.Models
{
    public class Instructor
    {
        [Key] 
        public int InstructorID { get; set; }
        public string InstructorName { get; set;}
        public string Subject { get; set; }
        public string Designation { get; set;}
        public string Phone { get; set;}
        public string InstructorEmail { get; set;}
        
    }
}
