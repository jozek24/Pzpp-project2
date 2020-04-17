namespace OSKManager.Model
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public Gender Gender { get; set; }
    }
}