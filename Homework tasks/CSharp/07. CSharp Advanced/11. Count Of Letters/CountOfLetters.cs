//Problem 11.	Count of Letters
//Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. Use the input and output format from the examples below. 

using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        Console.WriteLine("This program prints lists of letters in alphabetical order, showing exactly how many time a letter is present in list.");
        Console.WriteLine("Please enter a list of letters:");
        string input = Console.ReadLine();

        string [] inputAsArray      = input.Split(' ');
        List<string> inputAsList    = new List<string>(inputAsArray);
        inputAsList.Sort();

        var final = inputAsList.GroupBy(x => x).ToList();

        foreach (var letter in final)
        {
            Console.WriteLine("{0} -> {1}", letter.Key, letter.Count());
        }
    }
}
