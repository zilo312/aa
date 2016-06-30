using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SynchronizationDemo
{

   public class SharedState
   {
      private int state = 0;

      public int State
      {
         get
         {
            return state;
         }
         //set
         //{

         //   state = value;
         //}
      }

      public int IncrementState()
      {
         lock (this)
         {
            return ++state;
         }
         // return Interlocked.Increment(ref state);
      }
	
   }

   public class Task
   {
      SharedState sharedState;
      public Task(SharedState sharedState)
      {
         this.sharedState = sharedState;
      }
      public void DoTheTask()
      {
         for (int i = 0; i < 50000; i++)
         {
            // lock (sharedState)
            {
               // sharedState.State += 1;
               sharedState.IncrementState();
            }
         }

      }
   }

   class Program
   {
      static void Main()
      {
         object obj = new object();
         if (Monitor.TryEnter(obj, 500))
         {
            try
            {
               // acquired the lock
               // synchronized region for obj
            }
            finally
            {
               Monitor.Exit(obj);
            }

         }
         else
         {
            // didn't get the lock, do something else
         }

         int numThreads = 20;
         SharedState state = new SharedState();
         Thread[] threads = new Thread[numThreads];

         for (int i = 0; i < numThreads; i++)
         {
            threads[i] = new Thread(new Task(state).DoTheTask);
            threads[i].Start();
         }

         //for (int i = 0; i < numThreads; i++)
         //{
         //   threads[i].Join();
         //}


         Console.WriteLine("summarized {0}", state.State);
      
      }
   }
}
