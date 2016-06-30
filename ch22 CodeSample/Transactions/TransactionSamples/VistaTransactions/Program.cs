using System.IO;
using System.Transactions;

namespace Wrox.ProCSharp.Transactions
{
    class Program
    {
        static void Main()
        {
           TransactionOptions options = new TransactionOptions();
           options.IsolationLevel = IsolationLevel.Serializable;

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, options))
            {
                FileStream stream = TransactedFile.GetTransactedFileStream("c:/frequentis/temp/sample.txt");

                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine("Write a transactional file");
                writer.Close();

                if (!Utilities.AbortTx())
                    scope.Complete();
            }
        }
    }
}
