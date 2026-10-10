
class Read
{
    public void ReadFromFile(string filename, Journal journal)
    {

        string[] lines = File.ReadAllLines(filename);

        Console.WriteLine("Here is a list of all your journal entries - ");

        foreach (string line in lines)
        {

            string[] parts = line.Split('#');

            if (parts.Length >= 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                JournalEntry entry =
                    new JournalEntry(date, prompt, response);

                journal.AddEntry(entry);
            }
            else
            {
                Console.WriteLine($"{line}");
            }
        }
    }
}
