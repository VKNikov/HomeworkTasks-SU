//Problem 7.	Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 

using System;

class NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("This program prints out three real numbers sorted in descending order");
        Console.WriteLine("Please enter the first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number:");
        double third = double.Parse(Console.ReadLine());

        if (first > second && first > third)
        {
            if (second > third)
            {
                Console.WriteLine("The descending order is: \n{0} {1} {2}", first, second, third);
            }
            else
            {
                Console.WriteLine("The descending order is: \n{0} {1} {2}", first, third, second);
            }
        }
        else if (second > first && second > third)
        {
            if (first > third)
            {
                Console.WriteLine("The descending order is: \n{0} {1} {2}", second, first, third);
            }
            else
            {
                Console.WriteLine("The descending order is: \n{0} {1} {2}", second, third, first);
            }
        }
        else
        {
            if (first > second)
            {
                Console.WriteLine("The descending order is: \n{0} {1} {2}", third, first, second);
            }
            else
            {
                Console.WriteLine("The descending order is: \n{0} {1} {2}", third, second, first);
            }
        }
    }
}
