//Problem 1.	Sum of 3 Integers
//Write a program that reads 3 integer numbers from the console and prints their sum. 

using System;

class SumOf3Integers
{
    static void Main()
    {
        //The problem asks as to make a program to read integers, but the given examples included floating-point numbers, so I made the program read the user input as a double number instead of an int.
        Console.WriteLine("This is a program that displays the sum of three integer numbers.");
        Console.WriteLine("Please write in the first integer:");
        string userInput1 = Console.ReadLine();
        double first;

        while (!double.TryParse(userInput1, out first))
        {
            Console.WriteLine("This is not an integer. Please write in an integer.");
            userInput1 = Console.ReadLine();
        }

        Console.WriteLine("Please write in the second integer:");
        string userInput2 = Console.ReadLine();
        double second;

        while (!double.TryParse(userInput2, out second))
        {
            Console.WriteLine("This is not an integer. Please write in an integer.");
            userInput2 = Console.ReadLine();
        }

        Console.WriteLine("Please write in the third integer:");
        string userInput3 = Console.ReadLine();
        double third;

        while (!double.TryParse(userInput3, out third))
        {
            Console.WriteLine("This is not an integer. Please write in an integer.");
            userInput3 = Console.ReadLine();
        }

        Console.WriteLine("The sum of integers {0}, {1} and {2} is: {3}", first, second, third, first + second + third);
    }
}