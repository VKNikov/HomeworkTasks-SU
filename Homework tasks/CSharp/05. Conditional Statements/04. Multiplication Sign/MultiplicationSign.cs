//Problem 4.	Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. 

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("This program shows the sign (+, - or 0) of the product \nof three real numbers.");
        Console.WriteLine("Please enter the first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number:");
        double third = double.Parse(Console.ReadLine());

        if ((first * second * third) > 0)
        {
            Console.WriteLine("The sign of product is: +");
        }
        else if ((first * second * third) == 0)
        {
            Console.WriteLine("The sign of the product is: 0");
        }
        else
        {
            Console.WriteLine("The sign of the product is: -");
        }
    }
}