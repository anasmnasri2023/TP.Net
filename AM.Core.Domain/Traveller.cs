using System;

namespace AM.Core.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public override string GetPassengerType()
        {
            return "I am a Traveller";
        }
    }
}
