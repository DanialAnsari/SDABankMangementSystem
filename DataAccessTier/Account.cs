using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
   public class Account
    {
        DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectAccount");

            return dt;

        }
        public DataTable SelectRecordswithID(string id)
        {

            dt = db.Select("SelectAccountwithID  '" + id+"'");

            return dt;

        }

        public DataTable SelectRecordswithPersonID(int id)
        {

            dt = db.Select("SelectAccountwithPersonID " + id);

            return dt;

        }

        public void InsertAccount(int PersonID, string AccountNumber, string AccountTitle, double CurrentBalance, string DateOpened)
        {

            db.insertUpdateDelete("InsertAccount '" + PersonID + "','" + AccountNumber + "','" + AccountTitle + "'," + CurrentBalance + ",'" + DateOpened + "' ");
        }

        public void UpdateAccount(string id, string AccountNumber, string AccountTitle, double CurrentBalance, string DateOpened)
        {

            db.insertUpdateDelete("UpdateAccount '"+id+ "','" + AccountNumber + "','" + AccountTitle + "','" + CurrentBalance + "','" + DateOpened +"' ");
        }

        public void DeleteAccount(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteAccount " + id);
        }
    }
}
