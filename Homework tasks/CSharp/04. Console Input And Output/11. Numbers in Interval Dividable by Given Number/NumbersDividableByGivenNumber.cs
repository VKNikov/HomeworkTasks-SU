//Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. 

using System;

class NumbersDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("This program reads two positive integers and prints \nhow many numbers p exist between them \nso that the reminder of the divison by 5 is 0.");
        Console.WriteLine("Please enter value for positive integer 1:");
        uint n1 = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for positive integer 2:");
        uint n2 = uint.Parse(Console.ReadLine());
        int p = 0;

        Console.WriteLine("The numbers that divide by 5 with reminder 0 are: \n");

        for (uint i = n1; i < n2 + 1; i++)
        {
            if (i % 5 == 0)
            {
                p++;
                Console.Write("{0}, ", i);
            }
        }

        Console.WriteLine("\n\nThere are {0} numbers between {1} and {2} \nthat can be divided by 5 with reminder 0", p, n1, n2);
    }
}
