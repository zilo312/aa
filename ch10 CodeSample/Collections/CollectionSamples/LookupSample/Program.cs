using System;
using System.Collections.Generic;
using System.Linq;

namespace Wrox.ProCSharp.Collections
{
   class Program
   {
      static void Main(string[] args)
      {
         List<Racer> racers = new List<Racer>();
         racers.Add(new Racer("Jacques", "Villeneuve", "Canada", 11));
         racers.Add(new Racer("Alan", "Jones", "Australia", 12));
         racers.Add(new Racer("Jackie", "Stewart", "United Kingdom", 27));
         racers.Add(new Racer("James", "Hunt", "United Kingdom", 10));
         racers.Add(new Racer("Jack", "Brabham", "Australia", 14));

         
         Lookup<string, Racer> lookupRacers = (Lookup<string, Racer>)racers.ToLookup(r => r.Country);

         foreach (Racer r in lookupRacers["Australia"])
         {
            Console.WriteLine(r);
         }
         
      }
   }
}
