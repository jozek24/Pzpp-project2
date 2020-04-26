using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OSKManager.Model.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.NewGuid(),
                    ShortCategory = "A",
                    LongCategoryName = "Motocykl",
                    BasicPrice = 1500,
                    CountOfLectureHours = 30,
                    CountOfDrivingHours = 20
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    ShortCategory = "B",
                    LongCategoryName = "Samochód Osobowy",
                    BasicPrice = 1700,
                    CountOfLectureHours = 30,
                    CountOfDrivingHours = 30
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    ShortCategory = "C",
                    LongCategoryName = "Samochód Ciężarowy",
                    BasicPrice = 2600,
                    CountOfLectureHours = 20,
                    CountOfDrivingHours = 30
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    ShortCategory = "D",
                    LongCategoryName = "Autobus",
                    BasicPrice = 4800,
                    CountOfLectureHours = 20,
                    CountOfDrivingHours = 60
                }
            );
        }
    }
}
