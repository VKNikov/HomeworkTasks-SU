//Problem 3.	Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("This program will check if a given integer can be divided (without remainder) both by 7 and by 5.\nIf it the number is divisible to both 7 and 5, the program will return True.\nPlease enter an integer");
        string userInput = Console.ReadLine();
        int a;

        while (!int.TryParse(userInput, out a))
        {
            Console.WriteLine("This is not an integer. Please try again with an integer!");
            userInput = Console.ReadLine();
        }

        bool check = ((a % 7 == 0) && (a % 5 == 0));
        Console.WriteLine(a == 0? false : check); //This additional boolean check is needed because in the example in the homework document 0 divided by 7 and 5 gives false.
        Console.WriteLine("Press enter to exit...");
        Console.ReadKey();
    }
}