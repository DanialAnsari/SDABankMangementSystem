using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{

    

    class Absentee
    {
    }

    class Account { }

    class BankTransaction { }

    class City { }

    class Customer { }

    class Desgination { }

    class Education { }

    class Employee { }

    class Loan { }

    class LoanInstallment { }

    class LoanPurpose { }

    class LoanType { }

    class Locker { }

    class LockerPossesion { }

    class LockerPurpose { }

    class MoneyTransfer { }

    class Person {

        DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords() {
            
            dt = db.Select("SelectPerson");

            return dt;

        }

        public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectPersonwithID "+id);

            return dt;

        }

        public DataTable SelectRecordswithCity(int id)
        {

            dt = db.Select("SelectPersonwithCity " + id);

            return dt;

        }

        public DataTable SelectRecordswithName(string name)
        {

            dt = db.Select("SelectPersonwithName '" + name+"'");

            return dt;

        }

        public DataTable SelectRecordswithMartial(string name)
        {

            dt = db.Select("SelectPersonwithMartial '" + name + "'");

            return dt;

        }

        public DataTable SelectRecordswithReligion(string name)
        {

            dt = db.Select("SelectPersonwithReligion '" + name + "'");

            return dt;

        }

        public void InsertPerson(string fn, string ln, string cnic, string address, int cityid, string gender, DateTime birthdate, DateTime Dateadd, string religion, string educationID, string martial, string email) {

            db.insertUpdateDelete("InsertPerson '" + fn + "' '" + ln + "' '" + cnic + "' "+  address + "' " + cityid + " " + birthdate + "' '" + Dateadd + "' '" + religion + "' '" + educationID + "' '" + martial + "' '" + email + "'");
        }

        public void UpdatePerson(string fn, string ln, string cnic, string address, int cityid, string gender, DateTime birthdate, DateTime Dateadd, string religion, string educationID, string martial, string email)
        {

            db.insertUpdateDelete("UpdatePerson '" + fn + "' '" + ln + "' '" + cnic + "' " + address + "' " + cityid + " " + birthdate + "' '" + Dateadd + "' '" + religion + "' '" + educationID + "' '" + martial + "' '" + email + "'");
        }

        public void DeletePerson(int id)
        {

            db.insertUpdateDelete("DeletePerson "+id);
        }
    }

    class PhoneNumber { }

    class Policy { }

    class Repayment { }
    class Salary { }

    class TransactionType { }
}
