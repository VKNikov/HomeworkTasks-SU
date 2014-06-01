//Problem 13.	Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1.

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("This program extracts checks if the bit at position \np(counting from 0, starting from the right)\nin given integer (n) has value of 1.");
        Console.WriteLine("If the value is 1, the program will return \"True\" as a result");
        Console.WriteLine("Please enter an integer:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of the position for which \nyou want to check the value of:");
        int p = int.Parse(Console.ReadLine());
        int newNumber = n >> p;
        int bitP = newNumber & 1;
        bool check = bitP == 1;
        Console.WriteLine(check);
    }
}
