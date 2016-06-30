using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wrox.ProCSharp.Generics
{
    public static class Algorithm
    {
        public static decimal AccumulateSimple(IEnumerable<Account> e)
        {
            decimal sum = 0;
            foreach (Account a in e)
            {
                sum += a.Balance;
            }
            return sum;
        }

        public static decimal Accumulate<TAccount>(IEnumerable<TAccount> coll)
            where TAccount : IAccount
        {
            decimal sum = 0;

            foreach (TAccount a in coll)
            {
                sum += a.Balance;
            }
            return sum;
        }


        public delegate TSummary Action<TInput, TSummary>(TInput t, TSummary u);

        public static TSummary Accumulate<TInput, TSummary>(IEnumerable<TInput> coll,
              Action<TInput, TSummary> action)
        {
            TSummary sum = default(TSummary);

            foreach (TInput input in coll)
            {
                sum = action(input, sum);
            }
            return sum;
        }

        public static TSummary AccumulateIf<TInput, TSummary>(
              IEnumerable<TInput> coll,
              Action<TInput, TSummary> action,
              Predicate<TInput> match)
        {
            TSummary sum = default(TSummary);

            foreach (TInput a in coll)
            {
                if (match(a))
                {
                    sum = action(a, sum);
                }
            }
            return sum;
        }



    }

}
