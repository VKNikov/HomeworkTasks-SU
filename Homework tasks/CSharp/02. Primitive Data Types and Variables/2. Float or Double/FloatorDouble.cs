//Problem 2.	Float or Double?
//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? 
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatorDouble
{
    static void Main()
    {
        //First, I am assigning the numbers for the float variable and then for the double
        float floatsmall = 12.345f;
        float floatbig = 3456.091f;
        double doublesmall = 8923.1234857;
        double doublebig = 34.567839023;
        Console.WriteLine("{0}, {1}, {2}, {3}", floatsmall, floatbig, doublesmall, doublebig);
    }
}
