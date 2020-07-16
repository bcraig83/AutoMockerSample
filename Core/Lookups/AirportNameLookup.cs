using System.Collections.Generic;

namespace Core.Lookups
{
    public class AirportNameLookup : IAirportNameLookup
    {
        private readonly IDictionary<string, string> _dataStore;

        public AirportNameLookup()
        {
            _dataStore = new Dictionary<string, string>
            {
                { "BOO", "Bodo Airport" },
                { "DUB", "Dublin Airport" },
                { "MAD", "Madrid Airport" },
                { "WOW", "Willow Airport" },
            };
        }

        public string Lookup(string code)
        {
            var exists = _dataStore.TryGetValue(code.ToUpper(), out string result);

            if (exists)
            {
                return result;
            }

            return "";
        }
    }
}
