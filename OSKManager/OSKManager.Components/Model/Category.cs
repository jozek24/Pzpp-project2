using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Components.Model
{
    public class Category : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string ShortCategory { get; set; }
        public string LongCategoryName { get; set; }
        public decimal BasicPrice { get; set; }
        public int CountOfLectureHours { get; set; }
        public int CountOfDrivingHours { get; set; }
        public ICollection<InstructorsCategory> InstructorsCategories { get; set; }
    }
}
