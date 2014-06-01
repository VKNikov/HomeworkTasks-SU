//Problem 5.	Formatting Numbers
//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. 
//Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, 
//padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. 

using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine(@"This program will make columns representing three different
numbers, integer a (with value 0 <= a <= 500), floating-point
b and floating-point c. The columns will be 4. The first will
represent the number a in hexadecimal form, the second will 
show a in binary form, the third will print number b with two
digits after the decimal point, right aligned, and number c
will be printed with 3 digits after the decimal point, left
aligned.");
        Console.WriteLine("\nPlease enter a positive (0 <= a <= 500) integer for a:");
        string aString = Console.ReadLine();
        ushort a;

        while ((!ushort.TryParse(aString, out a)) || a < 0 || a > 500)
        {
            Console.WriteLine("Invalid value for integer a. Pleasy try again ( 0 ≤ a ≤ 500)");
            aString = Console.ReadLine();
        }

        Console.WriteLine("Please enter a number for b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number for c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}