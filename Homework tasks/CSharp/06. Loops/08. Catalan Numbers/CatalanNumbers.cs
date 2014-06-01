//Problem 8.	Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula:
// Cn = (2n)! / (n+1)!n! = 1 * (2n) / n + 1 * n
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). 

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program will calculate the nth Catalan number by given integer n(where n > 1 and < 100.");
        Console.WriteLine("Please enter value for n:");
        int n = int.Parse(Console.ReadLine());
        BigInteger nfactorial       = 1;
        BigInteger n2factorial      = 1;
        BigInteger nplusfactorial   = 1;
        BigInteger catalanN;

        //In the homework assignment it says n > 1 and <100. However, the examples there is one with 0 as n, so I have made my program works with 0 as well.
        if (n >= 0)
        {

            for (int i = 1; i <= 2 * n; i++)
            {
                n2factorial *= i;

                if (i <= n)
                {
                    nfactorial *= i;
                }

                if (i <= n + 1)
                {
                    nplusfactorial *= i;
                }
            }
        }
        else
        {
            Console.WriteLine("n cannot have value less than 0. Try again.");
        }
        catalanN = n2factorial / (nplusfactorial * nfactorial);
        Console.WriteLine(catalanN);
    }
}
