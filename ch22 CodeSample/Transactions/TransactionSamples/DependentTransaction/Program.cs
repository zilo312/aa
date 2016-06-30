using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Data.SqlClient;
using System.Threading;

namespace Wrox.ProCSharp.Transactions
{
    class Program
    {
        static void TxThread(object obj)
        {
            Thread.Sleep(3000);
            DependentTransaction tx = obj as DependentTransaction;
            Utilities.DisplayTransactionInformation("Dependent Transaction",
                tx.TransactionInformation);
            tx.Complete();

            Utilities.DisplayTransactionInformation("Dependent TX Complete",
                tx.TransactionInformation);
        }

        static void Main()
        {
            CommittableTransaction tx = new CommittableTransaction();
            Utilities.DisplayTransactionInformation("Root TX created", tx.TransactionInformation);

            try
            {
                new Thread(TxThread).Start(
                    tx.DependentClone(DependentCloneOption.BlockCommitUntilComplete));



                if (Utilities.AbortTx())
                {
                    throw new ApplicationException("transaction abort");
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tx.Rollback();
            }

            Utilities.DisplayTransactionInformation("Root TX finished", tx.TransactionInformation);
            
        }
    }
}
