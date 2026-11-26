class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    public EternalGoal(string name, string description, int points, bool status, int completions)
        : base(name, description, points, status, "EternalGoal")
    {
        _numberOfCompletions = completions;
    }

    public EternalGoal() : base("EternalGoal")
    {
    }
    public override int RecordEvent()
    {
        _numberOfCompletions++;
        return GetPoints();
    }
    public override string GetConsoleString()
    {
        return base.GetConsoleString();
    }
    public override string GetFileSystemString()
    {
        return base.GetFileSystemString() + $"|{_numberOfCompletions}";
    }
}