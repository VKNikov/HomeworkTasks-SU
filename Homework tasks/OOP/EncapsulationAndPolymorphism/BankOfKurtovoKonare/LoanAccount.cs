namespace BankOfKurtovoKonare
{
    using System;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, double interest)
            : base(customer, balance, interest)
        {
        }

        public override void CalculateInterest(double months)
        {
            if (this.Customer is IndividualPerson)
            {
                if (months <= 3)
                {
                    Console.WriteLine("The is no interest for the first six months!");
                }
                else
                {
                    decimal interest = this.Balance * (1 + (decimal)(this.InterestRate * (months - 3)) / 100);
                    Console.WriteLine("The interest for the period of {0} months would be {1}", months, interest);
                }
            }
            else
            {
                if (months <= 2)
                {
                    Console.WriteLine("The is no interest for the first six months!");
                }
                else
                {
                    decimal interest = this.Balance * (1 + (decimal)(this.InterestRate * (months - 2)) / 100);
                    Console.WriteLine("The interest for the period of {0} months would be {1}", months, interest);
                }
            }
        }

        public override void WithdrawMoney(decimal money)
        {
            throw new Exception("You cannot withdraw money from this account!");
        }
    }
}
