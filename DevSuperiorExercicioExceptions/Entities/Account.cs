using DevSuperiorExercicioExceptions.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevSuperiorExercicioExceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new TransactionException("You cannot deposit this amount");
            this.Balance += amount;
        }

        public void Withdraw(double amount) 
        {
            if (amount > this.WithdrawLimit)
                throw new TransactionException("The amount exceeds withdraw limit");
            if (amount > this.Balance)
                throw new TransactionException("Not enough balance");
            this.Balance -= amount;
        }
    }
}
