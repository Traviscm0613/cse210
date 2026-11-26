using System;
using System.IO; 
class SimpleGoal : BaseGoal
{

    public SimpleGoal(string name, string description, int points, bool status)
        : base(name, description, points, status, "SimpleGoal")
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