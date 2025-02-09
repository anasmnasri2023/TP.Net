// See https://aka.ms/new-console-template for more information
using System;
using AM.Core.Domain;

    
        Plane plane = new Plane();
        plane.Capacity = 100;
        plane.ManufactureDate = DateTime.Now; 
        plane.MyPlaneType = PlaneType.Boing;

        Plane plane2 = new Plane(1, PlaneType.Boing, 100, new DateTime(2022, 06, 25));
        Plane plane3 = new Plane() { Capacity = 100, MyPlaneType = PlaneType.Airbus };
        Console.WriteLine(plane);
        Console.WriteLine(plane2);
        Console.WriteLine(plane3);
        Passenger passenger = new Passenger();
        Staff staff = new Staff();
        Traveller traveller = new Traveller();
        Console.WriteLine(passenger.GetPassengerType());
        Console.WriteLine(staff.GetPassengerType());
        Console.WriteLine(traveller.GetPassengerType());

        Console.WriteLine("Hello, World!");
    
