
class Write
{
    public void WriteToFile(string filename, List<JournalEntry> entries)
    {
        // true will make it where the file is not overwritten every time I run the program/ write to the the program.
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (JournalEntry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine("Journal saved!");
    }
}
