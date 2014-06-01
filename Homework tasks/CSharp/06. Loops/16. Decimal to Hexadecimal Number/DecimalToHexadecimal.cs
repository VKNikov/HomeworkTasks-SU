using System;

class DecimalToHexadecimal
{
    public static string Reversed(string userinput)
    {
        char[] chararray = userinput.ToCharArray();
        Array.Reverse(chararray);
        return new string(chararray);
    }
    static void Main()
    {
        Console.WriteLine("This program converts an integer number from decimal to hexadecimal system");
        Console.WriteLine("Please enter an integer:");
        long input = long.Parse(Console.ReadLine());
        string result = string.Empty;

        while (input > 0)
        {
            long remainder = input % 16;
            input /= 16;
            switch (remainder)
            {
                case 0:
                    result += '0';
                    break;
                case 1:
                    result += '1';
                    break;
                case 2:
                    result += '2';
                    break;
                case 3:
                    result += '3';
                    break;
                case 4:
                    result += '4';
                    break;
                case 5:
                    result += '5';
                    break;
                case 6:
                    result += '6';
                    break;
                case 7:
                    result += '7';
                    break;
                case 8:
                    result += '8';
                    break;
                case 9:
                    result += '9';
                    break;
                case 10:
                    result += 'A';
                    break;
                case 11:
                    result += 'B';
                    break;
                case 12:
                    result += 'C';
                    break;
                case 13:
                    result += 'D';
                    break;
                case 14:
                    result += 'E';
                    break;
                case 15:
                    result += 'F';
                    break;
            }
        }
        result = Reversed(result);
        Console.WriteLine("The hexadecimal representation of this number is: {0}", result);
    }
}
