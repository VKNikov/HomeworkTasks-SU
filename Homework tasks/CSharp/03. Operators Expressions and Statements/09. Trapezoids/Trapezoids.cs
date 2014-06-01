//Problem 9.	Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("This program will calculate the area of a trapezoid when the corresponding values for its sides a and b as well as its heigh h are given.");
        Console.WriteLine("Please enter a value for side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a value for side b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a value for height:");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) / 2 * h;
        Console.WriteLine("The are of trapezoid with side a = {0}, side b = {1} and height {2} is: {3}", a, b, h, area);
        Console.WriteLine("Press enter to exit...");
        Console.ReadKey();
    }
}