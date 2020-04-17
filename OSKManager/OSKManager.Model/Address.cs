namespace OSKManager.Model
{
    public class Address : IEntity<int>
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string NumberOfTheBuilding { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}