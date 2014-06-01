using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        int counter = 0;

        for (int i = 0; i < 100; i++)
        {
            List<int> numbers = new List<int>();
            int randomNumber = 0;
            Random numberGen = new Random();

            while (true)
            {
                randomNumber = numberGen.Next(1, 4);
                if (numbers.Contains(randomNumber) || numbers.Count == 3)
                {
                    if (numbers.Contains(randomNumber) && numbers.Count < 3)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else if (numbers.Count < 3)
                {
                    numbers.Add(randomNumber);
                }

            }

            //Apparently this doesn't do anything usefull right now...
            if (numbers[1] == 2 || numbers[1] == 3)
            {
                numbers.RemoveAt(1);
            }
            else
            {
                numbers.RemoveAt(2);
            }

            //Later to add an option to change the door.

            if (numbers[0] == 1)
            {
                counter++;
            }

            //This is needed so that the random generator can really work.
            Thread.Sleep(10);
        }

        Console.WriteLine(counter);
        Console.ReadKey();
    }
}