using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSKManager.Components.Model
{
    public class Student : User
    {
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public string PersonalIdNumber { get; set; }
        public ICollection<PkkNumber> PkkNumber { get; set; }
        //public Instructor Instructor { get; set; }
        //public ICollection<Course> CoursesId { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
