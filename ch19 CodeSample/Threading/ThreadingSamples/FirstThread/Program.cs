using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FirstThread
{
   class Program
   {
      static void Main(string[] args)
      {
         new Thread(() => Console.WriteLine("running in a thread")).Start();

         Console.WriteLine("This is the main thread.");

      }
   }
}
