//Problem 12.	Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. 
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        //Note that I deliberately do not assign new values for the nullable variables int and double, because the purpose of the homework, at least as I see it, is to try and add 'something' to 'nothing'and to see what will happen.
        int? number = null;
        double? floatingnumber = null;
        Console.WriteLine(number);
        Console.WriteLine(floatingnumber);
        Console.WriteLine(number + null);
        Console.WriteLine(floatingnumber + 20.45);
    }
}

