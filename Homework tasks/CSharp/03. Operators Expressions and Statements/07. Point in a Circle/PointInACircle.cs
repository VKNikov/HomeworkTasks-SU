//Problem 7.	Point in a Circle
//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("The program will check if given point with coordinates (x, y) is inside a circle K ((0, 0), 2)");
        Console.WriteLine("Please enter value for x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for y:");
        double y = double.Parse(Console.ReadLine());
        bool check = (x * x) + (y * y) <= 2 * 2;
        Console.WriteLine("Is the point with coordinates {0} and {1} inside the circle? True or False? \n{2}", x, y, check);
    }
}