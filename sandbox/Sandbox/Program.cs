using System;

class Program
{
    static void Main(string[] args)
    {

        // basic if / else if / else statement
        int x = 10;
        int y = 30;
        int z = 40;


        if (x == 10 && y == 30 || z == 40)
            {
                Console.WriteLine("x is 10");
                Console.WriteLine("Y is 30");
                Console.WriteLine("Z is 40");
            }
        else if (x == 20)
            {
                Console.WriteLine("x is 20");
                
            }
        else
            {
                Console.WriteLine("Default output");
                
            }

            string numberString = "123";
            int myNumber = int.Parse(numberString);
    }
}


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


// Console.WriteLine("Bonjour tout le monde!");
        // Console.WriteLine("Hey Jude");