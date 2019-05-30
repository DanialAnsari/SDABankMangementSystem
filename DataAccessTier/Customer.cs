using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{

       public class Customer
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt;

            public DataTable SelectRecords()
            {

                dt = db.Select("SelectCustomer");

                return dt;

            }
            public DataTable SelectRecordswithID(int id)
            {

                dt = db.Select("SelectCustomerwithID " + id);

                return dt;

            }

            public DataTable SelectRecordswithOrg(string name)
            {

                dt = db.Select("SelectCustomerwithOrg '" + name + "' ");

                return dt;

            }


            public void InsertCustomer(int id,string IncomeType, string Occupation, string Organization, string Designation)
            {

                db.insertUpdateDelete("InsertCustomer "+id+",'" + IncomeType + "','" + Occupation + "','" + Organization + "','"  + Designation + "'");
            }

            public void UpdateCustomer(int id,string IncomeType, string Occupation, string Organization, string Designation)
            {

                db.insertUpdateDelete("UpdateCustomer "+id+",'" + IncomeType + "','" + Occupation + "','" + Organization +  "','" + Designation + "'");
            }

            public void DeleteCustomer(int id)
            {
                //This method Deletes person
                db.insertUpdateDelete("DeleteCustomer " + id);
            }
        }
}
