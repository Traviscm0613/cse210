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

        Circle myCircle2 = new Circle();

        myCircle2._radius = 10;

        double area2 = myCircle2.GetArea();

        Console.WriteLine(area2);
    }
}

