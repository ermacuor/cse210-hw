public class EternalGoal : Goal
{
    private bool _isCompleted = false;

    public EternalGoal(string name, string desc, int points) : base(name, desc, points) { }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => false;

    public override string GetStatus() =>
        $"[{(_isCompleted ? "X" : " ")}] {_name} ({_description})";

    public override string GetSaveString() =>
        $"Eternal|{_name}|{_description}|{_points}";

    public override void LoadDetails(string data)
    {
        var parts = data.Split("|");
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
    }
}