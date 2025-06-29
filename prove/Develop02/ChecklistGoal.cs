using System;

class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _bonus;
    private int _currentCount;
    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonus)
        : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _bonus = bonus;
        _currentCount = 0;
    }
    public override bool IsComplete() => _currentCount >= _requiredCount;
    public override int RecordEvent()
    {
        if (_currentCount < _requiredCount)
        {
            _currentCount++;
            if (_currentCount == _requiredCount)
                return Points + _bonus;
            return Points;
        }
        return 0;
    }
    public override string GetStatusString() =>
        IsComplete()
            ? $"[X] {Name} ({Description}) -- Completed {_currentCount}/{_requiredCount}"
            : $"[ ] {Name} ({Description}) -- Completed {_currentCount}/{_requiredCount}";
    public override string ToDataString() =>
        $"Checklist|{Name}|{Description}|{Points}|{_requiredCount}|{_bonus}|{_currentCount}";
}
