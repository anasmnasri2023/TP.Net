using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;

namespace AM.Core.Services
{
    internal class FlightService : IFlightService
    {
        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {
            IList<DateTime> dates = new List<DateTime>();
            foreach (var flight in Flights) {
                if(flight.Destination == destination)
                {
                    dates.Add(flight.FlightDate);
                }
                }
            return dates;
        }
        public IList<DateTime> GetFlightDatesLinQ(string destination)
        {
            //linQ integré
            // IEnumerable<DateTime> result = from f in Flights
            //           where f.Destination == destination
            //         select f.FlightDate; // the type de retour de requete linQ est i Inémurable de type est en train de selectionné de DateTime 
            //    return result.ToList(); 
            return Flights.Where(f=> f.Destination == destination)
                .Select(f=>f.FlightDate).ToList() ; //fonction avancée de linQ
        }
        public IList<Flight> GetFlights(string filterType, string filterValue)
        {
            var property = typeof(Flight).GetProperty(filterType);
            return property == null
                ? new List<Flight>()
                : Flights.Where(f => property.GetValue(f)?.ToString()?.Equals(filterValue, StringComparison.OrdinalIgnoreCase) == true)
                         .ToList();
        }
        public IList<(DateTime FlightDate, string Destination)> ShowFlightDetails(Plane plane)
        {
            return Flights.Where(f => f.MyPlane == plane)
                          .Select(f => (f.FlightDate, f.Destination))
                          .ToList();
        }
        public int GetWeeklyFlightNumber(DateTime startDate)
        {
            return Flights.Count(f => f.FlightDate >= startDate && f.FlightDate < startDate.AddDays(7));
        }
        public double GetDurationAverage(string destination)
        {
            return Flights.Where(f => f.Destination == destination)
                          .Average(f => (double)f.EstimatedDuration);
        }
        public IList<Flight> SortFlights()
        {
            return Flights.OrderByDescending(f => f.EstimatedDuration).ToList();
        }

        public IList<Passenger> GetThreeOlderTravellers(Flight flight)
        {
            return flight.Passengers.OrderBy(p => p.BirthDate).Take(3).ToList();
        }

        public IDictionary<string, List<Flight>> ShowGroupedFlights()
        {
            return Flights.GroupBy(f => f.Destination)
                          .ToDictionary(g => g.Key, g => g.ToList());
        }

    }
}
