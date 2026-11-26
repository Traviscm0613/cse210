using System;
using System.IO; 

using System;

public class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("\nEternal Quest");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Display Score");
        Console.WriteLine("7. Display Completed and Incomplete Goals");
        Console.WriteLine("8. Quit");

        Console.Write("Select an option: ");
        int choice = int.Parse(Console.ReadLine());

        return choice;
    }

    public int DisplayCreateGoalMenu()
    {
        Console.WriteLine("\nGoal Types");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select a goal type: ");
        int choice = int.Parse(Console.ReadLine());

        return choice;
    }
}