using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _rand = new Random();

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many items as you can."
        )
    { }

    protected override void PerformActivity()
    {
        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine("\n--- Prompt ---");
        Console.WriteLine(prompt);
        Console.WriteLine("Start listing items. Press Enter on an empty line to finish.");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
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
    }
}
