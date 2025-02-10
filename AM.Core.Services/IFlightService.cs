using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;

namespace AM.Core.Services
{
    public  interface IFlightService
    {
        public IList<DateTime> GetFlightDates (string destination);
        public IList<Flight> GetFlights(string filterType, string filterValue);

    }
}
