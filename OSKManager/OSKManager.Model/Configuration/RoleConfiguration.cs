using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OSKManager.Model.Configuration
{
    class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        private const string administratorId = "2301D884-221A-4E7D-B509-0113DCC043E1";
        private const string studentId = "7D9B7113-A8F8-4035-99A7-A20DD400F6A3";
        private const string instructorId = "78A7570F-3CE5-48BA-9461-80283ED1D94D";
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = studentId,
                    Name = "Student",
                    NormalizedName = "STUDENT"
                },
                new IdentityRole
                {
                    Id = instructorId,
                    Name = "Instructor",
                    NormalizedName = "INSTRUCTOR"
                },
                new IdentityRole
                {
                    Id = administratorId,
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });
        }
    }
}
