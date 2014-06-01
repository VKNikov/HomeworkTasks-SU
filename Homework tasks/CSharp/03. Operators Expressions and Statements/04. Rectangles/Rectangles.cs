//Problem 4.	Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height. 

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("This program calculates the perimeter and the area of a rectangle.\nPlease enter the rectangle's width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Now please enter the rectangle's height:");
        double heigh = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the rectangle is {0}", (2 * width) + (2 * heigh));
        Console.WriteLine("Its area is {0}", width * heigh);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}