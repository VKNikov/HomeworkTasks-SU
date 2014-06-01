//Problem 11.	Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.WriteLine("This program prints random n numbers between a specific range.");
        Console.WriteLine("Please enter how many random numbers do you want to be printed (value for n):");
        int n = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        Console.WriteLine("Please enter an integer for the beginning of the range:");
        min = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("Please enter an integer for the end of the range (this number should be greater than the previous one!):");
            max = int.Parse(Console.ReadLine());
        } while (max < min);
        
        Random randomization = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(randomization.Next(min, max));
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
