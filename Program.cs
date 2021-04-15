using System;

namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison problem");
            Length line = new Length(8, 4, 6, 1);
            double length = line.CalculateLength();
            Console.WriteLine("Length of line is = " + length);
        }
    }
}
