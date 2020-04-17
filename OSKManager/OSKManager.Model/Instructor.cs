using System;
using System.Collections.Generic;

namespace OSKManager.Model
{
    public class Instructor : User
    {
        public List<Category> CategoryPermissions { get; set; }
        public DateTime LicenceExpireTime { get; set; }
        public List<int> StudentsId { get; set; }
        public List<Student> Students { get; set; }
    }
}