//Problem 2.	Prime Checker
//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 

using System;

class PrimeChecker
{
    static void Main()
    {
        Console.WriteLine("This program will check if a given positive integer number is a prime number or not.\nPlease enter an integer:");
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine("Is the integer n prime?");
        Console.WriteLine(IsPrime(n));
    }

    public static bool IsPrime(long n)
    {
        bool IsPrime = true;

        if (n <= 0 || n == 1)
        {
            IsPrime = false;
        }
        else if (n == 2 || n == 3 || n == 5 || n == 7)
        {
            IsPrime = true;
        }
        else
        {
            for (int i = 2; i <= (uint)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    IsPrime = false;
                }
            }
        }
        return IsPrime;
    }
}
