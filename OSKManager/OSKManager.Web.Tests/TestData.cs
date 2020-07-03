using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSKManager.Web.Tests
{
    public static class TestData
    {
        public static IQueryable<DrivingDate> DrivingDates
        {
            get
            {
                return new List<DrivingDate>
                {
                    new DrivingDate 
                    { 
                        Id = Guid.Parse("AC761785-ED42-11CE-DACB-00BDD0057645"), 
                        CourseId = Guid.Parse("BC761785-ED42-11CE-DACB-00BDD0057645"), 
                        DateTime = DateTime.Now 
                    },
                    new DrivingDate 
                    { 
                        Id = Guid.Parse("CC761785-ED42-11CE-DACB-00BDD0057645"), 
                        CourseId = Guid.Parse("DC761785-ED42-11CE-DACB-00BDD0057645"), 
                        DateTime = DateTime.Now 
                    }
                }
                .AsQueryable();
            }
        }

        public static IQueryable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        Id = Guid.Parse("AC761785-ED42-11CE-DACB-00BDD0057645"),
                        ShortCategory = "A",
                        LongCategoryName = "Motocykl",
                        BasicPrice = 1500,
                        CountOfLectureHours = 30,
                        CountOfDrivingHours = 20
                    },
                    new Category
                    {
                        Id = Guid.Parse("BC761785-ED42-11CE-DACB-00BDD0057645"),
                        ShortCategory = "B",
                        LongCategoryName = "Samochód Osobowy",
                        BasicPrice = 1700,
                        CountOfLectureHours = 30,
                        CountOfDrivingHours = 30
                    },
                    new Category
                    {
                        Id = Guid.Parse("CC761785-ED42-11CE-DACB-00BDD0057645"),
                        ShortCategory = "C",
                        LongCategoryName = "Samochód Ciężarowy",
                        BasicPrice = 2600,
                        CountOfLectureHours = 20,
                        CountOfDrivingHours = 30
                    },
                    new Category
                    {
                        Id = Guid.Parse("DC761785-ED42-11CE-DACB-00BDD0057645"),
                        ShortCategory = "D",
                        LongCategoryName = "Autobus",
                        BasicPrice = 4800,
                        CountOfLectureHours = 20,
                        CountOfDrivingHours = 60
                    }
                }
                .AsQueryable();
            }
        }
    }
}
