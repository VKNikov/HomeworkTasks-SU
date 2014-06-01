//Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
//Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. Examples:

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("This program compares two floating point numbers up to epsilon 0.000001.\nIf the difference between the two numbers is greater than epsilon,\nthe program will consider the numbers to be different.");
        Console.WriteLine("\nPlease type in the first number: ");
        double firstnumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please type in the second number:");
        double secondnumber = double.Parse(Console.ReadLine());
        double diff = Math.Abs(firstnumber - secondnumber);
        double eps = 0.000001;
        bool check = diff < eps;
        Console.WriteLine("Is number {0} equal to number {1}? True or False?", firstnumber, secondnumber);
        Console.WriteLine(check);
        Console.ReadKey();
    }
}

