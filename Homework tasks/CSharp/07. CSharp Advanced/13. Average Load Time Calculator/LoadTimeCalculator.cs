//Problem 13.	Average Load Time Calculator
//We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Print the output in the format given below. Use double floating-point precision. 

using System;
using System.Collections.Generic;
using System.Linq;

class LoadTimeCalculator
{
    static void Main()
    {
        //Now this was one hell of a task! :)
        Console.WriteLine("This program reads a report of web sites and load times. After that it calculates the average load time for each URL.");
        Console.WriteLine("Please enter a report:");

        Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
        string input = Console.ReadLine();
        
        //I've got some of the ideas for this algorithm from one of the guys in softuni's forum. Made my own optimizations though.
        while (input != string.Empty)
        {
            input = input.Substring(18);
            string [] splitted = input.Split(' ');

            if (!dict.Keys.Contains(splitted[0]))
            {
                dict.Add(splitted[0], new List<double> { double.Parse(splitted[1]) });
            }
            else
            {
                dict[splitted[0]].Add(double.Parse(splitted[1]));
            }
            
            input = Console.ReadLine();
        }

        Console.WriteLine("The average load time for each URL is:");

        //This will print the URLs and their average loadtime.
        foreach (var entry in dict)
        {
            Console.WriteLine("{0} -> {1}", entry.Key, entry.Value.Average());
        }
        
    }
}
