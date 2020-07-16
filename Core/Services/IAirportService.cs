using Core.Models;

namespace Core.Services
{
    public interface IAirportService
    {
        public Airport Get(int id);
        public Airport GetByIataCode(string iataCode);
        public bool Put(Airport airport);
        public bool Delete(int id);
    }
}
