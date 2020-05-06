using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSKManager.Model
{
    public class Student : User
    {
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public string PersonalIdNumber { get; set; } //should be required

        public ICollection<PkkNumber> PkkNumber { get; set; }
        //public Instructor Instructor { get; set; }

        //public ICollection<Course> CoursesId { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}