//Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculatingFactorials
{
    static void Main()
    {
        //Note that the first two examples in the homework do not work with this program. However, I believe it to be working correctly.

        Console.WriteLine("Given two integers n and x, this program will calculate a sum according to the expression \nS = 1 + 1!/x + 2!/x^2 + … + n!/x^n");
        Console.WriteLine("Please enter value for n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for x:");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}
