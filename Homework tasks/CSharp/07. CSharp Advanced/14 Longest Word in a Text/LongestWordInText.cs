//Problem 14.	Longest Word in a Text
//Write a program to find the longest word in a text. 

using System;
using System.Linq;

class LongestWordInText
{
    static void Main()
    {
        Console.WriteLine("This program will find the longest word in a given text.");
        Console.WriteLine("Please enter a text:");

        string input = Console.ReadLine();

        char[] charsToBeRemoved = { ',', '.', '!', ':', ';', '?'};

        for (int i = 0; i < charsToBeRemoved.Length; i++)
        {
            input = input.Replace(charsToBeRemoved[i], ' ');
        }

        string[] inputAsArray = input.Split(' ');
        string longest = inputAsArray.OrderBy(x => x.Length).Last();

        Console.WriteLine("The longest word in this text is:");
        Console.WriteLine(longest);
    }
}
