//Problem 5.	The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers. 

using System;
using System.Linq;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        //I have done this first with if-else conditional statements, but then did it with arrays just for practice. Both ways should work correctly.
        Console.WriteLine("This program will find the biggest of three numbers.");
        Console.WriteLine("Please enter the first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number:");
        double third = double.Parse(Console.ReadLine());

        double[] numbers = new double[] { first, second, third };
        double biggest = numbers.Max();
        Console.WriteLine("The biggest number is {0}", biggest);


        //if (first > second && first > third)
        //{
        //    Console.WriteLine("The biggest number is: {0}", first);
        //}
        //else if (second > first && second > third)
        //{
        //    Console.WriteLine("The biggest number is: {0}", second);
        //}
        //else
        //{
        //    Console.WriteLine("The biggest number is: {0}", third);
        //}
    }
}