using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OSKManager.Model.Entities;

namespace OSKManager.Model
{
    public class Instructor : User
    {
        public DateTime? LicenceExpireTime { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<InstructorsCategory> InstructorsCategories { get; set; }
    }
}