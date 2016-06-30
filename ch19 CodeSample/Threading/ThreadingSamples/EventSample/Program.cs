using System;
using System.Threading;


namespace EventSample
{
   public struct InputData
   {
      public int X;
      public int Y;

      public InputData(int x, int y)
      {
         this.X = x;
         this.Y = y;
      }
   }

   public class ThreadTask
   {
      private AutoResetEvent autoEvent;

      public int Result { get; private set; }

      public ThreadTask(AutoResetEvent ev)
      {
         this.autoEvent = ev;
      }

      public void Calculation(object obj)
      {
         InputData data = (InputData)obj;
         Console.WriteLine("Thread {0} starts calculation", 
            Thread.CurrentThread.ManagedThreadId);
         Thread.Sleep(new Random().Next(3000));
         Result = data.X + data.Y;

         // signal the event - completed!
         Console.WriteLine("Thread {0} is ready", 
            Thread.CurrentThread.ManagedThreadId);
         autoEvent.Set();

      }
   }

   class Program
   {

      static void Main()
      {
         int taskCount = 4;

         AutoResetEvent[] autoEvents = new AutoResetEvent[taskCount];
         ThreadTask[] tasks = new ThreadTask[taskCount];

         for (int i = 0; i < taskCount; i++)
         {
            autoEvents[i] = new AutoResetEvent(false);
            tasks[i] = new ThreadTask(autoEvents[i]);

            if (!ThreadPool.QueueUserWorkItem(tasks[i].Calculation,
               new InputData(i + 1, i + 3)))
            {
               Console.WriteLine("not executed");
            }
         }

         for (int i = 0; i < taskCount; i++)
         {
            int index = WaitHandle.WaitAny(autoEvents);
            if (index == WaitHandle.WaitTimeout)
            {
               Console.WriteLine("Timeout!!");
            }
            else
            {
               Console.WriteLine("finished task for {0}, result: {1}", index,
                  tasks[index].Result);
               

            }
            
         }

      }
   }
}
