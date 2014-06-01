//Problem 19.	** Spiral Matrix
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below. 

using System;

class SpiralMatrix
{
    static void Main()
    {
        //Maybe the solution could be optimized and maybe I've declared too many variables. However this problem took me really a lot of time to solve so for now I will leave it like that.
        Console.WriteLine("This program prints a square spiral like matrix, holding all the numbers from 1 to n * n (n must be between 1 and 20.");
        Console.WriteLine("Please enter value for n:");
        int n = int.Parse(Console.ReadLine());
        int totalNumbers = n * n;
        int printedNumbers = 1;
        int remainingRows = n - 1;
        int remainingColumns = n - 1;
        int column = n - 1;
        int row = 0;

        int[,] matrix = new int[n, n];

        //I put everything in a big for loop. It's purpose is to loop the other loops enough times so that all the rows and columns get filled with the necessary values.
        for (int k = 0; k < n; k++)
        {
            //This loop sets the matrix'values from left to right.
            for (int i = row; i <= remainingColumns; i++)
            {
                if (matrix[row, i] == 0)
                {
                    matrix[row, i] = printedNumbers;
                    printedNumbers++;
                }                
            }
            row++;

            //This loop sets the matrix'values from top to bottom.
            for (int i = row; i <= remainingRows; i++)
            {
                if (matrix[i, remainingColumns] == 0)
                {
                    matrix[i, remainingColumns] = printedNumbers;
                    printedNumbers++;
                }               
            }
            column--;
            remainingColumns--;

            //This loop sets the matrix'values from right to left.
            for (int i = column; i >= 0; i--)
            {
                if (matrix[remainingRows, i] == 0)
                {
                    matrix[remainingRows, i] = printedNumbers;
                    printedNumbers++;
                }
            }

            remainingRows--;
            row--;

            //This loop sets the matrix'values from bottom to top.
            for (int i = remainingRows; i > 0; i--)
            {
                if (matrix[i, row] == 0)
                {
                    matrix[i, row] = printedNumbers;
                    printedNumbers++;
                }
            }
            row++;
            n--;
        }

        //This final loop prints the matrix.
        for (int i = 0; i < Math.Sqrt(totalNumbers); i++)
        {
            for (int j = 0; j < Math.Sqrt(totalNumbers); j++)
            {
                Console.Write("{0,-5}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
