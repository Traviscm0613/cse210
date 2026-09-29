using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Random Number Guessing Game");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guess = 0;

        while (guess != number)
        {
            Console.Write("Type your guess 1-10: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Guess Higher!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Guess Lower!");
            }
            else
            {
                Console.WriteLine("You guessed correctly!");
            }
        }
    }
}