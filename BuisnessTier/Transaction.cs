using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessTier
{
    class Transaction
    {

        public bool Withdraw(double amount, int accountnumber)
        {
            double balance = 0;
            //amount2=getamount from account using accountid
            if (amount > balance)
            {
                balance = balance - amount;
                //update amount
            }
            else
            {
                throw new ApplicationException("invalid withdrawal amount");
            }

            return true;
        }
        public bool Deposit(int accountnumber, double amount)
        {
            double balance = 0;
            if (amount == 0)
            {
                throw new ApplicationException("invalid Deposit amount");
            }
            else
            {
                balance = amount + balance;

            }
            return true;
        }
        public bool Transfer(int account1, int account2, double transferAmount)
        {
            double balance = 0;
            if (transferAmount >= balance)
            {
                throw new ApplicationException("transfer amount must be greater than balance");
            }
            else if (transferAmount <= 0)
            {
                throw new ApplicationException("invalid transfer amount");
            }
            return true;

        }



    }
}