//Problem 9.	Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. 
//If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 

using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Depending on your choice(int, double or string) the program will do different things.");
        Console.WriteLine("Please choose a type: \n{0} --> int", 1);
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int userinput = int.Parse(Console.ReadLine());

        switch (userinput)
        {
            case 1:
                Console.WriteLine("Please enter an integer:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;
                
            case 2:
                Console.WriteLine("Please enter a double:");
                double real = double.Parse(Console.ReadLine());
                Console.WriteLine(real + 1);
                break;
                
            case 3:
                Console.WriteLine("Please enter a string:");
                string words = Console.ReadLine();
                Console.WriteLine("{0}*", words);
                break;

            default:
                Console.WriteLine("Incorrect input");
                break;
        }
    }
}