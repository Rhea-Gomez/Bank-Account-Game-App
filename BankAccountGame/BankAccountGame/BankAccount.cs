using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountGame
{
    internal class BankAccount
    {
        private string accountHolder;
        private double balance;

        public string AccountHolder { get { return accountHolder; } set { accountHolder = value; } }

        public double Balance { get { return balance; } set { balance = value; } }

        public BankAccount(string accountHolder, int balance) {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public double WithDraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
    }
}
