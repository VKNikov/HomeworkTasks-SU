//Problem 10.	Join Lists
//Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. 

using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string firstInput       = Console.ReadLine();
        string secondInput      = Console.ReadLine();

        List<int> firstList     = firstInput.Split(' ').Select(int.Parse).ToList();
        List<int> secondList    = secondInput.Split(' ').Select(int.Parse).ToList();
        List<int> final         = firstList.Union(secondList).ToList();

        final.Sort();

        foreach (var item in final)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
