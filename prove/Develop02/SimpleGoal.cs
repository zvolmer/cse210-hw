using System;

class SimpleGoal : Goal
{
    private bool _completed;
    public SimpleGoal(string name, string description, int points, bool completed = false)
        : base(name, description, points)
    {
        _completed = completed;
    }
    public override bool IsComplete() => _completed;
    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return Points;
        }
        return 0;
    }
    public override string GetStatusString() =>
        _completed ? $"[X] {Name} ({Description})" : $"[ ] {Name} ({Description})";
    public override string ToDataString() =>
        $"Simple|{Name}|{Description}|{Points}|{_completed}";
}
