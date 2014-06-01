//Problem 1.	Exchange If Greater
//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. 

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("This program takes two integers a and b and exchanges their values.");
        Console.WriteLine("Please enter value for integer a:");
        string a = Console.ReadLine();
        Console.WriteLine("Please enter value for integer b:");
        string b = Console.ReadLine();
        int c;
        int d;

        bool aisint = int.TryParse(a, out c);
        bool bisint = int.TryParse(b, out d);

        if (aisint == false || bisint == false || c < d)
        {
            Console.WriteLine("{0} {1}", a, b);
        }
        else if (c > d)
        {
            int e;
            e = c;
            c = d;
            d = e;
            Console.WriteLine("{0} {1}", c, d);
        }
    }
}
