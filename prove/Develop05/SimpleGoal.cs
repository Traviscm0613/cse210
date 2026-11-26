class SimpleGoal : BaseGoal
{

    public SimpleGoal(string name, string description, int points, bool complete, string goalType) 
    : base(name, description, points, complete, goalType)
    {
    }
    public SimpleGoal() : base("SimpleGoal")
    {
    }

    public override int RecordEvent()
    {
        // Todo, calls mark complete and checks the goal
        return MarkComplete();
    }

}