using System;
using System.IO; 

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
        Console.WriteLine("7. Quit");
        return ReadInt("Select an option: ");
    }

    public int DisplayCreateGoalMenu()
    {
        Console.WriteLine("\nGoal Types");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        return ReadInt("Select a goal type: ");
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value)) return value;
            Console.WriteLine("Please enter a whole number.");
        }
    }
}
