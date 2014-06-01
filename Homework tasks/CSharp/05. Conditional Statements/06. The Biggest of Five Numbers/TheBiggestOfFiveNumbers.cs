//Problem 6.	The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements. 

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("This program will find the biggest of five numbers.");
        Console.WriteLine("Please enter the first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number:");
        double third = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the fourth number:");
        double fourth = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the fifth number:");
        double fifth = double.Parse(Console.ReadLine());

        if (first > second && first > third && first > fourth && first > fifth)
        {
            Console.WriteLine("The biggest number is: {0}", first);
        }
        else if (second > first && second > third && second > fourth && second > fifth)
        {
            Console.WriteLine("The biggest number is: {0}", second);
        }
        else if (third > first && third > second && third > fourth && third > fifth)
        {
            Console.WriteLine("The biggest number is: {0}", third);
        }
        else if (fourth > first && fourth > second && fourth > third && fourth > fifth)
        {
            Console.WriteLine("The biggest number is: {0}", fourth);
        }
        else
        {
            Console.WriteLine("The biggest number is: {0}", fifth);
        }

    }
}
