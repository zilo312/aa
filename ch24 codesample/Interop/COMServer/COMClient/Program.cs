using System;
using System.Runtime.InteropServices;
using Wrox.ProCSharp.COMInterop.Server;

namespace Wrox.ProCSharp.COMInterop.Client
{
   class Program
   {
      static void Main()
      {
         COMDemo obj = new COMDemo();
         IWelcome welcome = obj;
         Console.WriteLine(welcome.Greeting("Christian"));

         obj.Completed += () => Console.WriteLine("Calculation completed");
            //delegate
            //{
            //   Console.WriteLine("Calculation completed");
            //};

         IMath math;
         math = (IMath)welcome;
         int x = math.Add(4, 5);
         Console.WriteLine(x);

         Marshal.ReleaseComObject(math);

      }
   }
}
