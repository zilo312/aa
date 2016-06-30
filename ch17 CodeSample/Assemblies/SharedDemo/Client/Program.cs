using System;

namespace Wrox.ProCSharp.Assemblies.Sharing
{
   class Program
   {
      static void Main()
      {
         SharedDemo quotes =
             new SharedDemo(@"C:\ProCSharp\Assemblies\Quotes.txt");

         Console.WriteLine(quotes.GetAssemblyFullName());

         //for (int i = 0; i < 3; i++)
         //{
         //   Console.WriteLine(quotes.GetQuoteOfTheDay());
         //   Console.WriteLine();
         //}
      }
   }
}

