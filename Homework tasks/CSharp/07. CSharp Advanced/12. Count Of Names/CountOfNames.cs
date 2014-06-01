//Problem 12.	Count of Names
//Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. Use the input and output format from the examples below. 

using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        //Note that the second example is wrong. Nakov is before Softuni alphabetically and has 4 entries instead of 5.
        Console.WriteLine("This program prints a list of names in alphabetical order and shows exactly how many times this name is present in the list.");
        Console.WriteLine("Please enter a list of names to be sorted:");
        string input            = Console.ReadLine();
        string[] inputAsArray   = input.Split(' ');

        List<string> inputAsList = inputAsArray.ToList();
        inputAsList.Sort();

        var final = inputAsList.GroupBy(x => x).ToList();

        foreach (var word in final)
        {
            Console.WriteLine("{0} -> {1}", word.Key, word.Count());
        }
    }
}
