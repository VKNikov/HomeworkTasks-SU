//Problem 8.	Numbers from 1 to n
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop.

using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.BufferHeight = 10000;

        Console.WriteLine("This program will print all the numbers from 1 to n(where n is a random input number) on a separate line.\nEnter a number:");
        int number = int.Parse(Console.ReadLine());
        int n = 1;

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(n);
            n++;
        }
    }
}