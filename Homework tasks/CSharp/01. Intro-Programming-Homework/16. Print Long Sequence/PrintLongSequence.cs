//Problem 16.	* Print Long Sequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintLongSequence
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        Console.WriteLine("Printing sequence up to 1000 members:");
        for (int i = 2; i < 1001; i++)
        {
            Console.WriteLine(i % 2 == 0 ? i : -i);
        }
        Console.ReadKey();
    }
}

