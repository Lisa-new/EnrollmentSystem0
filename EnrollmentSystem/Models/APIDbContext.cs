using Microsoft.EntityFrameworkCore;

namespace EnrollmentSystem.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Users> Student1 { get; set; }

    }
}
