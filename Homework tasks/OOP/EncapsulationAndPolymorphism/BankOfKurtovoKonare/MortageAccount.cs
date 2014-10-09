namespace BankOfKurtovoKonare
{
    using System;

    public class MortageAccount : Account
    {
        public MortageAccount(Customer customer, decimal balance, double interest)
            : base(customer, balance, interest)
        {
        }

        public override void CalculateInterest(double months)
        {
            if (this.Customer is IndividualPerson)
            {
                if (months <= 6)
                {
                    Console.WriteLine("The is no interest for the first six months!");
                }
                else
                {
                    decimal interest = this.Balance * (1 + (decimal)(this.InterestRate * (months - 6)) / 100);
                    Console.WriteLine("The interest for the period of {0} months would be {1}", months, interest);
                }
            }
            else 
            {
                if (months <= 12)
                {
                    decimal interest = this.Balance * (1 + (decimal)((this.InterestRate / 2) * 12) / 100);
                    Console.WriteLine("The interest for the period of {0} months would be {1}", months, interest);
                }
                else
                {
                    decimal interest = this.Balance * (1 + (decimal)((this.InterestRate / 2) * 12) / 100);
                    interest += this.Balance * (1 + (decimal)(this.InterestRate * (months - 12)) / 100);
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
