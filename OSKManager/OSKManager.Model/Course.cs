using System;
using System.Collections.Generic;

namespace OSKManager.Model
{
    public class Course : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<DateTime> DateOfLecture { get; set; }
        public ICollection<DateTime> DateOfDriving { get; set; }
        public int FinishedLectureHours { get; set; }
        public int FinishedDrivingHours { get; set; }
        public decimal ActualPrice { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

    }
}