﻿//Problem 9.	Exchange Variable Values
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a + " " + b);
        a = 10;
        b = 5;
        Console.WriteLine(a + " " + b);
    }
}

