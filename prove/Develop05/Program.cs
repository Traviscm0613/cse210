using System;
using System.IO; 
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
                // Creativity - Calling the Display
                case 7:
                    goals.DisplayCompletedAndIncomplete();
                    break;
                case 8:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}

// For creativty, I added another menu option that will orginize the goals that you have either completed or not completed. The reason was becasue once you complete certain goals, they all jumble up and it is better to see them separated.
