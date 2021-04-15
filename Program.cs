using System;

namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison problem");
            Length line1 = new Length(8, 4, 6, 1);
            double length1 = line1.CalculateLength();
            Length line2 = new Length(9, 3, 5, 4);
            double length2 = line2.CalculateLength();
            Console.WriteLine("Length of two lines are = " + length1 + "  " + length2);
            Console.WriteLine(length1.CompareTo(length2));
        }
    }
}
