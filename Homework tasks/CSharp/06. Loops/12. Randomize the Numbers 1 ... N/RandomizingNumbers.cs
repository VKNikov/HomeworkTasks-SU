//Problem 12.	* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 

using System;
using System.Collections.Generic;

class RandomizingNumbers
{
    static void Main()
    {
        Console.WriteLine("This program prints all the numbers between 1 and n in random order");
        string userinput = string.Empty;
        int n;
        do
        {
            Console.WriteLine("Please enter value for n (n must be an integer):");
            userinput = Console.ReadLine();
        } while (!int.TryParse(userinput, out n));

        int unknown = 1;

        List<int> storelist = new List<int>();
        Random randomize = new Random();

        while (true)
        {
            unknown = randomize.Next(1, n + 1);
            if (!storelist.Contains(unknown))
            {
                storelist.Add(unknown);
                Console.Write("{0} ", unknown);
            }
            if (storelist.Count == n)
            {
                break;
            }
        }
    }
}
