using System;

namespace Banking_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var acct1 = new Account();
            acct1.Id = 1;
            acct1.Description = "New Account";
            //acct1.Print();
            //acct1.Deposit(10000);
            //acct1.Print();
            //acct1.Withdraw(2550);
            //acct1.Print();
            //acct1.Withdraw(0);
            //acct1.Deposit(-50000);
            //acct1.Withdraw(8000);
            //acct1.Print();

            var acct2 = new Account();
            acct2.Id = 2;
            acct2.Description = "Charlie's Account";
            acct2.Deposit(10000);
            acct2.Print();
            acct1.Deposit(10000);
            acct1.Print();
            acct1.Transfer(5000, acct2);
            acct1.Print();
            acct2.Print();
        }
    }
}
