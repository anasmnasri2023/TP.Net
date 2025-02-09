using System;
using System.Collections.Generic;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public override string ToString()
        {
            return $"Passenger: {FirstName} {LastName}, Passport: {PassportNumber}, " +
                   $"Email: {EmailAddress}, Phone: {TelNumber}, BirthDate: {BirthDate.ToShortDateString()}, " +
                   $"Flights Count: {Flights.Count}";
        }
       // public bool checkProfile(string FirstNAme, string LastNAme)
        //{
          //  return (FirstName == FirstName && LastName == LastName);
        //}

        //public bool checkProfile(string FirstName, string LastName, string EmailAddress)
        //{
          //  return (FirstName == FirstName && LastName == LastName && EmailAddress == EmailAddress);
       // }
        public bool checkProfile(string FirstName, string LastName, string EmailAddress = null)
        {
            if(EmailAddress != null)
            return (FirstName == FirstName && LastName == LastName && EmailAddress == EmailAddress);
            return FirstName == FirstName && LastName == LastName;
        }
        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }
    }
}
