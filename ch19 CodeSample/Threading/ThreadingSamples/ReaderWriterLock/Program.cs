using System;
using System.Collections.Generic;
using System.Threading;

namespace Wrox.ProCSharp.Threading
{
   class Program
   {
      private static List<int> items = new List<int>() { 0, 1, 2, 3, 4, 5};
      private static ReaderWriterLockSlim rwl = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);

      static void ReaderMethod(object reader)
      {
         try
         {
            rwl.EnterReadLock();

            for (int i = 0; i < items.Count; i++)
            {
               Console.WriteLine("reader {0}, loop: {1}, item: {2}", reader, i, items[i]);
               Thread.Sleep(40);
            }
         }
         finally
         {
            rwl.ExitReadLock();
         }
      }

      static void WriterMethod(object writer)
      {
         try
         {
            while (!rwl.TryEnterWriteLock(50))
            {
               Console.WriteLine("Writer {0} waiting for the write lock", writer);
               Console.WriteLine("current reader count: {0}", rwl.CurrentReadCount);
            }
            Console.WriteLine("Writer {0} acquired the lock", writer);
            for (int i = 0; i < items.Count; i++)
            {
               items[i]++;
               Thread.Sleep(50);
            }
            Console.WriteLine("Writer{0} finished", writer);
         }
         finally
         {
            rwl.ExitWriteLock();
         }
      }


      static void Main()
      {
         new Thread(WriterMethod).Start(1);
         new Thread(ReaderMethod).Start(1);
         new Thread(ReaderMethod).Start(2);
         new Thread(WriterMethod).Start(2);
         new Thread(ReaderMethod).Start(3);
         new Thread(ReaderMethod).Start(4);

         Console.ReadLine();
        

      }

   }
}
