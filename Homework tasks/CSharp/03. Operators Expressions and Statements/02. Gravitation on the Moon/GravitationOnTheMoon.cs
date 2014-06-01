//Problem 2.	Gravitation on the Moon
//The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("This program will try to approximately calculate your weight if you were on the Moon.\nIn order to do so, please write in how much do you weight now");
        string userInput = Console.ReadLine();
        double a;

        while (!double.TryParse(userInput, out a))
        {
            Console.WriteLine("You have entered incorrect value. Please try again.");
            userInput = Console.ReadLine();
        }
        Console.WriteLine("If you were on the Moon you you would have weighted {0}", a * 0.17);
    }
}
