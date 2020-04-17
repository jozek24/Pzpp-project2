using System;
using System.Collections.Generic;

namespace OSKManager.Model
{
    public class Student : User
    {
        public DateTime Birthdate { get; set; }
        public string PersonalIdNumber { get; set; }
        public List<string> PKK { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public List<int> CoursesId { get; set; }
        public List<Course> Courses { get; set; }
    }
}