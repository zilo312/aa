using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Collections
{
    [Serializable]
   public struct EmployeeId  : IEquatable<EmployeeId>
   {
      private readonly char prefix;
      private readonly int number;

      public EmployeeId(string id)
      {
         if (id == null) throw new ArgumentNullException("id");

         prefix = (id.ToUpper())[0];
         int numLength = id.Length - 1;
         number = int.Parse(id.Substring(1, numLength > 6 ? 6 : numLength));
      }

      public override string ToString()
      {
         return prefix.ToString() + string.Format("{0,6:000000}", number);
      }

      public override int GetHashCode()
      {
         return (number ^ number << 16) * 0x15051505;
      }


      public bool Equals(EmployeeId other)
      {
         return (prefix == other.prefix && number == other.number);
      }

       public override bool Equals(object obj)
       {
           if (!(obj is EmployeeId)) return false;
           return Equals((EmployeeId)obj);
       }

       public static bool operator ==(EmployeeId emp1, EmployeeId emp2)
       {
           return emp1.Equals(emp2);
       }

       public static bool operator !=(EmployeeId emp1, EmployeeId emp2)
       {
           return !emp1.Equals(emp2);
       }

   }
}
