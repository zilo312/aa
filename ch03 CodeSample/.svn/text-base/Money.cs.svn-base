using System;

namespace Wrox.ProCSharp.OOCSharp
{
   class MainEntryPoint
   {
      static void Main(string[] args)
      {
         Money cash1 = new Money();
         cash1.Amount = 40M;
         Console.WriteLine("cash1.ToString() returns: " + cash1.ToString());
         //Extension Method
         cash1.AddToAmount(10M);
         Console.WriteLine("cash1.ToString() returns: " + cash1.ToString());
         Console.ReadLine();
      }
   }
   class Money
   {
      private decimal amount;

      public decimal Amount
      {
         get
         {
            return amount;
         }
         set
         {
            amount = value;
         }
      }
      public override string ToString()
      {
         return "$" + Amount.ToString();
      }
   }

}
