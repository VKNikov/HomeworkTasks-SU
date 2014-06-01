//Problem 8.	Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. 
//Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyrightsign = '\u00A9';
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("This should be an isosceles triangle :)\n");
        Console.WriteLine("   {0}", copyrightsign);
        Console.WriteLine("  {0} {0}", copyrightsign);
        Console.WriteLine(" {0}   {0}", copyrightsign);
        Console.WriteLine("{0} {0} {0} {0}", copyrightsign);
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}

