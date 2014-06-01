using System;

class CalculatingAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Please enter the year when you were born:");
        int a = int.Parse(Console.ReadLine());
        int d = DateTime.Now.Year;
    }
}

