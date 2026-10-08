class Write
{
    public void WriteToFile(string filename)​

    {​

        using (StreamWriter outputFile = new StreamWriter(filename))​

        {          ​

            foreach(JournalEntry entry in entries)​

            {​

                outputFile.WriteLine(entry.ToString());​

            }​

        }​

    }​
}
