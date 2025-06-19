public class ChecklistGoal : Goal
{
    private int _target;
    private int _completed;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_completed < _target)
        {
            _completed++;
            if (_completed == _target)
                return _points + _bonus;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _completed >= _target;

    public override string GetStatus() =>
        $"[{(_completed >= _target ? "X" : " ")}] {_name} ({_description}) - Completed {_completed}/{_target} times";

    public override string GetSaveString() =>
        $"Checklist|{_name}|{_description}|{_points}|{_completed}|{_target}|{_bonus}";

    public override void LoadDetails(string data)
    {
        var parts = data.Split("|");
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _completed = int.Parse(parts[4]);
        _target = int.Parse(parts[5]);
        _bonus = int.Parse(parts[6]);
    }
}