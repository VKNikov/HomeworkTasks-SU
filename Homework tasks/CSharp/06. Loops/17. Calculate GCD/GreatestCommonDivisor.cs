//Problem 17.	* Calculate GCD
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        //This first algorithm uses the subracting method to find the GCD.
        //Console.WriteLine("This program finds the GCD of two integers.");
        //Console.WriteLine("Please enter the first integer:");
        //int a = int.Parse(Console.ReadLine());
        //Console.WriteLine("Please enter the second integer:");
        //int b = int.Parse(Console.ReadLine());
        //int divisor = Math.Abs(a - b);

        //if (a > b)
        //{
        //    while (divisor != b)
        //    {
        //        divisor -= Math.Abs(b);
        //        b = divisor;
        //    }
        //}
        //else if (b > a)
        //{
        //    while (divisor != a)
        //    {
        //        divisor -= Math.Abs(a);
        //        a = divisor;
        //    }
        //}
        //else if (a == 0 || b == 0)
        //{
        //    divisor = 0;
        //}
        //else if (a == b)
        //{
        //    divisor = a;
        //}
        //Console.WriteLine(Math.Abs("The GCD is: {0}",divisor));


        //This one uses division and remainders. It is supposedly faster :).
        Console.WriteLine("This program finds the GCD of two integers.");
        Console.WriteLine("Please enter the first integer:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second integer:");
        int b = int.Parse(Console.ReadLine());
        int divisor = 1;

        if (a > b)
        {

            while (b != 0)
            {
                divisor = b;
                b = a % b;
                a = divisor;
            }
            Console.WriteLine("The GCD is: {0}", divisor);
        }
        else if (b > a)
        {
            while (a != 0)
            {
                divisor = a;
                a = b % a;
                b = divisor;
            }
            Console.WriteLine("The GCD is: {0}", divisor);
        }
        else if (a == 0 || b == 0)
        {
            divisor = 0;
            Console.WriteLine("The GCD is: {0}", divisor);
        }
        else if (a == b)
        {
            divisor = a;
            Console.WriteLine("The GCD is: {0}", divisor);
        }
    }
}
