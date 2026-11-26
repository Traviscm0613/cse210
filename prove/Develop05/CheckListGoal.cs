using System;
using System.IO; 
class CheckListGoal : BaseGoal
{

    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, bool status,
        int completions, int max, int bonus)
        : base(name, description, points, status, "CheckListGoal")
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }
    public CheckListGoal() : base("CheckListGoal")
    {
        _numberOfCompletions = 0;
        ObtainMaxGoal();
        ObtainBonusPoints();
    }

    public override int RecordEvent()
    {
        if (_numberOfCompletions >= _maxGoals) return 0;

        _numberOfCompletions++;
        int points = GetPoints();
        if (_numberOfCompletions == _maxGoals)
        {
            points += _bonusPoints;
            MarkComplete();
        }
        return points;
    }

    public override string GetFileSystemString()
    {
        return base.GetFileSystemString() +
            $"|{_numberOfCompletions}|{_maxGoals}|{_bonusPoints}";
    }
    
    public override string GetConsoleString()
    {
        return base.GetConsoleString() +
            $" -- Completed {_numberOfCompletions}/{_maxGoals} times; Bonus: {_bonusPoints}";
    }
    private void ObtainMaxGoal()
    {
        Console.Write("How many times must this goal be completed: ");
        _maxGoals = int.Parse(Console.ReadLine());
    }

    private void ObtainBonusPoints()
    {
        Console.Write("How many bonus points are awarded at the end: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

}