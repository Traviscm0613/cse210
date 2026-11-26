using System;

public static class Program
{
    public static void Main()
    {
        Goals goals = new();
        Menu menu = new();
        goals.LoadGoals();

        bool running = true;
        while (running)
        {
            switch (menu.DisplayMenu())
            {
                case 1:
                    goals.CreateGoal(menu.DisplayCreateGoalMenu());
                    break;
                case 2:
                    goals.DisplayGoals();
                    break;
                case 3:
                    goals.SaveGoals();
                    Console.WriteLine("Goals saved.");
                    break;
                case 4:
                    goals.LoadGoals();
                    Console.WriteLine("Goals loaded.");
                    break;
                case 5:
                    goals.RecordEvent();
                    break;
                case 6:
                    goals.DisplayScore();
                    break;
                case 7:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
