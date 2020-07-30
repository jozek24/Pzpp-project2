using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Components.Model
{
    public class DrivingDate : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }

        public Guid CourseId { get; set; }
    }
}
