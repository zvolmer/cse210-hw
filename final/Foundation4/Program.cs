using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running("25 Jul 2025", 30, 3.0),
            new Cycling("25 Jul 2025", 45, 12.0),
            new Swimming("25 Jul 2025", 60, 20)
        };

        foreach (var a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
