using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Collections
{
   public class RacerComparer : IComparer<Racer>
   {
      public enum CompareType
      {
         FirstName,
         LastName,
         Country,
         Wins
      }

      private CompareType compareType;
      public RacerComparer(CompareType compareType)
      {
         this.compareType = compareType;
      }

      public int Compare(Racer x, Racer y)
      {
         if (x == null) throw new ArgumentNullException("x");
         if (y == null) throw new ArgumentNullException("y");    

         int result;
         switch (compareType)
         {
            case CompareType.FirstName:
               return x.FirstName.CompareTo(y.FirstName);
            case CompareType.LastName:
               return x.LastName.CompareTo(y.LastName);
            case CompareType.Country:
               if ((result = x.Country.CompareTo(y.Country)) == 0)
                  return x.LastName.CompareTo(y.LastName);
               else
                  return result;
            case CompareType.Wins:
               return x.Wins.CompareTo(y.Wins);
            default:
               throw new ArgumentException("Invalid Compare Type");
         }

      }
   }

}
