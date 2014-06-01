//Problem 6.	Longest Area in Array
//Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them. 

using System;

class LongestAreaInArray
{
    static void Main()
    {
        Console.WriteLine("This program finds the longest area of equal elements in an array of string.");
        Console.WriteLine("Please state how many strings do you like to compare(enter an integer).");

        int n                   = int.Parse(Console.ReadLine());
        string[] arrayOfStrings = new string[n];
        string element          = string.Empty;
        int currentCounter      = 1;
        int finalCounter        = 1;

        //Populate the string array with n input entries
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter a string and press \"enter\".");
            arrayOfStrings[i] = Console.ReadLine();
        }

        element = arrayOfStrings[0];

        //Checking if the next string in the array equals the one before that and if Yes, increaseu currentCounter. If currentCounter's value is higher than finalCounter value, change finalCounter's value. If the current string is not equal to the one before, reset the currentCounter to 1.
        for (int i = 1; i < n; i++)
        {
            if (arrayOfStrings[i] == arrayOfStrings[i - 1])
            {
                currentCounter++;
                if (currentCounter > finalCounter)
                {
                    element = arrayOfStrings[i - 1];
                    finalCounter = currentCounter;
                }
                
            }
            else
            {
                currentCounter = 1;
            }
        }

        Console.WriteLine(finalCounter);

        for (int i = 0; i < finalCounter; i++)
        {
            Console.WriteLine(element);
        }
    }
}
