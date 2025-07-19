using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Address addr1 = new Address("510 S Center St", "Rexburg", "ID", "USA");
        Lecture lec = new Lecture("Inheritance", "Lecture on using inheritance in C#.", "07-16-2025", "2:00 PM", addr1, "Brother Crosby", 100);

        Address addr2 = new Address("6200 University Blvd", "Vancouver", "BC", "Canada");
        Reception rec = new Reception("Networking Event", "Networking event for Computer Science students to meet representatives and hiring managers from different businesses.", "09-15-2025", "1:00 PM", addr2, "events@school.edu");

        Address addr3 = new Address("The Feathers", "Vantage", "WA", "USA");
        OutdoorGathering outg = new OutdoorGathering("Rock Climbing", "Outdoor rock climbing event.", "07-30-2025", "9:00 PM", addr3, "Sunny, 85°F");

        List<Event> events = new List<Event> { lec, rec, outg };

        foreach (Event e in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("\n----- Full Details -----");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("\n----- Short Description -----");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
        }
    }
}
