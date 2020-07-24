using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Model
{
    public class LectureDate : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CourseId { get; set; }
    }
}
