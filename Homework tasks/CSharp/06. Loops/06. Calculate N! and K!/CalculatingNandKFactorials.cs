//Problem 6.	Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

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

            BigInteger nkfactorial = 1;

            //Found out in the forums about this trick. Instead of calculating N! and K! separately, since K < N, this means K is subset of N and the result of N!/K! is actually = N * (N-1) * (N-2) ... * (K+1)
            for (int i = n; i > k; i--)
            {
                nkfactorial *= i;
            }
            Console.WriteLine(nkfactorial);
        }
    }
}
