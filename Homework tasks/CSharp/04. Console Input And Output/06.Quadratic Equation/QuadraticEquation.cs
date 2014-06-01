//Problem 6.	Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("This program will print the real roots af the \nquadratic equation ax2 + bx + c = 0. for any given value of a, b and c.");
        Console.WriteLine("Please enter value for a:");
        double a = double.Parse(Console.ReadLine());

        while (a == 0)
        {
            Console.WriteLine("'a' cannot be 0. Please enter another value:");
            a = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter value for b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for c:");
        double c = double.Parse(Console.ReadLine());
        double x1 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        double x2 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        bool infinity = double.IsNaN(x1) || double.IsNaN(x2);

        if (infinity == true)
        {
            Console.WriteLine("There are no real roots for this quadratic equation.");
        }
        else if (x1 == x2)
        {
            Console.WriteLine("The roots are as follows: x1 = x2 = {0}", x1);
        }
        else
        {
            Console.WriteLine("The roots are as follows: x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}
