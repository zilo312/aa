using System;
using System.Threading;
using System.Transactions;

namespace Wrox.ProCSharp.Transactions
{
   class Program
   {
      static void Main()
      {
         try
         {
            using (TransactionScope scope = new TransactionScope())
            {
               Transaction.Current.TransactionCompleted += TransactionCompleted;
               Utilities.DisplayTransactionInformation("Main thread TX", Transaction.Current.TransactionInformation);

//               new Thread(ThreadMethod).Start(null);
               new Thread(ThreadMethod).Start(Transaction.Current.DependentClone(DependentCloneOption.BlockCommitUntilComplete));
               scope.Complete();
            }
         }
         catch (TransactionAbortedException ex)
         {
            Console.WriteLine("Main - Transaction was aborted, {0}", ex.Message);

         }
      }

      static void TransactionCompleted(object sender, TransactionEventArgs e)
      {
         Utilities.DisplayTransactionInformation("TX completed", e.Transaction.TransactionInformation);

      }


      static void ThreadMethod(object dependentTx)
      {
         DependentTransaction dTx = dependentTx as DependentTransaction;

         try
         {
            Transaction.Current = dTx;

            using (TransactionScope scope = new TransactionScope())
            {
               Transaction.Current.TransactionCompleted += TransactionCompleted;

               Utilities.DisplayTransactionInformation("Thread TX", Transaction.Current.TransactionInformation);
               scope.Complete();
            }
         }
         catch (TransactionAbortedException ex)
         {
             Console.WriteLine("ThreadMethod - Transaction was aborted, {0}", ex.Message);
         }
         finally
         {
            if (dTx != null)
            {
               dTx.Complete();
            }

         }
      }
   }
}
