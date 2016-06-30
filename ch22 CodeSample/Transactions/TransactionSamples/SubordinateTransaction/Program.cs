using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Wrox.ProCSharp.Transactions
{
    class Program
    {
        static void Main()
        {
            SubordinateTransaction tx = new SubordinateTransaction(
                IsolationLevel.ReadCommitted, 
            
        }
    }
}
