namespace BankOfKurtovoKonare
{
    using System;

    public abstract class Customer : ICustomer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
