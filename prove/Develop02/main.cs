using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
            case 1:
                Console.WriteLine("Create");
                // Call CreateJournalEntry()
                break;
            case 2:
                Console.WriteLine("Display");
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