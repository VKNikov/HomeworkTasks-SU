//Problem 9.	Remove Names
//Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. 

using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string firstList            = Console.ReadLine();
        List<string> arrayFirst     = new List<string>(firstList.Split(' '));
        string secondList           = Console.ReadLine();
        List<string> arraySecond    = new List<string> (secondList.Split(' '));

        for (int i = 0; i < arraySecond.Count; i++)
        {
            for (int j = 0; j < arrayFirst.Count; j++)
            {
                if (arrayFirst[j] == arraySecond[i])
                {
                    arrayFirst.RemoveAll(item => item == arrayFirst[j]);
                }
            }
        }

        foreach (var word in arrayFirst)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
        
    }
}
