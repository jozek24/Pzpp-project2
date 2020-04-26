using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Model
{
    public class LectureDate : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
    }
}
