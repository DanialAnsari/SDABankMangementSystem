using DataAccessTier;
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
        DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectAbsentee");

            return dt;

        }
           public DataTable SelectRecordswithName(string name)
        {

            dt = db.Select("SelectAbsenteeNameFromID  '" + name + "'");

            return dt;

        }

        public DataTable SelectRecordswithAllAbsentee(int id)
        {

            dt = db.Select("SelectAllAbsentee " + id);

            return dt;

        }

        public DataTable SelectRecordswithId(int id)
        {

            dt = db.Select("SelectAllAbsenteeWithID " +id);

            return dt;

        }

 public void InsertAbsentee( DateTime AbsenteeDate, string AbsenteeDescription)
        {

            db.insertUpdateDelete("InsertAbsentee '" + AbsenteeDate + "' '" + AbsenteeDescription + "' ");
        }

        public void UpdateAbsentee(DateTime AbsenteeDate, string AbsenteeDescription)
        {

            db.insertUpdateDelete("UpdateAbsentee'" + AbsenteeDate + "' '" + AbsenteeDescription + "'" );
        }

        public void DeleteAbsentee(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteAbsentee " + id);
        }
    }
     



    }

    class Account {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectAccount");

            return dt;

        }
    public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectAccountwithID  '" + id);

            return dt;

        }

        public DataTable SelectRecordswithPersonID(int id)
        {

            dt = db.Select("SelectAccountwithPersonID " + id);

            return dt;

        }

         public void InsertAccount( int PersonID,int AccountNumber,String AccountTitle,int CurrentBalance, DateTime DateOpened,DateTime DateClosed )
        {

            db.insertUpdateDelete("InsertAccount '" + PersonID + "' '" + AccountNumber + "' '"+AccountTitle+"''"+CurrentBalance+"''"+DateOpened+"''"+DateClosed+"' ");
        }

        public void UpdateAccount( int PersonID,int AccountNumber,String AccountTitle,int CurrentBalance, DateTime DateOpened,DateTime DateClosed)
        {

            db.insertUpdateDelete("UpdateAccount'" + PersonID + "' '" + AccountNumber + "' '"+AccountTitle+"''"+CurrentBalance+"''"+DateOpened+"''"+DateClosed+"' " );
        }

        public void DeleteAccount(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteAccount " + id);
        }





}

    class BankTransaction { 
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectTransaction");

            return dt;

        }
}

    class City {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectCity");

            return dt;

        } 
}

    class Customer {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectCustomer");

            return dt;

        } 
}

    class Desgination {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectDesination");

            return dt;

        } 
}

    class Education {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectEducation");

            return dt;

        } 
}

    class Employee {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectEmployee");

            return dt;

        } 
}

    class Loan {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectLoan");

            return dt;

        } 
}

    class LoanInstallment {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectLoanInstallment ");

            return dt;

        } 
}

    class LoanPurpose {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectLoanPurpose");

            return dt;

        } 
}

    class LoanType {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectLoanType");

            return dt;

        } 
}

    class Locker {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectLocker");

            return dt;

        } 
}

    class LockerPossesion {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectLockerPossesion");

            return dt;

        } 
}

    class LockerPurpose { 
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectLockerPurpose");

            return dt;

        }
}

    class MoneyTransfer {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectMoneyTransfer");

            return dt;

        } 
            public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectMoneyTransferWithID " +id);

            return dt;

        }
        public DataTable SelectRecordswithReceiver(string Receiver)
        {

            dt = db.Select("SelectMoneyTransferWithReceiver " +Receiver);

            return dt;

        }
        public DataTable SelectRecordswithSender(string Sender)
        {

            dt = db.Select("SelectMoneyTransferWithSender " +Sender);

            return dt;

        }
         public void InsertMoneyTransfer(int ToAccount , int FromAccount)
        {

            db.insertUpdateDelete("InsertMoneyTransfer '" +ToAccount+ "' '"+FromAccount+"'  ");
        }

        public void UpdateMoneyTransfer( int ToAccount , int FromAccount)
        {

            db.insertUpdateDelete("UpdateMoneyTransfer'" + ToAccount + "' '"+FromAccount+"'  ");
        }

        public void DeleteMoneyTransfer(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteMoneyTransfer" + id);
        }
    }


    class Person {
        DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectPerson");

            return dt;

        }

        public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectPersonwithID " + id);

            return dt;

        }

        public DataTable SelectRecordswithCity(int id)
        {

            dt = db.Select("SelectPersonwithCity " + id);

            return dt;

        }

        public DataTable SelectRecordswithName(string name)
        {

            dt = db.Select("SelectPersonwithName '" + name + "'");

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

        public void InsertPerson(string fn, string ln, string cnic, string address, int cityid, string gender, DateTime birthdate, DateTime Dateadd, string religion, string educationID, string martial, string email)
        {

            db.insertUpdateDelete("InsertPerson '" + fn + "' '" + ln + "' '" + cnic + "' " + address + "' " + cityid + " " + birthdate + "' '" + Dateadd + "' '" + religion + "' '" + educationID + "' '" + martial + "' '" + email + "'");
        }

        public void UpdatePerson(string fn, string ln, string cnic, string address, int cityid, string gender, DateTime birthdate, DateTime Dateadd, string religion, string educationID, string martial, string email)
        {

            db.insertUpdateDelete("UpdatePerson '" + fn + "' '" + ln + "' '" + cnic + "' " + address + "' " + cityid + " " + birthdate + "' '" + Dateadd + "' '" + religion + "' '" + educationID + "' '" + martial + "' '" + email + "'");
        }

        public void DeletePerson(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeletePerson " + id);
        }
    }

    class PhoneNumber {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectPhoneNumber");

            return dt;

        } 
            public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectPhoneNumberasID " +id);

            return dt;

        }
        public DataTable SelectRecordswithPerson(string Person)
        {

            dt = db.Select("SelectPhoneNowithPerson " +Person);

            return dt;

        }
                public void InsertPhoneNo(string Number , int PersonID)
        {

            db.insertUpdateDelete("InsertPhoneNo '" +Number+ "' '"+PersonID+"'  ");
        }

        public void UpdatePhoneNo(string Number , int PersonID)
        {

            db.insertUpdateDelete("UpdatePhoneNo'" +Number+ "' '"+PersonID+"'  ");
        }

        public void DeletePhoneNo(int id)
        {
            //This method Deletes PhoneNo
            db.insertUpdateDelete("DeletePhoneNo" + id);
        }
    }





    class Policy {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectPolicy");

            return dt;

        } 
        public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectPolicywithID " +id);

            return dt;

        }
                      public void InsertPolicy(string PolicyName , float Constant)
        {

            db.insertUpdateDelete("InsertPolicy'" +PolicyName+ "' '"+Constant+"'  ");
        }

        public void UpdatePolicy(string PolicyName , float Constant)
        {

            db.insertUpdateDelete("UpdatePolicy'" +PolicyName+ "' '"+Constant+"'  ");
        }

        public void DeletePolicy(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeletePolicy" + id);
        }
    }


    class Repayment { 
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectRepayment");

            return dt;

        }
            public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectRepaymentwithID " +id);

            return dt;

        }
        public DataTable SelectRecordswithLoanID(int id)
        {

            dt = db.Select("SelectRepaymetnwithLoanID " +id);

            return dt;

        }
        public DataTable SelectRecordswithStatus(string status)
        {

            dt = db.Select("SelectRepaymetnwithStatus '" +status+"' ");

            return dt;

        }
                      public void InsertRepayment(int LoanID ,float AmountPaid ,DateTime PaymentDateTime ,string Status )
        {

            db.insertUpdateDelete("InsertRepayment'" +LoanID+ "' '"+AmountPaid+"' '"+PaymentDateTime+"' '"+Status+"'  ");
        }

        public void UpdateRepayment(int LoanID ,float AmountPaid ,DateTime PaymentDateTime ,string Status )
        {

            db.insertUpdateDelete("InsertRepayment'" +LoanID+ "' '"+AmountPaid+"' '"+PaymentDateTime+"' '"+Status+"'  ");
        }

        public void DeleteRepayment(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteRepayment" + id);
        }
    }


    class Salary {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectSalary");

            return dt;

        } 
}

    class TransactionType {
 DatabaseHelper db = new DatabaseHelper();
        DataTable dt;

        public DataTable SelectRecords()
        {

            dt = db.Select("SelectTransactionType");

            return dt;

        } 
}
