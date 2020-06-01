using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OSKManager.Model.Configuration
{
    class AdministratorAccountConfiguration : IEntityTypeConfiguration<Administrator>
    {
        private const string adminId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7";
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            var admin = new Administrator
            {
                Id = adminId,
                UserName = "Admin@Admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "Master",
                LastName = "Admin",
                Email = "Admin@Admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                LockoutEnabled = true,
                SecurityStamp = new Guid().ToString("D")
            };
            admin.PasswordHash = PassGenerate(admin);
            builder.HasData(admin);
        }
        public string PassGenerate(Administrator user)
        {
            var passHash = new PasswordHasher<Administrator>();
            return passHash.HashPassword(user, "Password");
        }
    }
}
