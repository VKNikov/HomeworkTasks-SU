//Problem 5.	Sorting Numbers
//Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 

using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        Console.WriteLine("This program sorts and prints a sequence of n integers.");
        Console.WriteLine("Please enter how many numbers do you like the sequence to be of(n)");
        int n = int.Parse(Console.ReadLine());

        SortedNumbers(n);
    }

    private static void SortedNumbers(int n)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        numbers.Sort();

        Console.WriteLine("After sorting, the sequence looks like this:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
