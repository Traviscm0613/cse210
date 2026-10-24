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
            // Bible scriptures
            new Scripture("Moses", 1, 39,
                "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man"),

            new Scripture("John", 3, 16,
                "For God so loved the world, that he gave his only begotten Son"),

            new Scripture("Proverbs", 3, 5,
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding"),

            new Scripture("Philippians", 4, 13,
                "I can do all things through Christ which strengtheneth me"),

            new Scripture("Psalm", 23, 1,
                "The Lord is my shepherd; I shall not want"),

                // Book of Mormon scriptures

            new Scripture("1 Nephi", 3, 7,
                "I will go and do the things which the Lord hath commanded"),

            new Scripture("2 Nephi", 2, 25,
                "Adam fell that men might be; and men are, that they might have joy"),

            new Scripture("Mosiah", 2, 17,
                "When ye are in the service of your fellow beings ye are only in the service of your God"),

            new Scripture("Alma", 37, 6,
                "By small and simple things are great things brought to pass"),

            new Scripture("Ether", 12, 27,
                "If men come unto me I will show unto them their weakness")
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


// Creativity - 
// I added more scriptures and a way to randomly select one of the scriptures that every time you run the program, 
// you can memorize a new scripture.