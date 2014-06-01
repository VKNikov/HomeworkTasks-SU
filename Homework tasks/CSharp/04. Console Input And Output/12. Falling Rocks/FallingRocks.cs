//Problem 12.	** Falling Rocks - Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash. Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150). Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Threading;

class FallingRocks
{

    //The game is still in development :). Does not work.
    struct Rock
    {
        public int x;
        public int y;
        public string c;
        public ConsoleColor color;
    }

    static void PrintPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);

    }
    static void Main()
    {
        //Console.BufferHeight = Console.WindowHeight = 30;
        //Console.BufferWidth = Console.WindowWidth = 30;
        Console.SetWindowSize(30, 30);
        Console.SetBufferSize(30, 30);
        //Console.CursorVisible = false;


        string[] signs = { "#", "*", "**", "+", "++", "^", "$", "L", "?" };
        int lives = 2;
        Rock player = new Rock();
        player.x = Console.WindowWidth / 2;
        player.y = Console.WindowHeight - 1;
        player.color = ConsoleColor.White;
        player.c = "@";
        Random randomGen = new Random();
        List<Rock> rocks = new List<Rock>();



        while (lives > 0)
        {
            Rock newRock = new Rock();
            newRock.x = randomGen.Next(0, Console.WindowWidth);
            newRock.y = 0;
            newRock.color = ConsoleColor.Red;
            newRock.c = "*";
            rocks.Add(newRock);

            //foreach (Rock rock in rocks)
            //{
            //    PrintPosition(rock.x, rock.y, rock.c, rock.color);
            //}

            PrintPosition(player.x, player.y, player.c);
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                //while (Console.KeyAvailable)
                //{
                //    Console.ReadKey(true);
                //}

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (player.x - 1 >= 0)
                    {
                        player.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (player.x + 1 <= Console.WindowWidth - 1)
                    {
                        player.x++;
                    }
                }
                else if (pressedKey.Key ==  ConsoleKey.UpArrow)
                {
                    if (player.y - 1 >= 0)
                    {
                        player.y--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (player.y + 1 <= Console.WindowHeight - 1)
                    {
                        player.y++;
                    }
                }
                
            }

            for (int i = 0; i < rocks.Count; i++)
            {
                Rock rock = rocks[i];
                rock.y = rock.y + 1;
            }
            Thread.Sleep(150);
            Console.Clear();
            
        }

    }
}