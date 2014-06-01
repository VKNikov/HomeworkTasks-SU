//Problem 9.	Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. 

using System;

class SumOfnNumbers
{
    static void Main()
    {
        Console.WriteLine("This program calculates the sum of n numbers");
        Console.WriteLine("In order to do that, please enter how many numbers you want to calculate the sum of:");
        int n       = int.Parse(Console.ReadLine());
        double b    = 0;
        double sum  = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter value for number {0} ", i + 1);
            b = double.Parse(Console.ReadLine());
            sum += b;
        }
        Console.WriteLine("The sum of the numbers you have enter is {0}.", sum);
    }
}