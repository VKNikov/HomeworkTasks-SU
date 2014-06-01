//Problem 4.	Difference between Dates
//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 

using System;

class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program returns the number of days between two dates.");

        DateDifference();

    }

    private static void DateDifference()
    {
        Console.WriteLine("Please enter the first date in format (dd.MM.yyyy)");
        DateTime first = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second date in format (dd.MM.yyyy)");
        DateTime second = DateTime.Parse(Console.ReadLine());
        //TimeSpan difference = (second - first);
        Console.WriteLine((second - first).Days);
    }
}
