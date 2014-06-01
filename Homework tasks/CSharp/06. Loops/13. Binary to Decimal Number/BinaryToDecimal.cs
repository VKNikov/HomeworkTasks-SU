//Problem 13.	Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("This program will convert a binary integer into its decimal form.");
        Console.WriteLine("Please enter an integer in binary form:");
        string userinput = Console.ReadLine();
        BigInteger asNumber = BigInteger.Parse(userinput);
        BigInteger bitValue = 0;
        long asDecimal = 0;

        for (int i = 0; i < userinput.Length; i++)
        {

            bitValue  = asNumber % 10;
            asNumber /= 10;

            if (bitValue == 1)
            {
                asDecimal += (long) Math.Pow(2, i);
            }
        }
        Console.WriteLine("The decimal representation of the number {0} is:", userinput);
        Console.WriteLine(asDecimal);
    }
}
