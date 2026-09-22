using System;

class Program
{
    static void Main(string[] args)
    {


        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int x = int.Parse(answer);

        if (x >= 90 && x < 100)
        {
            Console.WriteLine("You got an A");
        }
        else if (x >= 80 && x < 90)
        {
            Console.WriteLine("You got a B");
        }
        else if (x >= 70 && x < 80)
        {
            Console.WriteLine("You got a C");
        }
        else if (x >= 60 && x < 70)
        {
            Console.WriteLine("You got a D");
        }
        else 
        {
            Console.WriteLine("You got an F");
        }


    }
}