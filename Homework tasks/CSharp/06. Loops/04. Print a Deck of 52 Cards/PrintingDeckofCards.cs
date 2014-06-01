//Problem 4.	Print a Deck of 52 Cards
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintingDeckofCards
{
    static void Main()
    {
        int rows = 13;
        int columns = 4;
        string[] cardLetters = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        char[] cardSign = { '♣', '♦', '♥', '♠' };

        for (int i = 1; i <= rows; i++)
        {
            Console.Write("{0,3}{1} ", cardLetters[i - 1], cardSign[0]);

            for (int j = 1; j < columns; j++)
            {
                switch (i)
                {
                    case 1:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 2:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 3:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 4:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 5:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 6:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 7:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 8:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 9:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 10:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 11:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 12:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                    case 13:
                        Console.Write(" {0,3}{1} ", cardLetters[i - 1], cardSign[j]);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

