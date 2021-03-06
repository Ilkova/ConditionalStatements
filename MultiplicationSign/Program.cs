﻿// Problem 4. Multiplication Sign

//  Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//      Use a sequence of if operators.

using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            int signCount = 0;
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The sign is \" 0 \"");
            }
            else
            {
                if (a < 0)
                {
                    signCount++;
                }
                if (b < 0)
                {
                    signCount++;
                }
                if (c < 0)
                {
                    signCount++;
                }
                if (signCount % 2 == 0)
                {
                    Console.WriteLine("The sign is \" + \"");
                }
                else Console.WriteLine("The sign is \" - \"");
            }      
        }        
    }   
}

