using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TimerSample
{
   class Program
   {
      static void Main()
      {
         ThreadingTimer();

         TimersTimer();
      }

      private static void TimersTimer()
      {
         System.Timers.Timer t1 = new System.Timers.Timer(1000);
         t1.AutoReset = true;
         t1.Elapsed += new System.Timers.ElapsedEventHandler(TimeAction);
         t1.Start();

         Thread.Sleep(10000);
         t1.Stop();

         t1.Dispose();
      }

      private static void ThreadingTimer()
      {
         System.Threading.Timer t1 = new System.Threading.Timer(
            TimeAction, null, TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(3));

         Thread.Sleep(15000);

         t1.Dispose();
      }

      static void TimeAction(object sender, System.Timers.ElapsedEventArgs e)
      {
         Console.WriteLine("System.Timers.Timer {0:T}", e.SignalTime );
         
      }

      static void TimeAction(object o)
      {
         Console.WriteLine("System.Threading.Timer {0:T}", DateTime.Now);
      }
   }
}
