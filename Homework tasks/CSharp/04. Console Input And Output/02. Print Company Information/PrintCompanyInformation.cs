//Problem 2.	Print Company Information
//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("This program will read user input data about a Company and it's manager and then will print it to the console. The Company has name, address, phone number, fax number, web site and a manager.\n The manager has first name, last name, age and a phone number");
            Console.WriteLine("Please write in the name of the Company:");
            string companyName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(companyName))
            {
                Console.WriteLine("The company name cannot be blank. Please enter a name:");
                companyName = Console.ReadLine();
            }

            Console.WriteLine("Please write in it's address:");
            string address = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("The company's address cannot be blank. Please enter an address:");
                address = Console.ReadLine();
            }

            Console.WriteLine("Please write in the Company's phone number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Please write in the Company's fax number:");
            string faxNumber = Console.ReadLine();
            Console.WriteLine("Please enter the Company's web site:");
            string webSite = Console.ReadLine();
            Console.WriteLine("Now please write in the manager's first name:");
            string firstName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("The Manager's first name cannot be blank. Please enter a first name:");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("Please write in the manager's last name:");
            string lastName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("The Manager's last name cannot be blank. Please enter a last name:");
                lastName = Console.ReadLine();
            }

            Console.WriteLine("Please write in the manager's age");
            string ageInput = Console.ReadLine();
            byte age;

            while (!byte.TryParse(ageInput, out age) && age > 100 && age < 18)
            {
                Console.WriteLine("This is not a correct integer value or age. Please try again:");
                ageInput = Console.ReadLine();
            }

            Console.WriteLine("Please write in the manager's phone number:");
            string managerNumber = Console.ReadLine();
            Console.WriteLine("The information you have entered is as follows:");
            Console.WriteLine("Company's Name: {0}\nCompany's address: {1}\nCompany's phone number: {2}\nCompany's fax number: {3}\nCompany's web site: {4}", companyName, address, phoneNumber, faxNumber, webSite);
            Console.WriteLine("Manager's first and last name: {0} {1}\nHis age is: {2}\nHis phone number is {3}", firstName, lastName, age, managerNumber);
        }
    }