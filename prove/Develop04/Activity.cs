using System;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---\n");
        Console.WriteLine(_description + "\n");
        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine();
        PerformActivity();
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You completed {_duration} seconds of {_name}.");
    }

    protected int Duration => _duration;

    protected abstract void PerformActivity();
}
