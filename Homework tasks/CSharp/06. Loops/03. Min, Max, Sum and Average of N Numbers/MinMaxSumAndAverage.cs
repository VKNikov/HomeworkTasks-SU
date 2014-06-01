//Problem 3.	Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. 

using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        Console.WriteLine("This program reads a sequence of n integers and returns the minimal, the maximal, the sum and the average of all");
        Console.WriteLine("Please enter for how many numbers (n) do you want to calculate the min, max, sum and average:");

        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        double sum = 0;
        double average = 0.0;
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number:");
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
            average = sum / n;

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            else if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine("Min: {0}", min);
        Console.WriteLine("Max: {0}", max);
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Average: {0:F2}", average);
    }
}
