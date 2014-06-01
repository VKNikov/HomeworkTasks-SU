using System;

class CalculatingSquareRoot
{
    static void Main()
    {
        //This program calculates the square root of a random number
        Console.WriteLine("Enter a random number for which you want to calculate the square root of:");
        string Userinput = Console.ReadLine();
        double Number;
        if (double.TryParse(Userinput, out Number))
        {
            double SQRT = Math.Sqrt(Number);
            Console.WriteLine("The Square root of {0} is {1}", Number, SQRT);
        }
        else
        {
            Console.WriteLine("Incorrect input data.  Please enter only numbers!");
        }
    }
}

