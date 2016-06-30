using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace CrossProcess
{
   class Program
   {
      
      static void ThreadMain(object o)
      {
         Semaphore semaphore = o as Semaphore;
         Trace.Assert(semaphore != null, "o must be a Semaphore type");
         bool isCompleted = false;
         while (!isCompleted)
         {
            if (semaphore.WaitOne(600, false))
            {
               try
               {
                  Console.WriteLine("Thread {0} locks the sempahore",
                        Thread.CurrentThread.ManagedThreadId);
                  Thread.Sleep(2000);
               }
               finally
               {
                  semaphore.Release();
                  Console.WriteLine("Thread {0} releases the semaphore",
                     Thread.CurrentThread.ManagedThreadId);
                  isCompleted = true;
               }
            }
            else
            {
               Console.WriteLine("Timeout for thread {0}; wait again",
                  Thread.CurrentThread.ManagedThreadId);
            }
         }
      }

      static void Main(string[] args)
      {
         //bool createdNew;
         //Mutex mutex = new Mutex(false, "ThreadingDemo", out createdNew);
         //if (mutex.WaitOne())
         //{
         //   try
         //   {


         //   }
         //   finally
         //   {
         //      mutex.ReleaseMutex();
         //   }
         //}
         //else
         //{
         //   // some problem happened 
         //}

         int threadCount = 6;
         int semaphoreCount = 4;
         Semaphore semaphore = new Semaphore(semaphoreCount, semaphoreCount);
         Thread[] threads = new Thread[threadCount];

         for (int i = 0; i < threadCount; i++)
         {
            threads[i] = new Thread(ThreadMain);
            threads[i].Start(semaphore);
            
         }

         for (int i = 0; i < threadCount; i++)
         {
            threads[i].Join();
         }
         Console.WriteLine("all threads finished");
         
         
      }
   }
}
