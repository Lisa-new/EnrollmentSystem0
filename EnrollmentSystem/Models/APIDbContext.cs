using Microsoft.EntityFrameworkCore;

namespace EnrollmentSystem.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
