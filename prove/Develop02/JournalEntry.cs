class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;


    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);

    }
    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day? ",
            "Talk about someone you met. ",
        };
        _date = DateTime.Now.ToString();
        
        // make list of prompts
        _prompt = prompts[0];
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
        


    }
}