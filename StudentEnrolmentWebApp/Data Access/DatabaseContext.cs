using Microsoft.EntityFrameworkCore;
using StudentEnrolmentWebApp.Models;

namespace StudentEnrolmentWebApp
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
                
        }

        // Creates the Student and Courses table automatically

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
