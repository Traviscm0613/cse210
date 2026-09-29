using System;
using System.Collections.Generic;

class List
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number list");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int sentNumber = -1;

        while (sentNumber != 0)
        {
            Console.Write("Enter Number: ");
            string response = Console.ReadLine();

            if (!int.TryParse(response, out sentNumber))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (sentNumber != 0)
            {
                numbers.Add(sentNumber);
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
