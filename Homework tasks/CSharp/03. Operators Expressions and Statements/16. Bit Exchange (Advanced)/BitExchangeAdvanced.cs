//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. 

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.WriteLine(@"This program will exchange bits (p, p+1, ..., p+k-1) 
with bits (q, q+1, ..., q+k-1) of any unsigned 32-bit integer. 
The first and the second sequence cannot overlap!");
        Console.WriteLine("Please enter a 32-bit unsigned integer:");
        uint number = 0;

        try
        {
            number = uint.Parse(Console.ReadLine());
        }
        catch (OverflowException)
        {

            Console.WriteLine("out of range");
            return;
        }

        Console.WriteLine("Please enter the position of the first bit from the first sequence:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the position of the first bit from the second sequence:");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for k (k is the range of the bits that will be exchanged for each sequence");
        int k = int.Parse(Console.ReadLine());

        //This checks if the input values for p, q, and k are correct and within the limit of the unsigned 32-bit integers.
        while ((p + k > 32 || (q + k > 32)) || (p < 0 || q < 0 || k < 0))
        {
            Console.WriteLine("The sequences you have entered are out of the range of 32-bit unsigned integers!");
            Console.WriteLine("Enter again the position of the first bit from the first sequence:");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter again the position of the first bit from the second sequence:");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter again value for k (k is the range of the bits that will be exchanged for each sequence");
            k = int.Parse(Console.ReadLine());
        }

        //This part checks if the two sequences overlap.
        while ((p > q && (q + k > p)) || (p < q && (p + k > q)))
        {
            Console.WriteLine("Overlapping sequences! The two sequences cannot overlap.");
            Console.WriteLine("Enter again the position of the first bit from the first sequence:");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter again the position of the first bit from the second sequence:");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter again value for k (k is the range of the bits that will be exchanged for each sequence");
            k = int.Parse(Console.ReadLine());
        }

        string binarynumber = Convert.ToString(number, 2).PadLeft(32, '0');
        uint storeorignumber = number;

        //This conditional statement checks which bit position, p or q is bigger in order to correctly exchange the bits. Turned out I have to rewrite everything to fix it to work without if-else statement.
        if (p < q)
        {
            for (int i = 0; i < k; i++)
            {
                uint mask1          = (number & ((uint)(1 << p))) << (q - p); //Gets bit from positon p and moves it to position q.
                uint nullify1       = number & ((uint)~(1 << q)); //Sets position q of the  number to bit value 0.
                uint exchange1      = nullify1 | mask1; //Applies bit p to position q.

                uint mask2      = (number & ((uint)(1 << q))) >> (q - p);
                uint nullify2   = exchange1 & ((uint)~(1 << p));
                number          = nullify2 | mask2;

                p++;
                q++;
            }
        }
        else
        {
            for (int i = 0; i < k; i++)
            {
                uint mask1      = (number & ((uint)(1 << q))) << (p - q); //Gets bit from positon q and moves it to position p.
                uint nullify1   = number & ((uint)~(1 << p)); //Sets position p of the  number to bit value 0.
                uint exchange1  = nullify1 | mask1; //Applies bit p to position q.

                uint mask2      = (number & ((uint)(1 << p))) >> (p - q);
                uint nullify2   = exchange1 & ((uint)~(1 << q));
                number          = nullify2 | mask2;

                p++;
                q++;
            }
        }
        string finalbinary = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("The binary representation of number {0} is {1}. \nAfter exchanging the desired bits, the new number is \n{2} with binary representation {3}", storeorignumber, binarynumber, number, finalbinary);
    }
}