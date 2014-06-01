//Problem 14.	Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("This program will modify a bit in an integer at a given position.");
        Console.WriteLine("Please enter an integer:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the position of the bit you want to change(Counting starts from 0):");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the desired new value of the bit (0 or 1):");
        string bitValue = Console.ReadLine();
        int v;

        while (!int.TryParse(bitValue, out v) || (v != 0 && v != 1))
        {
            Console.WriteLine("Invalid input data. Please enter a value. Only 0 or 1 allowed!:");
            bitValue = Console.ReadLine();
        }

        if (v == 0)
        {
            int mask = ~(1 << p);
            int newNumber = n & mask;
            Console.WriteLine("The bitwise representation of the integer {0} is {1}.\nYou have modified position {2} with the number {3}.\nThe bitwise representation of the new number is {4}.\nThe resulting number is {5}", n, (Convert.ToString(n, 2).PadLeft(16, '0')), p, v, (Convert.ToString(newNumber, 2).PadLeft(16, '0')), newNumber);
        }
        else
        {
            int mask = 1 << p;
            int newnumber = n | mask;
            Console.WriteLine("The bitwise representation of the integer {0} is {1}.\nYou have modified position {2} with the number {3}.\nThe bitwise representation of the new number is {4}.\nThe resulting number is {5}.", n, (Convert.ToString(n, 2).PadLeft(16, '0')), p, v, (Convert.ToString(newnumber, 2).PadLeft(16, '0')), newnumber);
        }
    }
}
