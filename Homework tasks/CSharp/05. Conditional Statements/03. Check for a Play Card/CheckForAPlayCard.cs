//Problem 3.	Check for a Play Card
//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("This program will print Yes if you enter a valid play card sign.\nIf you do not, it will print No.");
        Console.WriteLine("Enter a sign:");
        string sign = Console.ReadLine();
        int n;
        
        bool intcheck = int.TryParse(sign, out n);

        if (intcheck == true && (n > 1 && n < 11))
        {
            Console.WriteLine("Yes");
        }
        else if (intcheck == false)
        {
            char ch = char.Parse(sign.Substring(0, 1));

            if (ch == (char)74 || ch == (char)75 || ch == (char)81 || ch == (char)65)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}