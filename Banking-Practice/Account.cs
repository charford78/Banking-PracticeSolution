using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Practice
{
    class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }

        public bool Deposit(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Cannot enter 0 or negative numbers!");
                return false;
            }
            this.Balance = this.Balance + amount;
            return true;
        }

        public bool Withdraw(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Cannot enter 0 or negative numbers!");
                return false;
            }
            if (amount > this.Balance)
            {
                Console.WriteLine("Insufficient funds!");
                return false;
            }
            this.Balance = this.Balance - amount;
            return true;
        }

        public bool Transfer(int amount, Account ToAccount)
        {
            var success = this.Withdraw(amount);
            if (success == true)
            {
                ToAccount.Deposit(amount);
                return true;
            }
            return false;
        }
        
        public void Print()
        {
            Console.WriteLine($"{Id} | {Balance} | {Description}");
        }
    }
}
