class Write
{
    public void WriteToFile(string filename, List<JournalEntry> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine("Journal saved!");
    }
}