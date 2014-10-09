namespace BankOfKurtovoKonare
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            Customer pesho = new IndividualPerson("Pesho Peshev");
            Customer globalEntertainmentOOD = new Company("Global Entertainment LTD");
            IAccountable depositAcc = new DepositAccount(pesho, 2000m, 1.7d);
            IAccountable loanAcc = new LoanAccount(pesho, 5000, 5.5d);
            IAccountable mortageAcc = new MortageAccount(globalEntertainmentOOD, 100000, 2.3d);

            IList<IAccountable> accounts = new List<IAccountable>() { depositAcc, loanAcc, mortageAcc};

            depositAcc.CalculateInterest(8d);
            depositAcc.DepositMoney(200m);
            depositAcc.WithdrawMoney(50m);
            loanAcc.CalculateInterest(20d);
        }
    }
}
