using System;

class Program
{
    static void Main(string[] args)
    {
        // Extra creativity: prompts and questions do not repeat until all of
        // the choices have been used during the current activity session.
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.RunActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.RunActivity();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.RunActivity();
            }
            else if (choice == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Please enter 1, 2, 3, or 4.");
            }
        }
    }
}