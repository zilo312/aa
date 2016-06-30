using System;
using System.Transactions;
using System.Data.SqlClient;


namespace Wrox.ProCSharp.Transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            CommittableTransaction tx = new CommittableTransaction();
            SqlConnection connection;
            connection.EnlistTransaction(tx);
        }
    }
}
