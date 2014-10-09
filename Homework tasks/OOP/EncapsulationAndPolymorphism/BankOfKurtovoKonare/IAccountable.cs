namespace BankOfKurtovoKonare
{
    using System;

    public interface IAccountable
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        double InterestRate { get; set; }
        void DepositMoney(decimal money);
        void WithdrawMoney(decimal money);
        void CalculateInterest(double interest);
    }
}
