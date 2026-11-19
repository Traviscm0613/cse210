class CheckListGoal : BaseGoal
{
    public CheckListGoal(string name, string description, int points, bool complete, string goalType) 
    : base(name, description, points, complete, goalType)
    {
    }
    public CheckListGoal() : base("CheckListGoal")
    {
    }

    // public override RecordEvent()
    // {
        
    // }

    // public override RecordEvent()
    // {
        
    // }
    // public override GetFileSystemString()
    // {
        
    // }




    public override int RecordEvent()
    {
        // Todo
        return 0;
    }

}