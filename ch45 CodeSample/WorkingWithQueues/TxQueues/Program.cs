using System;
using System.Messaging;
using System.Transactions;

namespace Wrox.ProCSharp.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
          //  MsmqTx();
            SysTx();
        }

        private static void SysTx()
        {
            if (!MessageQueue.Exists(@".\MyTransactionalQueue"))
            {
                MessageQueue.Create(@".\MyTransactionalQueue", true);
            }
            MessageQueue queue = new MessageQueue(@".\MyTransactionalQueue");

            using (TransactionScope scope = new TransactionScope(
                TransactionScopeOption.Required))
            {
                queue.Send("a", MessageQueueTransactionType.Automatic);
                queue.Send("b", MessageQueueTransactionType.Automatic);
                throw new Exception("ah");
                queue.Send("c", MessageQueueTransactionType.Automatic);

                scope.Complete();
            }

 
        }

        private static void MsmqTx()
        {
            if (!MessageQueue.Exists(@".\MyTransactionalQueue"))
            {
                MessageQueue.Create(@".\MyTransactionalQueue", true);
            }
            MessageQueue queue = new MessageQueue(@".\MyTransactionalQueue");
            MessageQueueTransaction transaction =
                  new MessageQueueTransaction();
            try
            {
                transaction.Begin();
                queue.Send("a", transaction);
                queue.Send("b", transaction);
                queue.Send("c", transaction);
                transaction.Commit();
            }
            catch
            {
                transaction.Abort();
            }
        }
    }
}
