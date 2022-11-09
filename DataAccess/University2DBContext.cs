using Microsoft.EntityFrameworkCore;
using University2.Models.DataModels;

namespace University2.DataAccess
{
    public class University2DBContext: DbContext
    {
        public University2DBContext(DbContextOptions<University2DBContext> options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
