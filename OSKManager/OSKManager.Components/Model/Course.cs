using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Components.Model
{
    public class Course : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<LectureDate> DateOfLecture { get; set; }
        public ICollection<DrivingDate> DateOfDriving { get; set; }
        public int FinishedLectureHours { get; set; }
        public int FinishedDrivingHours { get; set; }
        public decimal ActualPrice { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public bool IsStarted { get; set; }
    }
}
