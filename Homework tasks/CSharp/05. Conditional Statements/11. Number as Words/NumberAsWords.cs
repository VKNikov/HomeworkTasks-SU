//Problem 11.	* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 

using System;

class NumbersAsWords
{
    static string UppercaseFirst(string words)
    {
        if (string.IsNullOrEmpty(words))
        {
            return string.Empty;
        }
        char[] a = words.ToCharArray();
        a[0] = char.ToUpper(a[0]);
        return new string(a);
    }


    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int n1 = number / 100;
        int n2 = (number % 100) / 10;
        int n3 = number % 10;

        string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tens = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] hundreds = { "", "One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred" };
        string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        if (n1 > 0 && n2 == 0 && n3 == 0)
        {
            Console.Write(UppercaseFirst(hundreds[n1]));
        }
        else if (n1 > 0 && n2 > 1 && n3 > 0)
        {
            Console.Write(UppercaseFirst(hundreds[n1]) + " and " + tens[n2] + " " + ones[n3]);
        }
        else if (n1 > 0 && n2 == 0 && n3 > 0)
        {
            Console.Write(UppercaseFirst(hundreds[n1]) + " and " + ones[n3]);
        }
        else if (n1 > 0 && n2 == 1)
        {
            Console.Write(UppercaseFirst(hundreds[n1]) + " and " + teens[n3]);
        }
        else if (n1 > 0 && n3 == 0)
        {
            Console.Write(UppercaseFirst(hundreds[n1]) + " and " + tens[n2]);
        }
        else if (n1 == 0 && n3 == 0 && n2 > 0)
        {
            Console.Write(UppercaseFirst(tens[n2]));
        }
        else if (n1 == 0 && n2 == 1 && n3 > 0)
        {
            Console.Write(UppercaseFirst(teens[n3]));
        }
        else if (number < 10 && number > 0)
        {
            Console.Write(UppercaseFirst(ones[n3]));
        }
        else if (number == 0)
        {
            Console.Write(UppercaseFirst(ones[0]));
        }

        Console.WriteLine();
    }
}
