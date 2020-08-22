using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Components.Model
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }
        public Gender Gender { get; set; }
    }
}
