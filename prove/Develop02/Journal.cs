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
    
    
    // This will allow the user to completely wipe the file that they have been using to fill in their journal.
    public void ClearFile()
    {
        Console.Write("Enter filename to clear: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            File.WriteAllText(filename, "");
            _entries.Clear();

            Console.WriteLine("Journal file cleared!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    
    // This will read you each line in the file.
public void ReadFromFile()
{
    Console.Write("Enter filename: ");
    string filename = Console.ReadLine();

    _entries.Clear();

    Read reader = new Read();
    reader.ReadFromFile(filename, this);

    // to make sure the whole file is displayed.
    DisplayJournal();
}


    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
}

