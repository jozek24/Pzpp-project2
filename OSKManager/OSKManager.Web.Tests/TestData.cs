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
    }
}
