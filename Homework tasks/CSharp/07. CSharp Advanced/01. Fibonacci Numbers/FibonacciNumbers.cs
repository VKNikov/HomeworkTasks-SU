//Problem 1.	Fibonacci Numbers
//Define a method Fib(n) that calculates the nth Fibonacci number. 

using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads a number n and prints the nth Fibonacci number.");
        Console.WriteLine("Enter value for n:");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        n = Fib(n);

        Console.WriteLine("The nth Fibonacci number is: {0}", n);
    }

    private static BigInteger Fib(BigInteger n)
    {
        BigInteger fibnum1 = 0;
        BigInteger fibnum2 = 1;
        BigInteger fibnum1and2 = 0;

        //Console.WriteLine("The fibonacci sequence up to number {0} is:", n);

        if (n > 1)
        {

            for (BigInteger i = 0; i < n; i++)
            {
                fibnum1and2 = (fibnum1 + fibnum2) - fibnum1;
                fibnum2 = (fibnum1 + fibnum2);
                fibnum1 = fibnum1and2;
            }
        }
        else if (n == 0 || n == 1 || n == -1)
        {
            if (n == 0 || n == 1)
            {
                fibnum2 = 1;
            }
            else
            {
                fibnum2 = -1;
            }
        }
        else //This gets executed if n is a negative integer. Fibonacci numbers can have negative values.
        {
            //Console.Write("0, -1, ");
            for (BigInteger i = 0; i < (-n); i++)
            {
                    fibnum1and2 = (fibnum1 + fibnum2) - fibnum1;
                    fibnum2 = (fibnum1 + fibnum2);
                    fibnum1 = fibnum1and2;
                    if (i == (-n - 1) && i % 2 == 0)
                    {
                        fibnum2 = -fibnum2;
                    }
            }
        }

        n = fibnum2;
        return n;
    }
}
