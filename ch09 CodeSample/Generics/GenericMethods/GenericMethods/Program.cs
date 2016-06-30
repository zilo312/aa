using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wrox.ProCSharp.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account("Christian", 1500));
            accounts.Add(new Account("Sharon", 2200));
            accounts.Add(new Account("Katie", 1800));

            decimal amount = Algorithm.AccumulateSimple(accounts);

            decimal amount2 = Algorithm.Accumulate(accounts);

            decimal amount3 = Algorithm.Accumulate<Account, decimal>(
                accounts, 
                delegate(Account a, decimal d)
                { return a.Balance + d; });

            decimal amount4 = Algorithm.Accumulate<Account, decimal>(
                accounts, (a, d) => a.Balance + d);

            decimal amount5 = Algorithm.AccumulateIf<Account, decimal>(
               accounts, (a, d) => a.Balance + d, a => a.Balance > 2000);


        }
    }
}
