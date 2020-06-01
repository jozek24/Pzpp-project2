using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Model.Entities
{
     public  class WorkClass : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<LectureDate> DateOfLecture { get; set; }
        
    }
}
