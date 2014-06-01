//Problem 5.	Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("This program checks whether the third digit(right to left) of an integer is 7.\nPlease enter an integer for checking:");
        int userInput   = int.Parse(Console.ReadLine());
        int division    = userInput / 100;
        bool remainder  = division % 10 == 7;
        Console.WriteLine("Is the third digit of the number {0} 7? True or False? \n{1}", userInput, remainder);
    }
}