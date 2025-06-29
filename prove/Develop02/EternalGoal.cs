using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }
    public override bool IsComplete() => false;
    public override int RecordEvent() => Points;
    public override string GetStatusString() =>
        $"[∞] {Name} ({Description})";
    public override string ToDataString() =>
        $"Eternal|{Name}|{Description}|{Points}";
}
