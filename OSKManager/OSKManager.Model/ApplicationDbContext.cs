using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OSKManager.Model.Configuration;

namespace OSKManager.Model
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) 
            : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses{ get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students{ get; set; }
    }
}
