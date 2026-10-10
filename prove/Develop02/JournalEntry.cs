class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public JournalEntry()
    {
        _date = "";
        _prompt = "";
        _response = "";
    }

    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public void CreateJournalEntry()
    {
        
        string[] prompts =
        {
            "How was your day?",
            "Talk about someone you met."
        };

        _date = DateTime.Now.ToString();
        _prompt = prompts[0];

        Console.Write($"{_prompt} ");
        _response = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}