using Core.Lookups;
using Core.Models;
using Core.Services;

namespace Core.SeedData
{
    public class AirportSeeder
    {
        private readonly IAirportService _service;
        private readonly IAirportNameLookup _lookup;

        public AirportSeeder(
            IAirportService service,
            IAirportNameLookup lookup)
        {
            _service = service;
            _lookup = lookup;
        }

        public void Load()
        {
            _service.Put(new Airport { IataCode = "BOO", Name = _lookup.Lookup("BOO") });
        }
    }
}
