namespace BankOfKurtovoKonare
{
    using System;

    public abstract class Account : IAccountable
    {
        protected Account(Customer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public double InterestRate { get; set; }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public abstract void WithdrawMoney(decimal money);

        public abstract void CalculateInterest(double months);
    }
}
