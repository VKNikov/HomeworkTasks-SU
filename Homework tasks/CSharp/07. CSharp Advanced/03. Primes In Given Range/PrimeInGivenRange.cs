//Problem 3.	Primes in Given Range
//Write a method that calculates all prime numbers in given range and returns them as list of integers:
//static List<int> FindPrimesInRange(startNum, endNum)
//{
//    …
//}
//Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.

using System;
using System.Collections.Generic;

class PrimeInGivenRange
{
    static void Main()
    {
        Console.WriteLine("This program calculates all prime numbers in a given range and returns them as list of integers.");
        Console.WriteLine("Please enter the starting integer number:");
        long startNum = long.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the ending integer number:");
        long endNum = long.Parse(Console.ReadLine());

        List<long> primeNumbers = FindPrimesInRange(startNum, endNum);

        if (primeNumbers.Count == 0)
        {
            Console.WriteLine("emplty list");
        }
        else
        {
            foreach (var prime in primeNumbers)
            {
                Console.Write(prime + ", ");
            }
        }
    }

    static List<long> FindPrimesInRange(long first, long last)
    {
        List<long> primeNumbers = new List<long>();
        if (first < 2)
        {
            first = 2;
        }

        for (long i = first; i < last; i++)
        {
            bool isFirstPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isFirstPrime = false;
                    break;
                }
            }
            if (isFirstPrime)
            {
                primeNumbers.Add(i);
            }
        }
        return primeNumbers;
    }
}
