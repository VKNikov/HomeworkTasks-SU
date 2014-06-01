//Problem 10.	Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInsideAircleAndOutsideOfRectangle
{
    static void Main()
    {
        Console.WriteLine("This program will check if a given point (x,y) is within the circle K ((1, 1), 1.5) and out of the rectangle R(top = 1, left = -1, width = 6, height = 2).\nIf the point is within the circle and outside the rectangle, the output will be Yes, otherwise the output will be No");
        Console.WriteLine("Please enter value for x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for y:");
        double y = double.Parse(Console.ReadLine());

        bool checkCircle = ((x - 1) * (x - 1) + (y - 1) * (x - 1)) <= 1.5 * 1.5;
        bool checkRectangle = x >= -1 && x <= (-1 + 6) && y <= 1 && y >= (1 - 2);

        if (checkCircle == true && checkRectangle == false)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}