using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Components.Model
{
    public class Instructor : User
    {
        public DateTime? LicenceExpireTime { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<InstructorsCategory> InstructorsCategories { get; set; }
    }
}
