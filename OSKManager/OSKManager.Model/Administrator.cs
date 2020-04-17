using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSKManager.Model
{
    public class Administrator : User
    {
        public List<int> InstructorsId { get; set; }
        public List<Instructor> Instructor { get; set; }
        public List<Student> StudentsId { get; set; }
        public List<Student> Students { get; set; }

    }
}
