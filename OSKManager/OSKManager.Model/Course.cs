using System;
using System.Collections.Generic;

namespace OSKManager.Model
{
    public class Course : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<DateTime> LectureDate { get; set; }
        public int PassedLectureHours { get; set; }
        public int PassedDrivingHours { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal ActualPrice { get; set; }
        public List<DateTime> DateOfLecture { get; set; }
        public List<DateTime> DateOfDriving { get; set; }
    }
}