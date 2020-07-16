using System;

namespace Core.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierName { get; set; }
        public string Number { get; set; }
        public Airport Origin { get; set; }
        public Airport Destination { get; set; }
        public DateTime ScheduledTimeOfOperation { get; set; }
        public bool IsArrival { get; set; }
    }
}
