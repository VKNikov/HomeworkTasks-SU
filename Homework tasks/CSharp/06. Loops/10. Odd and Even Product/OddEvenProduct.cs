//Problem 10.	Odd and Even Product
//You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 

using System;

class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("This program checks whether the product of the odd elements is equal to the product of the even elements in given n integers.\nThe first element is odd, the second is even.");
        Console.WriteLine("Please write in the sequence of n integers (separated by a space) that you want to be checked:");
        string userinput = Console.ReadLine();
        string [] asNumbers = userinput.Split(' ');

        int[] numbers   = new int [asNumbers.Length];
        int productOdd  = 1;
        int productEven = 1;

        for (int i = 0; i < asNumbers.Length; i++)
        {
            numbers[i] = int.Parse(asNumbers[i]);
            if (i % 2 == 0)
            {
                productEven *= numbers[i];
            }
            else
            {
                productOdd *= numbers[i];
            }
        }
        bool checkEquality = productOdd == productEven;

        switch (checkEquality)
        {
            case true:
                Console.WriteLine("Yes\nProduct = {0}", productEven);
                break;
            case false:
                Console.WriteLine("No\nodd_product = {0}\neven_product = {1}", productOdd, productEven);
                break;
        }
    }
}
