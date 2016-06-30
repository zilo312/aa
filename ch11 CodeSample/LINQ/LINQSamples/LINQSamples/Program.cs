using System;
using System.Collections.Generic;
using System.Linq;

namespace Wrox.ProCSharp.LINQ
{
   class Program
   {
      static void Main(string[] args)
      {
         TraditionalQuery();
         ExtensionMethods();
         LambdaExpressions();
         LinqQuery();
      }

      private static void LinqQuery()
      {
         List<Racer> champions = new List<Racer>(Formula1.GetChampions());
         var query = from r in Formula1.GetChampions()
                     where r.Country == "Brazil"
                     orderby r.Wins descending
                     select r;

         foreach (Racer r in query)
         {
            Console.WriteLine("{0:A}", r);
         }
      }

      private static void LambdaExpressions()
      {
         List<Racer> champions = new List<Racer>(Formula1.GetChampions());
         IEnumerable<Racer> brazilChampions = champions.
            Where(r => r.Country == "Brazil").
            OrderByDescending(r => r.Wins).
            Select(r => r);

         foreach (Racer r in brazilChampions)
         {
            Console.WriteLine("{0:A}", r);
         }
      }

      private static void ExtensionMethods()
      {
         List<Racer> champions = new List<Racer>(Formula1.GetChampions());
         IEnumerable<Racer> brazilChampions = champions.Where(
            delegate(Racer r)
            {
               return r.Country == "Brazil";
            }).OrderByDescending(
            delegate(Racer r)
            {
               return r.Wins;
            }).Select(
            delegate(Racer r)
            {
               return r;
            });

         foreach (Racer r in brazilChampions)
         {
            Console.WriteLine("{0:A}", r);
         }
           
      }

      private static void TraditionalQuery()
      {
         List<Racer> champions = new List<Racer>(Formula1.GetChampions());
         List<Racer> brazilChampions = champions.FindAll(
            delegate(Racer r)
            {
               return r.Country == "Brazil";
            });

         brazilChampions.Sort(
            delegate(Racer r1, Racer r2)
            {
               return r2.Wins.CompareTo(r1.Wins);
            });

         foreach (Racer r in brazilChampions)
         {
            Console.WriteLine("{0:A}", r);
         }

      }
   }
}
