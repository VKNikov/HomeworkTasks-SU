//Problem 8.	Prime Number Check
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        //The program will check if a given integer is a prime number for any integer n, not just n ≤ 100
        Console.WriteLine("This program will check if a given positive integer number is a prime number or not.\nPlease enter an integer:");
        int n = int.Parse(Console.ReadLine());
        bool check = true;

        if (n <= 0)
        {
            Console.WriteLine("Is number {0} a prime number? True or False?\nFalse", n);
        }
        else if (n == 2 || n == 3 || n == 5 || n == 7)
        {
            Console.WriteLine("Is number {0} a prime number? True or False?\nTrue", n);
        }
        else
        {
            for (int i = 2; i <= (uint)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    check = false;
                }
            }
            Console.WriteLine("Is number {0} a prime number? True or False?\n{1}", n, check);
        }

        Console.WriteLine("Press enter to exit...");
        Console.ReadKey();
    }
}