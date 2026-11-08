using System;
using System.Threading;

class ListingActivity : BaseActivity
{

    private List<string> _prompts = new List<string>();
    private List<string> _usedPrompts = new List<string>();
    private Random _random = new Random();
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        SetPrompts();
    }
    public void RunActivity()
    {
        // Pulls from base activity
        StartActivity();
        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine("\nList as many responses as you can to this prompt:");
        Console.WriteLine(prompt);
        RunCountDownMessage("You may begin in", 5);

        int count = 0;
        Console.WriteLine("Enter each response and press Enter.");

        while (!HasTimerExpired())
        {
            if (Console.KeyAvailable)
            {
                string answer = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(answer))
                {
                    count++;
                }
            }
            else
            {
                Thread.Sleep(50);
            }
        }

        Console.WriteLine($"\nYou listed {count} item(s).");
        // Pulls from base activity
        DisplayEnding();
    }
    public void SetPrompts()
    {
        _prompts.Clear();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        ResetPromptsUsage();
    }
    public void ResetPromptsUsage()
    {
        _usedPrompts.Clear();
    }
    
}