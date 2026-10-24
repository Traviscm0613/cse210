using System;

class Program
{
    static void Main(string[] args)
    {
        // Word myWord = new Word("Secret");

        // myWord.Display();
        // myWord.Hide();
        // Console.WriteLine();
        // myWord.Display();


        // Here are all the prompts that it will randomly pick.
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("Moses", 1, 39, "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man"
            ),

            new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son"
            ),

            new Scripture("Proverbs", 3, 5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding"
            ),

            new Scripture("Philippians", 4, 13, "I can do all things through Christ which strengtheneth me"
            ),

            new Scripture("Psalm", 23, 1, "The Lord is my shepherd; I shall not want"
            )
        };

        // string[] myScripture
        // {
        //     "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man"

        // };


        // This will select the random scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetScriptureReference());
            scripture.ShowScripture();
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.HideSomeWords())
            {
                break;
            }
        }


    }
}