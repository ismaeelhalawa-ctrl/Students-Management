using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StudentsManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Teacher> Teachers { get; set; }
        public DbSet<Models.Course> Courses { get; set; }
        }
}
