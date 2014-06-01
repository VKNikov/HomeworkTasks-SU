//Problem 18.	* Trailing Zeroes in N!
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000. 

using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        Console.WriteLine("This program calculates the total number zeros which the factorial of n has at its end.");
        Console.WriteLine("Please enter value for n:");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i; 
        }

        string factorialString = Convert.ToString(nFactorial);
        int totalZeros = 0;

        for (int i = factorialString.Length - 1; i > 0; i--)
        {
            if (factorialString[i] == '0')
            {
                totalZeros++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("The total number of zeros is: {0}", totalZeros);
    }
}
