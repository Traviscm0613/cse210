class ReflectionActivity : BaseActivity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _usedPrompts = new List<string>();
    private List<string> _usedQuestions = new List<string>();
    private Random _random = new Random();
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        SetPromptsAndQuestions();
    }

    public void RunActivity()
    {
        // Pulls from base activity
        StartActivity();
        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine(prompt);
        Console.WriteLine("\nWhen you see each question, take time to reflect.");

        while (!HasTimerExpired())
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine($"\n{question}");

            int seconds = Math.Min(8, SecondsRemaining());
            if (seconds > 0)
            {
                RunSpinnerMessage("Reflecting", seconds);
            }
        }
// Pulls from base activity
        DisplayEnding();
    }
    public void SetPromptsAndQuestions()
    {
        _prompts.Clear();
        _questions.Clear();

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        ResetPromptsUsage();
    }
    public void ResetPromptsUsage()
    {
        _usedPrompts.Clear();
        _usedQuestions.Clear();
    }
}