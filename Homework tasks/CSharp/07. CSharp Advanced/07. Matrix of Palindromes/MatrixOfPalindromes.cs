//Problem 7.	Matrix of Palindromes
//Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:

using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.WriteLine("This program generates a matrix of palindromes of 3 letters with r rows and c columns.");
        Console.WriteLine("Please enter value for r:");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for c:");
        int c = int.Parse(Console.ReadLine());

        string[,] matrix = new string[r, c];
        char symbol = 'a';

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                matrix[i, j] = ((char)(symbol + i)).ToString() + ((char)(symbol + j + i)).ToString() + ((char)(symbol +i)).ToString();
            }
        }

        Console.WriteLine("The palindrome matrix looks like this:");

        //Printing the matrix
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
