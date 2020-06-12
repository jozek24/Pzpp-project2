using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OSKManager.Model.Entities;

namespace OSKManager.Model
{
    public class Category : IEntity<Guid>
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string ShortCategory { get; set; }

        [MaxLength(100)]
        public string LongCategoryName { get; set; }

        public decimal BasicPrice { get; set; }

        public int CountOfLectureHours { get; set; }

        public int CountOfDrivingHours { get; set; }

        public ICollection<InstructorsCategory> InstructorsCategories { get; set; }
    }
}