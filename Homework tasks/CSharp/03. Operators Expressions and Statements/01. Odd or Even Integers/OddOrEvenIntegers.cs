//Problem 1.	Odd or Even Integers
//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("This program checks if a random integer number is odd or even.\nIf the integer is odd, the program will return value True. If it is not, the value will be False.\nPlease enter an integer number:");
        string userInput = Console.ReadLine();
        int a;

        while (!int.TryParse(userInput, out a))
        {
            Console.WriteLine("This is not an integer! Please try again with an integer.");
            userInput = Console.ReadLine();
        }

        int b       = a % 2;
        bool check  = b != 0;
        Console.WriteLine(check);
    }
}