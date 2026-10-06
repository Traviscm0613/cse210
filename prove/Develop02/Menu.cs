
class Menu
{
    public int ProcessMenu()
    {

        int input = 0;

        while (input < 1 ||  input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Create, Display, Save, or Read Journal Entries");
            Console.WriteLine("1. Create New Journal Entry");
            Console.WriteLine("2. Display all Journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Read journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("> ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}



// This program must contain the following features:

// Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
// Display the journal - Iterate through all entries in the journal and display them to the screen.
// Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
// Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored in the journal.
// Provide a menu that allows the user choose these options
// Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
// Who was the most interesting person I interacted with today?
// What was the best part of my day?
// How did I see the hand of the Lord in my life today?
// What was the strongest emotion I felt today?
// If I had one thing I could do over today, what would it be?
