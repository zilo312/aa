using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Data.SqlClient;

namespace Wrox.ProCSharp.Transactions
{
    class Program
    {
        static void Main()
        {
            CommittableTransaction tx = new CommittableTransaction();
            Utilities.DisplayTransactionInformation("TX created", tx.TransactionInformation);

            try
            {

                Student s1 = new Student();
                s1.FirstName = "Neno";
                s1.LastName = "Loye";
                s1.Company = "thinktecture";
                StudentData db = new StudentData();
                db.AddStudent(s1, tx);


                Student s2 = new Student();
                s2.FirstName = "Dominick";
                s2.LastName = "Baier";
                s2.Company = "thinktecture";
                db.AddStudent(s2, tx);

                Utilities.DisplayTransactionInformation("2nd connection enlisted", tx.TransactionInformation);

             

                if (Utilities.AbortTx())
                {
                    throw new ApplicationException("transaction abort");
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                tx.Rollback();
            }

            Utilities.DisplayTransactionInformation("TX completed", tx.TransactionInformation);
            
        }
    }
}
