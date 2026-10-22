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

        foreach (Scripture scripture in scriptures)
        {
            scriptures[0].ShowScripture();

            Console.WriteLine();

            Scripture myScripture = new Scripture();
            
            Console.Write("Press enter to continue or type 'quit' to finish: ");
        }

        // Circle myCircle = new Circle(10);

    }
}