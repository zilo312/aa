using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Wrox.ProCSharp.Threading
{
   class Program
   {
      static void Main()
      {
         // Race conditions
         //StateObject state = new StateObject();
         //for (int i = 0; i < 2; i++)
         //{
         //   new Thread(new SampleThread().RaceCondition).Start(state);
         //}

         // Deadlock
         StateObject s1 = new StateObject();
         StateObject s2 = new StateObject();
         new Thread(new SampleThread(s1, s2).Deadlock1).Start();
         new Thread(new SampleThread(s1, s2).Deadlock2).Start();

      }
   }
}
