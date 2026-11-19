class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    
    public EternalGoal(string name, string description, int points, bool complete, bool completions)
    {
        
    }

    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override string GetConsoleString()
    {
        return base.GetConsoleString();
    }
    public override string GetFileSystemString()
    {
        
    }
}