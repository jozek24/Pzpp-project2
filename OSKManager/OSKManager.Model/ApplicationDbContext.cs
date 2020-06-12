using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OSKManager.Model.Configuration;
using OSKManager.Model.Entities;

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

            modelBuilder.Entity<InstructorsCategory>()
                .HasKey(bc => new { bc.InstructorId, bc.CategoryId });
            modelBuilder.Entity<InstructorsCategory>()
                .HasOne(bc => bc.Instructor)
                .WithMany(b => b.InstructorsCategories)
                .HasForeignKey(bc => bc.InstructorId);
            modelBuilder.Entity<InstructorsCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.InstructorsCategories)
                .HasForeignKey(bc => bc.CategoryId);

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new AdministratorAccountConfiguration());
            modelBuilder.ApplyConfiguration(new UsersWithRolesConfiguration());

        }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<InstructorsCategory> InstructorsCategories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<WorkClass> WorkClasses{ get; set; }


    }
}
