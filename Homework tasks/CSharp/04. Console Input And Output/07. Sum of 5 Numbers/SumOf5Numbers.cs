//Problem 7.	Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("This program calculates and prints the sum of 5 numbers. \nSeparate the numbers with 'space'.");
        string userinput = Console.ReadLine();
        userinput       = userinput.Replace(',', '.');
        string[] split  = userinput.Split(new char [] {' '});
        double a        = double.Parse(split[0]);
        double b        = double.Parse(split[1]);
        double c        = double.Parse(split[2]);
        double d        = double.Parse(split[3]);
        double e        = double.Parse(split[4]);

        double sum = a + b + c + d + e;
        Console.WriteLine("The sum of the integers you have entered is: {0}", sum);
    }
}