namespace BankOfKurtovoKonare
{
    using System;
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, double interest)
            : base(customer, balance, interest)
        {
        }

        public override void WithdrawMoney(decimal money)
        {
            if (money > this.Balance)
            {
                throw new ArgumentOutOfRangeException("You cannot withdraw more money than you have in your account!");
            }

            this.Balance -= money;
        }

        public override void CalculateInterest(double months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                Console.WriteLine("There is no interest!");
            }
            else
            {
                decimal interest = this.Balance * (1 + (decimal)(this.InterestRate * months / 100));
                Console.WriteLine("The interest for the period of {0} months would be {1}", months, interest - this.Balance);
            }
        }
    }
}
