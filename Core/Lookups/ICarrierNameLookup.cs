namespace Core.Lookups
{
    public interface ICarrierNameLookup
    {
        public string Lookup(string iataCode);
    }
}
