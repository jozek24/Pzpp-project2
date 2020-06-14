using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Model.Entities
{
    public class InstructorsCategory
    {
        public string InstructorId { get; set; }
        public Instructor Instructor{ get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
