using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
            case 1:
                myJournal.CreateEntry();
                // Call CreateJournalEntry()
                break;
            case 2:
                myJournal.DisplayJournal();
                // Call DisplayJournal()
                break;
            case 3:
                Console.WriteLine("Save");
                // Call ReadToFile()
                break;
            case 4:
                Console.WriteLine("Write");
                // call WriteToFile()
                break;
            }
        }
    }
}