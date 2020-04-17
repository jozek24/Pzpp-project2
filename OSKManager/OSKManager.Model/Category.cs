namespace OSKManager.Model
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string ShortCategory { get; set; }
        public string CategoryName { get; set; }
        public decimal BasicPrice { get; set; }
        public int CountOfLectureHours { get; set; }
        public int CountOfDrivingHours { get; set; }
    }
}