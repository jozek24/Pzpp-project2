using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OSKManager.Model.Configuration;

namespace OSKManager.Model
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) 
            : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Student>()
            //    .ToTable("Student")
            //    .HasDiscriminator<string>("Student");

            //modelBuilder.Entity<User>()
            //    .HasDiscriminator<int>("UserType")
            //    .HasValue<Administrator>(1)
            //    .HasValue<Instructor>(2)
            //    .HasValue<Student>(3);


            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

        }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students{ get; set; }
    }
}
