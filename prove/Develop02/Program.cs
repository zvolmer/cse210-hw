using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;
    static void Main()
    {
        Load();
        while (true)
        {
            Console.WriteLine($"\nScore: {totalScore}");
            Console.WriteLine("1. List Goals  2. Create Goal  3. Record Event  4. Save  5. Quit");
            Console.Write("Choose an option: ");
            switch (Console.ReadLine())
            {
                case "1": ListGoals(); break;
                case "2": CreateGoal(); break;
                case "3": RecordEvent(); break;
                case "4": Save(); break;
                case "5": return;
                default: break;
            }
        }
    }
    static void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i+1}. {goals[i].GetStatusString()}");
    }
    static void CreateGoal()
    {
        Console.Write("Type (1) Simple (2) Eternal (3) Checklist: ");
        var type = Console.ReadLine();
        Console.Write("Name: ");
        var name = Console.ReadLine();
        Console.Write("Description: ");
        var desc = Console.ReadLine();
        Console.Write("Points: ");
        var pts = int.Parse(Console.ReadLine());
        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, desc, pts));
                break;
            case "2":
                goals.Add(new EternalGoal(name, desc, pts));
                break;
            case "3":
                Console.Write("Required count: ");
                var req = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                var bon = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, pts, req, bon));
                break;
        }
    }
    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal #: ");
        var idx = int.Parse(Console.ReadLine()) - 1;
        if (idx >= 0 && idx < goals.Count)
        {
            var earned = goals[idx].RecordEvent();
            totalScore += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
    }
    static void Save()
    {
        using var writer = new StreamWriter("goals.txt");
        writer.WriteLine(totalScore);
        foreach (var g in goals)
            writer.WriteLine(g.ToDataString());
    }
    static void Load()
    {
        if (!File.Exists("goals.txt")) return;
        var lines = File.ReadAllLines("goals.txt");
        totalScore = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
            goals.Add(Goal.FromDataString(lines[i]));
    }
}
