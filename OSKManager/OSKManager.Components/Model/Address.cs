using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Components.Model
{
    public class Address : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string NumberOfTheBuilding { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
