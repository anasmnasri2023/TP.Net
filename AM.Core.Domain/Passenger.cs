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

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - BirthDate.Year;
                if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                    age--;
                return age;
            }
        }
        public override string ToString()
        {
            return $"Passenger: {FirstName} {LastName}, Passport: {PassportNumber}, " +
                   $"Email: {EmailAddress}, Phone: {TelNumber}, BirthDate: {BirthDate.ToShortDateString()}, " +
                   $"Flights Count: {Flights.Count}, Age: {Age}";
        }

        public bool checkProfile(string firstName, string lastName, string emailAddress = null)
        {
            if (emailAddress != null)
                return (firstName == FirstName && lastName == LastName && emailAddress == EmailAddress);
            return firstName == FirstName && lastName == LastName;
        }

        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }

        

        //public void GetAge(DateTime birthDate, ref int calculatedAge)
        //{
            //calculatedAge = DateTime.Now.Year - birthDate.Year;

            // if (birthDate.DayOfYear > DateTime.Now.DayOfYear)
          //      calculatedAge--;
        //}
        //public void GetAge(Passenger aPassenger)
        //{
          //  aPassenger.Age = DateTime.Now.Year - aPassenger.BirthDate.Year;

        //    if (DateTime.Now.DayOfYear < aPassenger.BirthDate.DayOfYear)
          //      aPassenger.Age--;
      //  }

    }

  
}
