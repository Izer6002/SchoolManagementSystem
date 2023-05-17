using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Context
{
    public class SchoolManagementSystemDbContext : DbContext
    {
        public SchoolManagementSystemDbContext(DbContextOptions<SchoolManagementSystemDbContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }
}
