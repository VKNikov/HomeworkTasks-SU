//Problem 15. * Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class CalculateAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("This program will tell you how old you are now\nand how old you will be in 10 years.\nIn order to do that please enter your birthday(DD.MM.YYYY): ");
        string userinput = Console.ReadLine();
        DateTime birthday;
        DateTime today = DateTime.Now;
        if (DateTime.TryParse(userinput, out birthday))
        {
            if (birthday.Month > today.Month || (birthday.Month == today.Month && birthday.Day > today.Day)) //THis line checks if your birthday for the current year is yet to come.
            {
                int currentage = today.Year - birthday.Year;
                Console.WriteLine("You are {0} years old", currentage - 1);
                Console.WriteLine("In 10 years from now you will be {0} years old.", currentage + 9);
            }
            else if (birthday.Month < today.Month || (birthday.Month == today.Month && birthday.Day <= today.Day)) //This line checks if your birthday for the current year has already passed
            {
                int currentage = today.Year - birthday.Year;
                Console.WriteLine("You are {0} years old", currentage);
                Console.WriteLine("In 10 years from now you will be {0} years old.", currentage + 10);
            }
        }
        else
        {
            Console.WriteLine("Incorrect date format. Please try again and enter your birthday in format DD.MM.YYYY");
        }
        Console.ReadLine();
    }
}
