namespace Core.Models
{
    public class Airport
    {
        private static int id = 1;

        public int Id { get; }
        public string IataCode { get; set; }
        public string Name { get; set; }

        public Airport()
        {
            Id = GetNextId();
        }

        private static int GetNextId()
        {
            return id++;
        }
    }
}