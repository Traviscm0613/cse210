class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }
    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);

    }
    public void WriteToFile()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        Write writer = new Write();
        writer.WriteToFile(filename, _entries);
    }

    
    
public void ReadFromFile()
{
    Console.Write("Enter filename: ");
    string filename = Console.ReadLine();

    _entries.Clear();

    Read reader = new Read();
    reader.ReadFromFile(filename, this);
    DisplayJournal();
}


    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
}
