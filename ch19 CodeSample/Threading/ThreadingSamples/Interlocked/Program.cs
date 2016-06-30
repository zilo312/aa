using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Wrox.ProCSharp.Threading
{
   public class SomeState
   {
   }

   public class Demo
   {
      SomeState someState;

      public void Foo(SomeState newState)
      {
         lock (this)
         {
            if (someState == null)
            {
               someState = newState;
            } 
         }

         Interlocked.CompareExchange<SomeState>(ref someState, newState, null);
      }
   }

   class Program
   {

      static void Main(string[] args)
      {
         int i = 3;
         Console.WriteLine(Interlocked.Increment(ref i));

      }
   }
}
