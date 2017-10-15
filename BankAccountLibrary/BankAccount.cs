using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public class BankAccount
    {
        private string _accountId;
        private double _balance;

        public BankAccount(string accountId, double balance)
        {
            _accountId = accountId;
            _balance = balance;
        }

        public double Balance => _balance;

        public void Debit(double amount)
        {

            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            _balance -= amount;
        }

        public void Credit(double amount)
        {

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            _balance += amount;
        }


    }
}
