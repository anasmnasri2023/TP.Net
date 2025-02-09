using System;
using System.Collections.Generic;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boing,
        Airbus
    }

    public class Plane
    {
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public override string ToString()
        {
            return $"PlaneId: {PlaneId}, Type: {MyPlaneType}, Capacity: {Capacity}, " +
                   $"Manufacture Date: {ManufactureDate.ToShortDateString()}, " +
                   $"Flights Count: {Flights.Count}";
        }

        public Plane(int planeId, PlaneType pt, int capacity, DateTime date)
        {
            this.PlaneId = planeId;
            this.MyPlaneType = pt;
            this.Capacity = capacity;
            this.ManufactureDate = date;
        }

        public Plane()
        {
        }
    }
}
