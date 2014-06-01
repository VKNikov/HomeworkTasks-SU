//Problem 9.	Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("This program will print a matrix. In order to do that please enter a positive integer n (where n is bigger than 0 and less than 21):");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n < 21)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(" {0,2}", i);
                for (int j = i + 1; j < n + i; j++)
                {

                    Console.Write(" {0,2}", j);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input data. Please try again.");
        }
    }
}