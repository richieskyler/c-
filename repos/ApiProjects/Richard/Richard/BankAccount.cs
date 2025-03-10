using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class BankAccount
    {
        private decimal balance; 
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void deposit(decimal amount)
        {
            if (amount > 0)
                Console.WriteLine(balance += amount);
        }

        public void withdrawal(decimal amount)
        {
            if (amount > 0 && amount <= balance)
               Console.WriteLine(balance -= amount);
        }

        public decimal getBalance()
        {
            return balance;
        }
    }
}
