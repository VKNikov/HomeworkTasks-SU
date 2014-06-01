//Problem 7.	Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:
// (n or k) = n!/k!
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_N__and_K_
{
    class CalculatingNandKFactorials
    {
        static void Main()
        {
            Console.WriteLine("This program calculates the number of different ways to choose k different members out of a group of n different elements.");
            Console.WriteLine("Please enter value for n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for k:");
            int k = int.Parse(Console.ReadLine());
            BigInteger nk           = n - k;
            BigInteger nfactorial   = 1;
            BigInteger kfactorial   = 1;
            BigInteger nkfactorial  = 1;

            for (int i = 1; i <= n; i++)
            {
                nfactorial *= i;

                if (i <= k)
                {
                    kfactorial *= i;
                }
                if (i <= nk)
                {
                    nkfactorial *= i;
                }
            }

            Console.WriteLine(nfactorial / (kfactorial * nkfactorial));

        }
    }
}
