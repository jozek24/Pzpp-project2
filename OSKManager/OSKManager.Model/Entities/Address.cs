using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSKManager.Model
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