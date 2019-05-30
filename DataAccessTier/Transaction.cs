using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
   public class Transaction
    {

        DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectTransaction");

            return dt;

        }
        public DataTable SelectRecordswithName(string name)
        {

            dt = db.Select("SelectAbsenteeNameFromID  '" + name + "'");

            return dt;

        }

        public DataTable SelectRecordswithAccountID(int id)
        {

            dt = db.Select("SelectTransactionWithAccountID " + id);

            return dt;

        }

        public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectTransactionWithID " + id);

            return dt;

        }
        public DataTable SelectRecordswithType(string type)
        {

            dt = db.Select("SelectTransactionWithType '" + type + "'");

            return dt;

        }


        public void InsertBankTransaction(string TranscationDateTime, double Amount, string TransactionType, int AccountID, string TransactionDescription, string status)
        {

            db.insertUpdateDelete("InsertTransaction '" + TranscationDateTime + "','" + Amount + "','" + TransactionType + "'," + AccountID + ",'" + TransactionDescription + "','" + status + "' ");
        }

        public void UpdateBankTransaction(string TranscationDateTime, double Amount, string TransactionType, int AccountID, string TransactionDescription, string status)
        {

            db.insertUpdateDelete("UpdateBankTransaction '" + TranscationDateTime + "' '" + Amount + "''" + TransactionType + "' '" + AccountID + "' '" + TransactionDescription + "' '" + status + "' ");
        }

        public void DeleteBankTransaction(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteTransaction " + id);
        }

    }
}
