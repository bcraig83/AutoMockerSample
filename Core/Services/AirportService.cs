using Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services
{
    public class AirportService : IAirportService
    {
        private readonly IDictionary<int, Airport> _dataStore = new Dictionary<int, Airport>();

        public bool Delete(int id)
        {
            var result = _dataStore.Remove(id);
            return result;
        }

        public Airport Get(int id)
        {
            var exists = _dataStore.TryGetValue(id, out var result);

            if (exists)
            {
                return result;
            }

            return null;
        }

        public Airport GetByIataCode(string iataCode)
        {
            var allAirports = _dataStore.Values;

            var matchingAirports = allAirports.Where(x => x.IataCode == iataCode);

            return matchingAirports.First();
        }

        public bool Put(Airport airport)
        {
            // TODO: handle errors
            _dataStore.Add(airport.Id, airport);

            return true;
        }
    }
}
