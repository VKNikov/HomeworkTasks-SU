//Problem 14.	* Print the ASCII Table
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). 
//Note that some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently. You may need to use for-loops (learn in Internet how).

using System;

class PrintTheASCIITable
{
    static void Main()
    {
        //My program tries to print all the characters, even those that ado not have text representation, so not everything will be displayed or displayed correctly.
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        for (char i = (char) 1; i < (char) 256; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}

