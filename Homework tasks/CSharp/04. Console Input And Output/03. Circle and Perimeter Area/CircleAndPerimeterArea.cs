//Problem 3.	Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CircleAndPerimeterArea
{
    static void Main()
    {
        Console.WriteLine("This program will print circle's perimter and area up to 2 digits after the decimal point.");
        Console.WriteLine("In order to do that, please enter the circle's radius:");
        string userInput = Console.ReadLine();
        double r;

        while (!double.TryParse(userInput, out r))
        {
            Console.WriteLine("This is not a valid number. Please try again!");
            userInput = Console.ReadLine();
        }

        double pi = Math.PI;
        Console.WriteLine("The perimeter of the circle is: {0:F2}", 2 * pi * r);
        Console.WriteLine("The area of the circle is {0:F2}", pi * Math.Pow(r, 2));
    }
}