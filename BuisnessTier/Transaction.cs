using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuisnessTier
{
    public class Transaction
    {

        public bool Withdraw(double amount, int accountnumber)
        {
            double balance = 0;
            DataAccessTier.Account da = new DataAccessTier.Account();
            DataTable dt = new DataTable();
            dt=da.SelectRecordswithsmallID(accountnumber);
            balance = Convert.ToDouble(dt.Rows[0][4]);

           
            if (amount < balance)
            {
                balance = balance - amount;
                da.UpdateAccount(dt.Rows[0][2].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), balance, dt.Rows[0][5].ToString());
            }
            else
            {
                MessageBox.Show("invalid withdrawal amount");
            }

            return true;
        }
        public bool Deposit(int accountnumber, double amount)
        {
            double balance = 0;
            DataAccessTier.Account da = new DataAccessTier.Account();
            DataTable dt = new DataTable();
            dt = da.SelectRecordswithsmallID(accountnumber);
            balance = Convert.ToDouble(dt.Rows[0][4]);
            if (amount == 0)
            {
                MessageBox.Show("invalid Deposit amount");
            }
            else
            {
                balance = amount + balance;
                da.UpdateAccount(dt.Rows[0][2].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), balance, dt.Rows[0][5].ToString());

            }
            return true;
        }
        public bool Transfer(int account1, int account2, double transferAmount)
        {
            
            double balance = 0;
            double balance2 = 0;
            DataAccessTier.Account da = new DataAccessTier.Account();
            DataTable dt = new DataTable();
            dt = da.SelectRecordswithsmallID(account1);
            balance = Convert.ToDouble(dt.Rows[0][4]);
            DataTable dt2 = new DataTable();
            dt2 = da.SelectRecordswithsmallID(account2);
            balance2 = Convert.ToDouble(dt2.Rows[0][4]);

            if (transferAmount >= balance)
            {
                throw new ApplicationException("transfer amount must be greater than balance");
            }
            else if (transferAmount <= 0)
            {
                throw new ApplicationException("invalid transfer amount");
            }

            balance = balance - transferAmount;
            balance2 += transferAmount;

            da.UpdateAccount(dt.Rows[0][2].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), balance, dt.Rows[0][5].ToString());
            da.UpdateAccount(dt2.Rows[0][2].ToString(), dt2.Rows[0][2].ToString(), dt2.Rows[0][3].ToString(), balance2, dt2.Rows[0][5].ToString());

            return true;

        }



    }
}