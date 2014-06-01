//Problem 11.	Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        //I have assigned random values to the variables, just for illustration purposes.
        string firstname = "Ivan";
        string middlename = "Ivanov";
        string lastname = "Ivanov";
        decimal balance = 1056089.53m;
        object IBAN = "BG50RZBB91556585274610";
        ulong ccvisa = 75860134860383000;
        ulong ccmaestro = 16587631586830144;
        ulong ccmaster = 446826418955227698;
    }
}
