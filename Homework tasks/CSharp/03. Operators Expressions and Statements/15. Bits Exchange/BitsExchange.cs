//Problem 15.	* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 

using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("This program exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of a given 32bit unsigned integer.");
        Console.WriteLine("Please enter an integer:");
        uint number = uint.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(number, 2).PadLeft(32, '0');
        uint mask24 = (number & (7 << 3)) << 21; //Gets bits value at positions 3,4,5 and moves them to positions 24,25,26 of the mask(7).
        uint mask3 = (number & (7 << 24)) >> 21; //Gets bits value at positions 24,25,26 and moves them to positions 3,4,5 of the mask(7).
        uint number24Null = (uint)(~(7 << 24) & number); //Nullify bits at position 24,25,26 of the original number.
        uint number24Exchanged = number24Null | mask24; //Exchange bits 24,25,26 with bits 3,4,5 of the original number.
        uint number3Null = (uint)(~(7 << 3) & number24Exchanged); //Nullify bits at position 3,4,5 of the number with already exchanged bits 24,25,26.
        uint finalNumber = (number3Null | mask3); //Finally exchange bits 3,4,5 and thus completing the task.
        string binaryFinalNumber = Convert.ToString(finalNumber, 2).PadLeft(32, '0');
        Console.WriteLine("The binary representation of {0} is {1}.", number, binaryNumber);
        Console.WriteLine("After exchanging bits 24,25,26 with 3,4,5, the new number is {0} with binary representation \n{1}", finalNumber, binaryFinalNumber);
    }
}
