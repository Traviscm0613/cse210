
using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();

        int response = 0;

        while (response != 5)
        {
            response = myMenu.ProcessMenu();

            switch (response)
            {
                case 1:
                    myJournal.CreateEntry();
                    break;

                case 2:
                    myJournal.DisplayJournal();
                    break;

                case 3:
                    myJournal.WriteToFile();
                    break;

                case 4:
                    myJournal.ReadFromFile();
                    break;

                case 5:
                    myJournal.ClearFile();
                    break;
            }
        }
    }
}

// What I decided to do to show creativity was to add a case that completely clears the file that you have been saving your journal to. It won't remove the file though, just the contents inside. It has the same option where you type in the file name to choose which one you might want to clean.