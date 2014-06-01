//Problem 11.	Bitwise: Extract Bit #3
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. 
//The result of the expression should be either 1 or 0.

using System;

class ExctractBit3
{
    static void Main()
    {
        Console.WriteLine("This program will find the value of bit #3(the counting starts from 0)\nof any given unsigned integer.\nPlease write in a positive integer:");
        ulong userInput = ulong.Parse(Console.ReadLine());
        ulong newNumber = userInput >> 3;
        ulong showBit3 = newNumber & 1;
        Console.WriteLine("The bit #3 in the integer {0} is {1}", userInput, showBit3);
    }
}
