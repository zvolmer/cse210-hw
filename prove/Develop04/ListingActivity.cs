using System;

public class ListingActivity
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("--- Listing Activity ---");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many items as you can.");
        Console.WriteLine();
        Console.Write("Enter duration (seconds): ");
        int duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine();
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine("\n--- Prompt ---");
        Console.WriteLine(prompt);
        Console.WriteLine("Start listing items. Press Enter on an empty line to finish.");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(entry))
                break;
            count++;
        }
        Console.WriteLine($"\nYou listed {count} items!");
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You completed {duration} seconds of Listing Activity.");
    }
}
