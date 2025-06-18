using System;
using System.Threading;

public class ReflectionActivity
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("--- Reflection Activity ---");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine();
        Console.Write("Enter duration (seconds): ");
        int duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine();
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine("\n--- Prompt ---");
        Console.WriteLine(prompt);
        Console.WriteLine("\nWhen you have something in mind, press Enter.");
        Console.ReadLine();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine("\n" + question);
            Thread.Sleep(5000);
        }
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You completed {duration} seconds of Reflection Activity.");
    }
}
