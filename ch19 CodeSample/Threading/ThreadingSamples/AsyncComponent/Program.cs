using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Wrox.ProCSharp.Threading
{
   class Program
   {
      static void Main()
      {
         //WindowsFormsSynchronizationContext syncContext = new WindowsFormsSynchronizationContext();
         //SynchronizationContext.SetSynchronizationContext(syncContext);

         Console.WriteLine("Main thread: {0}", Thread.CurrentThread.ManagedThreadId);
         AsyncComponent comp = new AsyncComponent();
         comp.LongTaskCompleted += new LongTaskCompletedEventHandler(comp_LongTaskCompleted);

         comp.LongTaskAsync("input", 33);

         Console.ReadLine();
         // Thread.Sleep(12000);
      }

      static void comp_LongTaskCompleted(object sender, LongTaskCompletedEventArgs e)
      {
         Console.WriteLine("completed, result: {0}, thread: {1}", e.Output, Thread.CurrentThread.ManagedThreadId);
      }
   }
}
