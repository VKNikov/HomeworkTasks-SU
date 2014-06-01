//Problem 10.	* Beer Time
//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] 
//and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
//Note that you may need to learn how to parse dates and times. 

using System;
using System.Globalization;


class BeerTime
{
    static void Main()
    {
        Console.WriteLine("This program will tell you if it is Beer Time or not.");
        Console.WriteLine("Please enter a time now in format hh:mm tt.");
        string userinput = Console.ReadLine();
        string beerBegin = "1:00 PM";
        string beerEnd = "3:00 AM";
        DateTime beerTime1 = DateTime.Parse(beerBegin);
        DateTime beerTime2 = DateTime.Parse(beerEnd);
        DateTime time;


        if (DateTime.TryParseExact(userinput, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out time))
        {
            if (time.TimeOfDay >= beerTime1.TimeOfDay || time.TimeOfDay < beerTime2.TimeOfDay)
            {
                Console.WriteLine("beer time!");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid time");
        }
    }
}
