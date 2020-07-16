namespace Core.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Given { get; set; }
        public Flight Flight { get; set; }
    }
}
