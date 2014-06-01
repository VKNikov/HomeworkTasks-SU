//Problem 15.	Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts a hexadecimal integer to its decimal form.");
        Console.WriteLine("Please enter an hexadecimal integer:");
        string userinput = Console.ReadLine();
        userinput = userinput.ToUpper();

        char[] chararray = userinput.ToCharArray();
        Array.Reverse(chararray);
        string reversed = new string(chararray);
        long result = 0;

        for (int i = 0; i < userinput.Length; i++)
        {
            switch (reversed[i])
            {
                case '0':
                    result += 0 * (long)Math.Pow(16, i);
                    break;
                case '1':
                    result += 1 * (long)Math.Pow(16, i);
                    break;
                case '2':
                    result += 2 * (long)Math.Pow(16, i);
                    break;
                case '3':
                    result += 3 * (long)Math.Pow(16, i);
                    break;
                case '4':
                    result += 4 * (long)Math.Pow(16, i);
                    break;
                case '5':
                    result += 5 * (long)Math.Pow(16, i);
                    break;
                case '6':
                    result += 6 * (long)Math.Pow(16, i);
                    break;
                case '7':
                    result += 7 * (long)Math.Pow(16, i);
                    break;
                case '8':
                    result += 8 * (long)Math.Pow(16, i);
                    break;
                case '9':
                    result += 9 * (long)Math.Pow(16, i);
                    break;
                case 'A':
                    result += 10 * (long)Math.Pow(16, i);
                    break;
                case 'B':
                    result += 11 * (long)Math.Pow(16, i);
                    break;
                case 'C':
                    result += 12 * (long)Math.Pow(16, i);
                    break;
                case 'D':
                    result += 13 * (long)Math.Pow(16, i);
                    break;
                case 'E':
                    result += 14 * (long)Math.Pow(16, i);
                    break;
                case 'F':
                    result += 15 * (long)Math.Pow(16, i);
                    break;
            }
        }
        Console.WriteLine(result);
    }
}
