using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Model
{
    public class PkkNumber : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Pkk { get; set; }
    }
}
