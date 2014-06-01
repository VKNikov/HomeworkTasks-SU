//Problem 6.	Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. 

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter a four-digit number:");
        int userInput = int.Parse(Console.ReadLine());

        while ((userInput > 9999) || (userInput < 999))
        {
            Console.WriteLine("This is not a four-digit number. Please enter a four-digit number!");
            userInput = int.Parse(Console.ReadLine());
        }

        int d = userInput % 10;
        int c = (userInput / 10) % 10;
        int b = (userInput / 100) % 10;
        int a = (userInput / 1000) % 10;

        Console.WriteLine("The sum of the digits is: {0}", a + b + c + d);
        Console.WriteLine("The number {0} written in reversed order is {1}{2}{3}{4}", userInput, d, c, b, a);
        Console.WriteLine("If you put the last digit into the first place, the number will be: {0}{1}{2}{3}", d,a,b,c);
        Console.WriteLine("If we exchange the second and the third digit, the number will be: {0}{1}{2}{3}", a,c,b,d);
    }
}