// Write a program that enters 3 real numbers and prints them sorted in descending order.
//  Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;
namespace SortThreeNumbersWithNestedIfs
{
    class SortThreeNumbersWithNestedIfs
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine("The result is:");
                Console.Write(a);
                if (b >= c)
                {
                    Console.WriteLine(" " + b + " " + c);
                }
                else if (c >= b)
                {
                    Console.WriteLine(" " + c + " " + b);
                }
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("Result: ");
                Console.Write(b);
                if (a >= c)
                {
                    Console.WriteLine(" " + a + " " + c);
                }
                else if (c >= a)
                {
                    Console.WriteLine(" " + c + " " + a);
                }
            }
            else if (c >= b && c >= a)
            {
                Console.WriteLine("Result: ");
                Console.Write(c);
                if (b >= a)
                {
                    Console.WriteLine(" " + b + " " + a);
                }
                else if (a >= b)
                {
                    Console.WriteLine(" " + a + " " + b);
                }
            }
        }
    }
}
