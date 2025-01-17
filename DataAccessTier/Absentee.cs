﻿using DataAccessTier;
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

            dt = db.Select("SelectTransactionWithID " +id);

            return dt;

        }
        public DataTable SelectRecordswithType(string type)
        {

            dt = db.Select("SelectTransactionWithType '" +type+"'");

            return dt;

        }


 public void InsertBankTransaction( DateTime TranscationDateTime,int Amount, string TransactionType, int AccountID,string TransactionDescription,string status)
        {

            db.insertUpdateDelete("InsertBankTransaction '" + TranscationDateTime + "' '" + Amount + "''"+TransactionType+"' '"+ AccountID + "' '"+TransactionDescription+"' '"+ status + "' ");
        }

        public void UpdateBankTransaction( DateTime TranscationDateTime,int Amount, string TransactionType, int AccountID,string TransactionDescription,string status)
        {

            db.insertUpdateDelete("UpdateBankTransaction '" + TranscationDateTime + "' '" + Amount + "''"+TransactionType+"' '"+ AccountID + "' '"+TransactionDescription+"' '"+ status + "' ");
        }

        public void DeleteBankTransaction(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteBankTransaction " + id);
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
    public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectCustomerwithID " +id);

            return dt;

        }

        public DataTable SelectRecordswithOrg(string name)
        {

            dt = db.Select("SelectCustomerwithOrg '"+name+"' ");

            return dt;

        }

       
 public void InsertCustomer( string IncomeType, string Occupation,string Organization, string Address , string Designation)
        {

            db.insertUpdateDelete("InsertCustomer '" + IncomeType + "' '" + Occupation + "' '"+Organization+"' '"+Address+"' '"+Designation+"'");
        }

        public void UpdateCustomer(string IncomeType, string Occupation,string Organization, string Address , string Designation)
        {

            db.insertUpdateDelete("UpdateCustomer '" + IncomeType + "' '" + Occupation + "' '"+Organization+"' '"+Address+"' '"+Designation+"'" );
        }

        public void DeleteCustomer(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteCustomer " + id);
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
    public DataTable SelectRecordswithDesignation(string Desig)
        {

            dt = db.Select("SelectEmployeeWithDesignation '" + Desig + "'");

            return dt;

        }

        public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectEmployeeWithID " + id);

            return dt;

        }
     
        public DataTable SelectRecordswithPay(int pay)
        {

            dt = db.Select("SelectEmployeeWithPay " +pay);

            return dt;

        }

 public void InsertEmployee( int SalaryID , string Designation ,string Status , string PayRate )
        {

            db.insertUpdateDelete("InsertEmployee '" + SalaryID + "' '" +Designation + "' '"+Status+"' '"+PayRate+"' ");
        }

        public void UpdateEmployee(int SalaryID , string Designation ,string Status , string PayRate)
        {

            db.insertUpdateDelete("UpdateEmployee '" + SalaryID + "' '" +Designation + "' '"+Status+"' '"+PayRate+"' " );
        }

        public void DeleteEmployee(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteEmployee " + id);
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
    
        public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectLoanwithID " + id);

            return dt;

        }

    public DataTable SelectRecordswithPurpose(string purpose)
        {

            dt = db.Select("SelectLoanwithPurpose  '" + purpose + "'");

            return dt;

        }


        public DataTable SelectRecordswithstatus(int status)
        {

            dt = db.Select("SelectLoanwithStatus '"+status+"' " );

            return dt;

        }

 public void InsertLoan( string Status , int LoanInstallmentID , int LoanTypeID , int LoanPurposeID)
        {

            db.insertUpdateDelete("InsertLoan '" + Status + "' '" + LoanInstallmentID + "' '"+LoanTypeID+"' '"+LoanPurposeID+"' ");
        }

        public void UpdateLoan( string Status , int LoanInstallmentID , int LoanTypeID , int LoanPurposeID)
        {

            db.insertUpdateDelete("UpdateLoan '" + Status + "' '" + LoanInstallmentID + "' '"+LoanTypeID+"' '"+LoanPurposeID+"' ");
        }

        public void DeleteLoan(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteLoan" + id);
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
            public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectLoanInstallmentwithID " +id);

            return dt;

        }

 public void InsertLoanInstallment( string Term, string TermInterest)
        {

            db.insertUpdateDelete("InsertLoanInstallment '" + Term+ "' '" + TermInterest + "' ");
        }

        public void UpdateLoanInstallment(string Term, string TermInterest)
        {

            db.insertUpdateDelete("UpdateLoanInstallment '" + Term + "' '" + TermInterest + "'" );
        }

        public void DeleteLoanInstallment(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete(" DeleteLoanInstallment " + id);
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
            public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectLoanPurposewithID " +id);

            return dt;

        }

 public void InsertLoanPurpose( string LoanPurpose)
        {

            db.insertUpdateDelete("InsertLoanPurpose '" + LoanPurpose+ "'  ");
        }

        public void UpdateLoanPurpose(string LoanPurpose)
        {

            db.insertUpdateDelete("UpdateLoanPurpose '" + LoanPurpose+ "' " );
        }

        public void DeleteLoanPurpose(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete(" DeleteLoanPurpose " + id);
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
            public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectLoanTypewithID " +id);

            return dt;

        }

 public void InsertLoanType( string LoanType)
        {

            db.insertUpdateDelete("InsertLoanType '" + LoanType+ "'  ");
        }

        public void UpdateLoanType(string LoanType)
        {

            db.insertUpdateDelete("UpdateLoanType '" + LoanType+ "' " );
        }

        public void DeleteLoanType(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteLoanType" + id);
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
    public DataTable SelectRecordswithDate(DateTime date)
        {

            dt = db.Select("SelectLockerWithDate  '" + date + "'");

            return dt;

        }

        public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectLockerWithID " + id);

            return dt;

        }

        public DataTable SelectRecordswithPerson(string person)
        {

            dt = db.Select("SelectLockerWithPerson '" +person+"' ");

            return dt;

        }
        public DataTable SelectRecordswithPurpose(string purpose)
        {

            dt = db.Select("SelectLockerWithPerson '" +purpose+"' ");

            return dt;

        }
        public DataTable SelectRecordswithType(string type)
        {

            dt = db.Select("SelectLockerWithType '" +type+"' ");

            return dt;

        }

 public void InsertLocker( int LockerPurposeID, int LockerTypeID ,DateTime DateOpened, string LockerContain ,string LockerDiscription ,int Rent , int PersonID)
        {

            db.insertUpdateDelete("InsertLocker '" + LockerPurposeID + "' '" + LockerTypeID+ "' '"+DateOpened+"' '"+LockerContain+"' '"+LockerDiscription+"' '"+Rent+"' '"+PersonID+"'");
        }

        public void UpdateLocker(int LockerPurposeID, int LockerTypeID ,DateTime DateOpened, string LockerContain ,string LockerDiscription ,int Rent , int PersonID)
        {

            db.insertUpdateDelete("UpdateLocker  '" + LockerPurposeID + "' '" + LockerTypeID+ "' '"+DateOpened+"' '"+LockerContain+"' '"+LockerDiscription+"' '"+Rent+"' '"+PersonID+"'");
        }

        public void DeleteLocker(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteLocker " + id);
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
            public DataTable SelectRecordswithDate(int id)
        {

            dt = db.Select("SelectLockerPossessionwithDate " +id);

            return dt;

        }
        public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectLoanTypewithID " +id);

            return dt;

        }

 public void InsertLockerPossessionRetrieval( int LockerID ,DateTime RetrievalDateTime ,string LockerDescription)
        {

            db.insertUpdateDelete("InsertLockerPossessionRetrieval '" + LockerID+ "' '"+RetrievalDateTime+"' '"+LockerDescription+"'  ");
        }

        public void UpdateLockerPossessionRetrieval(int LockerID ,DateTime RetrievalDateTime ,string LockerDescription)
        {

            db.insertUpdateDelete("UpdateLockerPossessionRetrieval'" + LockerID+ "' '"+RetrievalDateTime+"' '"+LockerDescription+"'  ");
        }

        public void DeleteLockerPossessionRetrieval(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteLockerPossessionRetrieval" + id);
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
            public DataTable SelectRecordswithID(int id)
        {

            dt = db.Select("SelectLockerTypewithDate " +id);

            return dt;

        }
         public void InsertLockerPurpose( string LockerType, int LockerPrice)
        {

            db.insertUpdateDelete("InsertLockerPurpose '" + LockerType+ "' '"+LockerPrice+"'  ");
        }

        public void UpdateLockerType( string LockerType, int LockerPrice)
        {

            db.insertUpdateDelete("UpdateLockerType'" + LockerType+ "' '"+LockerPrice+"'  ");
        }

        public void DeleteLockerType(int id)
        {
            //This method Deletes person
            db.insertUpdateDelete("DeleteLockerPurpose" + id);
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
