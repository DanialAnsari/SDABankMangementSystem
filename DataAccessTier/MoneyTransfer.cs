using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
   public class MoneyTransfer
    {

        DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectMoneyTransfer");

            return dt;

        }
        public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectMoneyTransferWithID " + id);

            return dt;

        }
        public DataTable SelectRecordswithReceiver(string Receiver)
        {

            dt = db.Select("SelectMoneyTransferWithReceiver " + Receiver);

            return dt;

        }
        public DataTable SelectRecordswithSender(string Sender)
        {

            dt = db.Select("SelectMoneyTransferWithSender " + Sender);

            return dt;

        }
        public void InsertMoneyTransfer(int id,int ToAccount, int FromAccount)
        {

            db.insertUpdateDelete("InsertMoneyTransfer "+id+"," + ToAccount + "," + FromAccount);
        }

        public void UpdateMoneyTransfer(int ToAccount, int FromAccount)
        {

            db.insertUpdateDelete("UpdateMoneyTransfer'" + ToAccount + "' '" + FromAccount + "'  ");
        }

        public void DeleteMoneyTransfer(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteMoneyTransfer" + id);
        }
    }
}
