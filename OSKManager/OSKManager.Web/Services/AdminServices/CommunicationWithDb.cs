using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Services.AdminServices
{
    public class CommunicationWithDb
    {
        public string[] GetNameOfRolesFromDb()
        {
            return new []{ "Administrator", "Instructor", "Student" };
        }
    }
}
