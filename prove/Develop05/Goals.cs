using System;
using System.IO;

public class Goals
{
    private List<BaseGoal> _goals = new();
    private string _filename;
    private int _totalScore;

    public Goals()
    {
        _filename = ObtainFileName("What is the file name: ");
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void LoadGoals()
    {
        if (!File.Exists(_filename)) return;

        _goals.Clear();
        foreach (string line in File.ReadAllLines(_filename))
        {
            string[] data = line.Split('|');
            if (data.Length == 2 && data[0] == "SCORE")
            {
                _totalScore = int.Parse(data[1]);
                continue;
            }

            if (data.Length < 5) continue;
            string type = data[0];
            string name = data[1];
            string description = data[2];
            int points = int.Parse(data[3]);
            bool status = bool.Parse(data[4]);

            if (type == "SimpleGoal")
                AddGoal(new SimpleGoal(name, description, points, status));
            else if (type == "EternalGoal" && data.Length >= 6)
                AddGoal(new EternalGoal(name, description, points, status, int.Parse(data[5])));
            else if (type == "CheckListGoal" && data.Length >= 8)
                AddGoal(new CheckListGoal(name, description, points, status,
                    int.Parse(data[5]), int.Parse(data[6]), int.Parse(data[7])));
        }
        // string filename = "myFile.txt";
        // string[] lines = System.IO.File.ReadAllLines(filename);

        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(",");

        //     string firstName = parts[0];
        //     string lastName = parts[1];
        // }
                
    }

    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine($"SCORE|{_totalScore}");

            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }
        }
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your total score is: {_totalScore} points");
    }

    public void RecordEvent()
    {
        DisplayGoals();
        if (_goals.Count == 0) return;

        int choice = ObtainInt("Which goal did you complete? ");
        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("That goal number does not exist.");
            return;
        }

        int earned = _goals[choice - 1].RecordEvent();
        _totalScore += earned;
        Console.WriteLine($"You earned {earned} points!");
    }

    public void CreateGoal(int choice)
    {
        if (choice == 1) AddGoal(new SimpleGoal());
        else if (choice == 2) AddGoal(new EternalGoal());
        else if (choice == 3) AddGoal(new CheckListGoal());
        else Console.WriteLine("Invalid goal type.");
    }

    private string ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        string filename = Console.ReadLine();

        if (filename.Trim() == "")
        {
            filename = "file.txt";
        }

        return filename;
    }

    private static int ObtainInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value)) return value;
            Console.WriteLine("Please enter a whole number.");
        }
    }



    // Creativity - This is going to separate the goals that are completed and incompleted that way they aren't all jumbled together.
    public void DisplayCompletedAndIncomplete()
{
    Console.WriteLine("\nCompleted Goals:");

    foreach (BaseGoal goal in _goals)
    {
        if (goal.IsComplete())
        {
            Console.WriteLine(goal.GetConsoleString());
        }
    }

    Console.WriteLine("\nIncomplete Goals:");

    foreach (BaseGoal goal in _goals)
    {
        if (!goal.IsComplete())
        {
            Console.WriteLine(goal.GetConsoleString());
        }
    }
}
}
