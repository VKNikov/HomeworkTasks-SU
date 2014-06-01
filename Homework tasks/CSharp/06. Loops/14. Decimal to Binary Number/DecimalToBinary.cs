//Problem 14.	Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("This program converts an integer to its binary representation");
        Console.WriteLine("Please enter an integer:");
        long number = long.Parse(Console.ReadLine());
        long dividingNumber = number;
        long remainder = 0;
        string [] toBinary = new string [64];
        string final = string.Empty;

        for (int i = 1; i <= 64; i++)
        {
            remainder = dividingNumber % 2;
            dividingNumber /= 2;
            if (remainder == 1)
            {
                toBinary[64 - i] = Convert.ToString(remainder);
            }
            else
            {
                toBinary[64 - i] = Convert.ToString(remainder);
            }
        }
        for (int i = 0; i < toBinary.Length; i++)
        {
            if (toBinary[i] == "1")
            {
                for (int j = i; j < toBinary.Length; j++)
                {
                    final += toBinary[j];
                }
                break;
            }
        }
        Console.WriteLine("The binary representation of the integer {0} is:", number);
        Console.WriteLine(final);
    }
}
