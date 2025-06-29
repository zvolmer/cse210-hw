using System;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    public string Name => _name;
    public string Description => _description;
    public int Points => _points;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public abstract bool IsComplete();
    public abstract int RecordEvent();
    public abstract string GetStatusString();
    public abstract string ToDataString();
    public static Goal FromDataString(string data)
    {
        var parts = data.Split('|');
        switch (parts[0])
        {
            case "Simple":
                return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            case "Eternal":
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            case "Checklist":
                return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
            default:
                throw new Exception("Unknown goal type");
        }
    }
}
