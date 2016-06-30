using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Wrox.ProCSharp.Assemblies.Sharing
{
   public class SharedDemo
   {
      private List<string> quotes;
      private Random random;

      public SharedDemo(string filename)
      {
         quotes = new List<string>();
         Stream stream = File.OpenRead(filename);
         StreamReader streamReader = new StreamReader(stream);
         string quote;
         while ((quote = streamReader.ReadLine()) != null)
         {
            quotes.Add(quote);
         }
         streamReader.Close();
         stream.Close();
         random = new Random();
      }

      public string GetQuoteOfTheDay()
      {
         int index = random.Next(1, quotes.Count);
         return quotes[index];
      }

      public string GetAssemblyFullName()
      {
         return Assembly.GetExecutingAssembly().FullName;
      }

   }
}

