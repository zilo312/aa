using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wrox.ProCSharp.Generics
{
    public class Account : IAccount
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public Account(string name, Decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }
    }

}
