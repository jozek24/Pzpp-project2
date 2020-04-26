using Microsoft.EntityFrameworkCore;

namespace OSKManager.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base (options)
        {
            
        }
        public DbSet<Address> Addresses{ get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<User> Users{ get; set; }
    }
}
