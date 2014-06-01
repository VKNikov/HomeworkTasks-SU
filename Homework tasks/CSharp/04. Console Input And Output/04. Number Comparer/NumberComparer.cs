//Problem 4.	Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("This program compares two numbers and prints the greater of them.\nPlease enter the first number");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine((firstNumber > secondNumber)? firstNumber : secondNumber);
    }
}