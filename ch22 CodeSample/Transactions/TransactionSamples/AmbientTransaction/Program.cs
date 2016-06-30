using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Threading;

namespace Wrox.ProCSharp.Transactions
{
    class Program
    {
        static void Main()
        {
            TransactionOptions options = new TransactionOptions();
            options.IsolationLevel = IsolationLevel.ReadUncommitted;
            options.Timeout = TimeSpan.FromSeconds(90);
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, 
                options))
            {
                Transaction.Current.TransactionCompleted += OnTransactionCompleted;

                Utilities.DisplayTransactionInformation(
                    "Ambient TX created",
                    Transaction.Current.TransactionInformation);

                //Student s1 = new Student();
                //s1.Firstname = "Ingo";
                //s1.Lastname = "Rammer";
                //s1.Company = "thinktecture";
                //StudentData db = new StudentData();
                //db.AddStudent(s1);

                using (TransactionScope scope2 = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    Transaction.Current.TransactionCompleted += OnTransactionCompleted;

                    Utilities.DisplayTransactionInformation(
                        "Inner Transaction Scope",
                        Transaction.Current.TransactionInformation);

                    scope2.Complete();
                }
                scope.Complete();

                //if (!Utilities.AbortTx())
                //    scope.Complete();
                //else
                //    Console.WriteLine("abort transaction");
            }
        }

        static void OnTransactionCompleted(object sender, TransactionEventArgs e)
        {
           Utilities.DisplayTransactionInformation("transaction completed",
              e.Transaction.TransactionInformation);
        }
    }
}
