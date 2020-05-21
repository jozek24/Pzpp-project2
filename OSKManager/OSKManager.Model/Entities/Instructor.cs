using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSKManager.Model
{
    public class Instructor : User
    {
        public List<Category> CategoryPermissions { get; set; }
        public DateTime? LicenceExpireTime { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}