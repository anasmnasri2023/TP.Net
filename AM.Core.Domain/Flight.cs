using System;
using System.Collections.Generic;

namespace AM.Core.Domain
{
    public class Flight : Passenger
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public Plane MyPlane { get; set; }
        public List<Passenger> Passengers { get; set; } = new List<Passenger>();

        public override string ToString()
        {
            return $"FlightId: {FlightId}, Destination: {Destination}, Departure: {Departure}, " +
                   $"FlightDate: {FlightDate}, EffectiveArrival: {EffectiveArrival}, " +
                   $"EstimatedDuration: {EstimatedDuration} min, " +
                   $"Plane: {(MyPlane != null ? MyPlane.ToString() : "No plane assigned")}, " +
                   $"Passengers: {Passengers.Count} on board";
        }
    }
}
