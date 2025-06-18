using System;
using System.Threading;

public class BreathingActivity
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("--- Breathing Activity ---");
        Console.WriteLine("This activity will help you relax by walking you through slow breathing. Clear your mind and focus on your breath.");
        Console.WriteLine();
        Console.Write("Enter duration (seconds): ");
        int duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(4000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(6000);
        }
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You completed {duration} seconds of Breathing Activity.");
    }
}
