using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        myCircle._radius = 10;

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
}






    // Class 4
// {
//     static double AddNumbers(double x, int y)
//     {
//         return x + y;
//     }

//     static string MyName()
//     {
//         return "Bob";
//     }

//     static void DisplayGreeting(string name)
//     {
//         Console.WriteLine($"Welcome {name}, its nice to meet you");
//     }
//     static void Main(string[] args)
//     {
//         string myName = MyName();
//         DisplayGreeting(myName);
//         double total = AddNumbers(12.234, 20);
//         Console.WriteLine(total);
//     }
// }


        // Class 3
        //     List<string> myFriends = new List<string> {"Bob", "Better", "Bubba"};

        //     myFriends.Add("Doug");

        //     foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }


        // for(int i = 0; i < 101; i++)
        //     {
        //         Console.WriteLine(i);
        //     }

    // bool done;

    // do
    // {
    //     Console.Write("Are we done (y/n)? ");
    //     done = Console.ReadLine().ToLower() == "y";
    // } while (! done);

    // bool done = false;

    // while (! done)
    // {
    //     Console.Write("Are we done (y/n)? ");
    //     done = Console.ReadLine() =="y";
    // }

// Class 2

//         // basic if / else if / else statement
//         int x = 10;
//         int y = 30;
//         int z = 40;


//         if (x == 10 && y == 30 || z == 40)
//             {
//                 Console.WriteLine("x is 10");
//                 Console.WriteLine("Y is 30");
//                 Console.WriteLine("Z is 40");
//             }
//         else if (x == 20)
//             {
//                 Console.WriteLine("x is 20");
                
//             }
//         else
//             {
//                 Console.WriteLine("Default output");
                
//             }

//             string numberString = "123";
//             int myNumber = int.Parse(numberString);
//     }
// }


// Class 1
// Console.WriteLine("Bonjour tout le monde!");
        // Console.WriteLine("Hey Jude");


// github push instructions in the terminal - 

// git status
// git add .
// git status
// git commit -m "message"
// git push


// instruction for changing files
// dir
// cd c then click tab
// dir
// cd filename
// dotnet run

