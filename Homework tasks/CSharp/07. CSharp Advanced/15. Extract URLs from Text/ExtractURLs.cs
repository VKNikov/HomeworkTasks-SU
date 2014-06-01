//Problem 15.	Extract URLs from Text
//Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
//•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
//•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractURLs
{
    static void Main()
    {
        Console.WriteLine("This program will extract URLs from any given text.");
        Console.WriteLine("Please enter a text:");

        string input = Console.ReadLine();
        var extractedURLs = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www."));

        foreach (var URL in extractedURLs)
        {
            Console.WriteLine(URL);
        }
    }
}
