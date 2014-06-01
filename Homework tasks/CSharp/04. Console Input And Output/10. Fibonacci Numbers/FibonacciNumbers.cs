//Problem 10.	Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops

using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads a number n and prints the first n members of the Fibonacci sequence.");
        Console.WriteLine("Enter value for n:");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger fibNum1 = 0;
        BigInteger fibNum2 = 1;
        BigInteger fibNum1And2;

        Console.WriteLine("The fibonacci sequence up to number {0} is:", n);

        if (n > 1)
        {
            Console.Write("0, 1, ");

            for (BigInteger i = 0; i < (n - 2); i++)
            {
                if (i < (n - 1))
                {

                    Console.Write(fibNum1 + fibNum2 + ", ");
                    fibNum1And2     = (fibNum1 + fibNum2) - fibNum1;
                    fibNum2         = (fibNum1 + fibNum2);
                    fibNum1         = fibNum1And2;
                }
                else
                {
                    Console.Write(fibNum1 + fibNum2 + ", ...\n");
                    fibNum1And2     = (fibNum1 + fibNum2) - fibNum1;
                    fibNum2         = (fibNum1 + fibNum2);
                    fibNum1         = fibNum1And2;
                }
            }
        }
        else if (n == 0 || n == 1 || n == -1)
        {
            Console.WriteLine("0");
        }
        else //This gets executed if n is a negative integer. Fibonacci numbers can have negative values.
        {
            Console.Write("0, -1, ");

            for (BigInteger i = 0; i < ((-n) - 2); i++)
            {
                if (i < ((-n) - 1))
                {
                    Console.Write((-fibNum1) - fibNum2 + ", ");
                    fibNum1And2     = (fibNum1 + fibNum2) - fibNum1;
                    fibNum2         = (fibNum1 + fibNum2);
                    fibNum1         = fibNum1And2;
                }
                else
                {
                    Console.Write((-fibNum1) - fibNum2 + ", ...\n");
                    fibNum1And2     = (fibNum1 + fibNum2) - fibNum1;
                    fibNum2         = (fibNum1 + fibNum2);
                    fibNum1         = fibNum1And2;
                }
            }
        }
    }
}
