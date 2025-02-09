using System;

namespace AM.Core.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public int Salary { get; set; }

        public override string GetPassengerType()
        {
            return base.GetPassengerType() + " I am a Staff Member";
        }
    }
}
