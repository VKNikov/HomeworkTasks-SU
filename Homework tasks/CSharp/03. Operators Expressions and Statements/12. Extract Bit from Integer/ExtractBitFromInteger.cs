//Problem 12.	Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p. 

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("This program will extract from a given integer (n) the value of given bit at index p");
        Console.WriteLine("Please enter an integer:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of the bit you want to extract. Note that the counting of the bits starts from 0.");
        int p = int.Parse(Console.ReadLine());
        int bitP = n >> p;
        int showBitP = bitP & 1;
        Console.WriteLine("The value of the bit at index {0} of integer {1} is: {2}", p, n, showBitP);
    }
}