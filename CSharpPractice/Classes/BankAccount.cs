﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Classes
{
    public class BankAccount: IInformation
    {
        private double balance;

        public double Balance
        {
            get
            {
                if (balance < 1000000)
                    return balance;

                return balance;
            }
            protected set
            {
                if(value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public BankAccount()
        {
            Balance = 100;
        }

        public BankAccount(double initialBalance)
        {
            Balance += initialBalance;
        }

        public virtual double AddToBalance(double balanceToBeAdded)
        {   
            Balance += balanceToBeAdded;
            return balance;
        }

        public string GetInformation()
        {
            return $"Your current balance is: {Balance:c}";
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            Balance = 10;
        }

        public override double AddToBalance(double balanceToBeAdded)
        {
            if (balanceToBeAdded > 1000)
                balanceToBeAdded = 1000;
            if (balanceToBeAdded < -1000)
                balanceToBeAdded = -1000;

            return base.AddToBalance(balanceToBeAdded);
        }
    }
}
